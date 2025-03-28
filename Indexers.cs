using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March29
{

    class Indexers
    {
        // Read-only dictionary to store key-value pairs
        public readonly Dictionary<string, string> _dictionary;

        // Property to store expiry date
        public DateTime Expiry { get; set; }

        // Constructor to initialize the dictionary
        public Indexers()
        {
            _dictionary = new Dictionary<string, string>();
        }

        // Indexer to access dictionary values
        public string this[string key]
        {
            get
            {
                // Check if the key exists before accessing it
                if (_dictionary.TryGetValue(key, out var value))
                {
                    return value;
                }
                else
                {
                    return null; // or throw an exception, or return a default value
                }
            }
            set { _dictionary[key] = value; }
        }
    }

}
