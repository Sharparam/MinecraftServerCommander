/*
 * This file is released under public domain.
 * 
 * Code obtained from:
 *   http://damieng.com/blog/2006/08/08/calculating_crc32_in_c_and_net
 * 
 * Credits for the code goes to:
 *   Damien Guard
 *   
 * Modifications by:
 *   Adam Hellberg
 * 
 */

using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace MinecraftServerCommander.Library
{
	public sealed class Crc32 : HashAlgorithm
	{
		public const UInt32 DefaultPolynomial = 0xedb88320;
		public const UInt32 DefaultSeed = 0xffffffff;

		private UInt32 _hash;
		private readonly UInt32 _seed;
		private readonly UInt32[] _table;
		private static UInt32[] _defaultTable;

		public Crc32()
		{
			_table = InitializeTable(DefaultPolynomial);
			_seed = DefaultSeed;
			Initialize();
		}

		public Crc32(UInt32 polynomial, UInt32 seed)
		{
			_table = InitializeTable(polynomial);
			_seed = seed;
			Initialize();
		}

		public override void Initialize()
		{
			_hash = _seed;
		}

		protected override void HashCore(byte[] buffer, int start, int length)
		{
			_hash = CalculateHash(_table, _hash, buffer, start, length);
		}

		protected override byte[] HashFinal()
		{
			byte[] hashBuffer = UInt32ToBigEndianBytes(~_hash);
			this.HashValue = hashBuffer;
			return hashBuffer;
		}

		public override int HashSize
		{
			get { return 32; }
		}

		public static UInt32 Compute(byte[] buffer)
		{
			return ~CalculateHash(InitializeTable(DefaultPolynomial), DefaultSeed, buffer, 0, buffer.Length);
		}

		public static UInt32 Compute(UInt32 seed, byte[] buffer)
		{
			return ~CalculateHash(InitializeTable(DefaultPolynomial), seed, buffer, 0, buffer.Length);
		}

		public static UInt32 Compute(UInt32 polynomial, UInt32 seed, byte[] buffer)
		{
			return ~CalculateHash(InitializeTable(polynomial), seed, buffer, 0, buffer.Length);
		}

		public string ComputeFile(string fileName)
		{
			using (FileStream fs = File.Open(fileName, FileMode.Open))
				return String.Concat(ComputeHash(fs).Select(x => x.ToString("x2")));
		}

		public ConcurrentDictionary<string, string> ComputeDirectory(string path)
		{
			var hashes = new ConcurrentDictionary<string, string>();
			DoFolder(path, f => hashes.TryAdd(f, ComputeFile(f)));
			return hashes;
		}

		private static void DoFolder(string path, Action<string> callback)
		{
			Parallel.ForEach(Directory.GetDirectories(path), p => DoFolder(p, callback));
			Parallel.ForEach(Directory.GetFiles(path), callback);
		}

		private static UInt32[] InitializeTable(UInt32 polynomial)
		{
			if (polynomial == DefaultPolynomial && _defaultTable != null)
				return _defaultTable;

			var createTable = new UInt32[256];
			for (int i = 0; i < 256; i++)
			{
				var entry = (UInt32)i;
				for (int j = 0; j < 8; j++)
					if ((entry & 1) == 1)
						entry = (entry >> 1) ^ polynomial;
					else
						entry = entry >> 1;
				createTable[i] = entry;
			}

			if (polynomial == DefaultPolynomial)
				_defaultTable = createTable;

			return createTable;
		}

		private static UInt32 CalculateHash(UInt32[] table, UInt32 seed, byte[] buffer, int start, int size)
		{
			UInt32 crc = seed;
			for (int i = start; i < size; i++)
				unchecked
				{
					crc = (crc >> 8) ^ table[buffer[i] ^ crc & 0xff];
				}
			return crc;
		}

		private byte[] UInt32ToBigEndianBytes(UInt32 x)
		{
			return new byte[] {
			(byte)((x >> 24) & 0xff),
			(byte)((x >> 16) & 0xff),
			(byte)((x >> 8) & 0xff),
			(byte)(x & 0xff)
		};
		}
	}
}
