using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountAppWithState.Model
{
    internal class AccountManager
    {
        //public static string FilePath = ConfigurationManager.AppSettings["AccountDataFilePath"];
        public static string FilePath = "C:\\Users\\Brave\\Desktop\\Aurionpro_training\\Assignments\\16\\BankAccountAppWithState\\accountDetails.txt";

        public static string SaveAccount(Account account)
        {
            try
            {
                using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, account);
                }
                return null;
            }
            catch (Exception ex)
            {
                return $"Error saving account data: {ex.Message}";
                //Console.WriteLine($"Error saving account data: {ex.Message}");
            }
        }

        public static Account LoadAccount()
        {
            try
            {
                using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (Account)formatter.Deserialize(fs);
                }
            }
            catch (FileNotFoundException)
            {
                return null; // Account file does not exist.
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error loading account data: {ex.Message}");
                return null;
            }
        }

        public static void Deposit(Account account, double amount)
        {
            if (amount > 0)
                account.Balance += amount;
        }

        public static void Withdraw(Account account, double amount)
        {
            double minBalance = 500;
            double potentialBalance = account.Balance - amount;

            if (potentialBalance >= minBalance)
            {
                account.Balance = potentialBalance;
            }
        }

        public static double CheckBalance(Account account)
        {
            return account.Balance;
        }
    }

}
