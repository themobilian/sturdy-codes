/*
Every email consists of a local name and a domain name, separated by the @ sign.
For example, in alice@leetcode.com, alice is the local name, and leetcode.com is the domain name.
Besides lowercase letters, these emails may contain '.'s or '+'s.
If you add periods ('.') between some characters in the local name part of an email address, mail sent there will be forwarded to the same address without dots in the local name.  For example, "alice.z@leetcode.com" and "alicez@leetcode.com" forward to the same email address.  (Note that this rule does not apply for domain names.)
If you add a plus ('+') in the local name, everything after the first plus sign will be ignored. This allows certain emails to be filtered, for example m.y+name@email.com will be forwarded to my@email.com.  (Again, this rule does not apply for domain names.)
It is possible to use both of these rules at the same time.
iven a list of emails, we send one email to each address in the list.  How many different addresses actually receive mails? 

Example 1:

Input: ["test.email+alex@leetcode.com","test.e.mail+bob.cathy@leetcode.com","testemail+david@lee.tcode.com"]
Output: 2
Explanation: "testemail@leetcode.com" and "testemail@lee.tcode.com" actually receive mails
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _929.UniqueEmailAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] emails = { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };
            Console.WriteLine("{0}", new Program().NumUniqueEmails(emails));
            Console.ReadLine();
        }

        public int NumUniqueEmails(string[] emails)
        {
            int indexer = 0;
            string[] uniqueEmails = new string[emails.Length];
            foreach(string email in emails)
            {
                StringBuilder uniqueEmail = new StringBuilder(email.Split('+').FirstOrDefault().Replace(".",""));
                uniqueEmail.Append('@'+email.Split('@')[1]);
                if (!uniqueEmails.Contains(uniqueEmail.ToString()))
                {
                    uniqueEmails[indexer++] = uniqueEmail.ToString();
                }
            }
            return indexer;
        }

        //Faster
        public int NumUniqueEmailsStr(string[] emails)
        {
            int indexer = 0;
            string[] uniqueEmails = new string[emails.Length];
            foreach (string email in emails)
            {
                string uniqueEmail = (email.Split('+').FirstOrDefault().Replace(".", ""));
                uniqueEmail+='@' + email.Split('@')[1];
                if (!uniqueEmails.Contains(uniqueEmail))
                {
                    uniqueEmails[indexer++] = uniqueEmail;
                }
            }
            return indexer;
        }

    }
}
