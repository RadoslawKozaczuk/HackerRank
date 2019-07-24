using System.Collections.Generic;

namespace CSharpSolutions.Solutions
{
    class DictionariesAndHashmaps
    {
        /// <summary>
        /// Return "YES" if both strings share at least one character, "NO" otherwise.
        /// </summary>
        public static string TwoStrings(string s1, string s2)
        {
            /*  --- from all the hash map containers dictionary is the fastest ---
                
                Container 	Add Time 	Contains Time 	Remove Time
                Hashtable 	2184 	    714 	        794
                HashSet 	2635 	    697 	        659
                Dictionary 	2247 	    622 	        720

                --- this is how we create them --- 
                Hashtable hashtable = new Hashtable();
		        HashSet<MyObject> hashSet = new HashSet<MyObject>();
		        Dictionary<MyObject, bool> dictionary = new Dictionary<MyObject, bool>();
            */

            var set = new HashSet<char>();
            for (int i = 0; i < s1.Length; i++)
                set.Add(s1[i]);

            for(int i = 0; i < s2.Length; i++)
                if(set.Contains(s2[i]))
                    return "YES";

            return "NO";
        }
    }
}
