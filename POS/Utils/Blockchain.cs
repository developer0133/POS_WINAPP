using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Utils
{
    public class Blockchain
    {
        public List<Block> Chain { get; set; }

        public Blockchain()
        {
            Chain = new List<Block> { CreateGenesisBlock() };
        }

        private Block CreateGenesisBlock()
        {
            return new Block(0, DateTime.UtcNow, "Genesis Block", "0");
        }

        public Block GetLatestBlock()
        {
            return Chain[Chain.Count - 1];
        }

        public void AddBlock(string data)
        {
            Block latest = GetLatestBlock();
            Block newBlock = new Block(latest.Index + 1, DateTime.UtcNow, data, latest.Hash);
            Chain.Add(newBlock);
        }

        public bool IsValid()
        {
            for (int i = 1; i < Chain.Count; i++)
            {
                Block current = Chain[i];
                Block previous = Chain[i - 1];

                if (current.Hash != current.CalculateHash()) return false;
                if (current.PreviousHash != previous.Hash) return false;
            }
            return true;
        }
    }
}
