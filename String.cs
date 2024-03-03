  public static class STring
  {
      public static void print(String[] a)
      {
          foreach (String x in a)
              Console.WriteLine(x);
      }
      public static void print(string a)
      {
          for (int i = 0; i < a.Length; i++)
              Console.WriteLine(a[i]);
      }

      public static String[] split(String x)
      {
          return x.Split(' ');
      }

      public static String from_arr_str(String[] a)
      {
          String x = "";
          for (int i = 0; i < a.Length; i++)
              x += a[i];
          return x;
      }
      public static String to_lower(String x)
      {
          String y = "";
          for (int i = 0; i < x.Length; i++)
          {
              char ch = Char.ToLower(x[i]);
              y += ch;
          }
          return y;
      }

      public static String to_upper(String x)
      {
          String y = "";
          for (int i = 0; i < x.Length; i++)
          {
              char ch = Char.ToUpper(x[i]);
              y += ch;
          }
          return y;
      }
      public static String from_char_str(char[] x)
      {
          String y = "";
          for (int i = 0; i < x.Length; i++)
              y += x[i];
          return y;
      }
      public static char[] to_char_array(String x)
      {
          char[] ch = new char[x.Length];
          for (int i = 0; i < x.Length; i++)
              ch[i] = char_at(x, i);
          return ch;
      }

      public static char char_at(String x, int index)
      {
          return x[index];
      }

      public static bool is_empty(String x)
      {
          return x == "";
      }
      public static bool CheckUniqueString(this string x)
      {
          for (int i = 0; i < x.Length; i++)
              for (int j = i + 1; j < x.Length; j++)
                  if (x[i] == x[j])
                      return false;
          return true;
      }
      public static bool palindromes(String x)
      {
          String y = reverse(x);
          return x == y;
      }

      public static bool is_anagram(String x, String y)
      {
          x = sort_str(x);
          y = sort_str(y);
          return x == y;
      }
      public static String[] extract_palindromes(String x)
      {
          String[] y = x.Split(' ');
          int count = 0;
          for (int i = 0; i < y.Length; i++)
              if (palindromes(y[i]))
                  count++;
          String[] a = new string[count];
          count = 0;
          for (int i = 0; i < y.Length; i++)
              if (palindromes(y[i]))
                  a[count++] = y[i];

          return a;

      }
      public static int last_index(String x, char y)
      {
          int c = -1;
          for (int i = 0; i < x.Length; i++)
              if (x[i] == y)
                  c = i;
          return c;
      }

      public static int n_index(String x, char y, int count)
      {
          int index = -1;
          int c = 0;
          for (int i = 0; i < x.Length; i++)
          {
              if (x[i] == y)
              {
                  c++;
              }
              if (c == count)
              {
                  return i;
              }
          }
          return index;
      }

      public static int first_index(String x, char y)
      {
          int c = -1;
          for (int i = 0; i < x.Length; i++)
              if (x[i] == y)
              {
                  c = i;
                  break;
              }
          return c;
      }

      public static String remove_first_space(String x)
      {
          String y = "";
          int c = -1;
          for (int i = 0; i < x.Length; i++)
              if (x[i] == ' ')
                  c = i;
              else
                  break;
          for (int i = c + 1; i < x.Length; i++)
              y += x[i];
          return y;
      }

      public static String remove_last_space(String x)
      {
          String y = "";
          int c = x.Length;
          for (int i = x.Length - 1; i >= 0; i--)
              if (x[i] == ' ')
                  c = i;
              else
                  break;
          for (int i = 0; i < c; i++)
              y += x[i];
          return y;
      }

      public static String reverse(String x)
      {
          String y = "";
          for (int i = x.Length - 1; i >= 0; i--)
              y += x[i];
          return y;
      }

      public static String reverse_words(String x)
      {
          String y = "";
          String[] A = x.Split(" ");
          for (int i = A.Length - 1; i >= 0; i--)
              y += A[i] + " ";
          return y;
      }

      public static bool contain(String x, char y)
      {
          for (int i = 0; i < x.Length; i++)
              if (x[i] == y)
                  return true;
          return false;
      }

      public static void print_occure_char(String x)
      {
          String y = remove_duplicate_1(x);
          Console.WriteLine(y);
          for (int i = 0; i < y.Length; i++)
          {
              Console.WriteLine(y[i].ToString() + "\t" + (occurence(x, y[i])).ToString());
          }
      }
      public static int count_substring_in_string(String x, String y)
      {
          int count = 0;
          for (int i = 0; i < x.Length - y.Length; i++)
          {
              for (int j = i; j < x.Length - 1; j++)
              {
                  ;
              }
          }
          return count;
      }
      public static String sort_str(String x)
      {
          String y = "";
          while (x != "")
          {
              char m = min_char(x);
              y += m;
              x = remove_first_char(x, m);
          }
          return y;
      }

      public static String sort_words(String x)
      {
          String[] y = x.Split(' ');
          return "";
      }
      public static String remove_all_char(String x, char y)
      {
          String a = "";
          for (int i = 0; i < x.Length; i++)
              if (x[i] != y)
                  a += x[i];
          return a;
      }
      public static String remove_first_char(String x, char y)
      {
          int index = x.IndexOf(y);
          String a = x.Substring(0, index) + x.Substring(index + 1);
          return a;
      }

      public static String remove_last_char(String x, char y)
      {
          int index = x.LastIndexOf(y);
          String a = x.Substring(0, index) + x.Substring(index + 1);
          return a;
      }
      public static String remove_n_index_char(String x, char y)
      {
          String a;
          int index = STring.n_index(x, y, 3);
          a = x.Substring(0, index) + x.Substring(index + 1);
          return a;
      }
      public static String remove_duplicate(String x)
      {
          String y = "";
          for (int i = 0; i < x.Length; i++)
              if (!STring.contain(y, x[i]))
                  y += x[i];
          return y;
      }
      public static String remove_duplicate_1(String x)
      {
          char[] a = x.Distinct().ToArray();
          String y = from_char_str(a);
          return y;

      }

      public static int occurence(String x, char y)
      {
          int count = 0;
          for (int i = 0; i < x.Length; i++)
              if (x[i] == y)
                  count++;
          return count;
      }

      public static char most_common(String x)
      {
          int m = occurence(x, x[0]);
          int c = 0;
          char a = x[0];
          for (int i = 0; i < x.Length; i++)
          {
              c = occurence(x, x[i]);
              if (c > m)

              {
                  m = c;
                  a = x[i];
              }
          }
          return a;
      }

      public static void print_duplicate_characters(String x)
      {

          for (int i = 0; i < x.Length; i++)
              if (occurence(x, x[i]) > 1)
                  Console.WriteLine(x[i]);
      }

      public static int count_unique_chars(String x)
      {
          int count = 0;
          x = remove_duplicate(x);
          count = x.Length;
          return count;
      }
      public static int count_unique_chars_1(String x)
      {
          int count = 0;
          count = x.Distinct().ToArray().Length;
          // count = x.Length;

          return count;
      }

      public static char first_non_repeating_char(String x)
      {
          char a = ' ';
          for (int i = 0; i < x.Length; i++)
              if (occurence(x, x[i]) == 1)
                  return x[i];
          return a;
      }

      public static String swap(String x, char a, char b)
      {
          String y = "";
          for (int i = 0; i < x.Length; i++)
          {
              if (x[i] == a)
              {
                  y += b;
                  y += x.Substring(i + 1);
              }
              else
                  y += x[i];
          }
          return y;
      }

      public static String insert(String x, int pos, String y)
      {
          y += x.Substring(pos, x.Length - 1);
          x = x.Substring(0, pos) + y;
          return x;
      }

      public static String concat(String x, String y)
      {
          return x + y;
      }

      public static char max_char(this string x)
      {
          char y = x[0];
          for (int i = 1; i < x.Length; i++)
              if (x[i] > y)
                  y = x[i];
          return y;
      }
      public static char min_char(String x)
      {
          char y = x[0];
          for (int i = 1; i < x.Length; i++)
              if (x[i] < y)
                  y = x[i];
          return y;
      }

      public static int freq_seqence(String x, String y)
      {
          int count = 0;


          return count;
      }

  }