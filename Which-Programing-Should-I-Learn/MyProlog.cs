using NUnit.Framework;
using SbsSW.SwiPlCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Which_Programing_Should_I_Learn
{
    class MyProlog
    {
        public void LoadFile(string s)
        {
            s = "consult('" + s + "')";
            string query = s.Replace("\\", "//"); //Xu ly duong dan
            string[] p = { "-q", "-f", query };
            PlEngine.Initialize(p);
            try
            {
                PlQuery q = new PlQuery(query);
                Assert.IsTrue(q.NextSolution());
            }
            catch (SbsSW.SwiPlCs.Exceptions.PlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString(), "Lỗi");
            }
        }

        public string GetResult(string s)
        {
            s.Trim();
            Regex r = new Regex(@"[A-Z][a-zA-Z]*");
            MatchCollection matches = r.Matches(s);
            string result = "";
            try
            {
                PlQuery q = new PlQuery(s);
                bool HasSolution = false;
                foreach (PlQueryVariables v in q.SolutionVariables)
                {
                    HasSolution = true;
                    foreach (Match match in matches)
                    {
                        result += v[match.ToString()].ToString();
                    }
                }
                if (matches.Count == 0)
                    return HasSolution ? "true" : "false";
                return result;
            }
            catch (SbsSW.SwiPlCs.Exceptions.PlException ex)
            {
                return "Error query: " + ex.Message;
            }
        }
    }
}
