using System;
using System.Collections.Generic;

namespace MoneyTransactions {
    public class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<int, decimal> transactions = new Dictionary<int, decimal>();

            for (int i = 0; i < input.Length; i++) {
                string[] tokens = input[i].Split('-');
                transactions.Add(int.Parse(tokens[0]), decimal.Parse(tokens[1]));
            }

            string command = Console.ReadLine();
            while (command != "End") {
                string[] tokens = command.Split(' ');

                string action = tokens[0];
                int accNumber = int.Parse(tokens[1]);
                decimal balance = decimal.Parse(tokens[2]);
                try {
                    switch (action) {
                        case "Deposit":
                            if (!transactions.ContainsKey(accNumber)) {
                                throw new KeyNotFoundException("Invalid account!");
                            }
                            transactions[accNumber] += balance;
                            Console.WriteLine($"Account {accNumber} has new balance: {transactions[accNumber]:f2}");
                            break;
                        case "Withdraw":
                            if (transactions[accNumber] < balance) {
                                throw new InvalidOperationException("Insufficient balance!");
                            }
                            transactions[accNumber] -= balance;
                            Console.WriteLine($"Account {accNumber} has new balance: {transactions[accNumber]:f2}");
                            break;
                        default:
                            throw new ArgumentException("Invalid command!");
                    }

                } catch (KeyNotFoundException ex1) {
                    Console.WriteLine(ex1.Message);
                } catch (InvalidOperationException ex2) {
                    Console.WriteLine(ex2.Message);
                } catch (ArgumentException ex3) {
                    Console.WriteLine(ex3.Message);
                } finally {
                    Console.WriteLine("Enter another command");
                }

                command = Console.ReadLine();
            }
        }
    }
}
