class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        anagrams = {}
        
        for s in strs:
            # Sort the string to create a key
            key = ''.join(sorted(s))
            
            # Add the string to the corresponding anagram group
            if key in anagrams:
                anagrams[key].append(s)
            else:
                anagrams[key] = [s]
        
        # Return the grouped anagrams as a list of lists
        return list(anagrams.values())