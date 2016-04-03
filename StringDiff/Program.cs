namespace StringDiff
{
    public class KMPplus
    {
        private int[] next;
        private string pattern;
        private int pattern_length;

        public KMPplus(string pattern)
        {
            this.pattern = pattern;
            this.pattern_length = pattern.Length;
            this.next = new int[pattern_length];
            int j = -1;
            for (int i = 0; i < pattern_length; i++)
            {
                if (i == 0)
                    next[i] = -1;
                else if (pattern[i] != pattern[j])
                    next[i] = j;
                else
                    next[i] = next[j];
                while (j >=0 && pattern[i] != pattern[j])
                {
                    j = next[j];
                }
                j++;
            }
        }

        public int search(string str)
        {
            int length = str.Length;
            int i, j;
            for (i = 0,j=0; i < length && j<pattern_length; i++)
            {
                while (j >= 0 && str[i] != pattern[j])
                    j = next[j];
                j++;
            }
            if (j == pattern_length)
                return i - pattern_length;
            return -1;
        }
    }
}
