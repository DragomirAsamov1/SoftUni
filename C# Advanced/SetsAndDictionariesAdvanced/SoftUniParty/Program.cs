using System;
using System.Collections.Generic;

namespace SoftUniParty {
    internal class Program {
        static void Main(string[] args) {
            string reservation = string.Empty;

            HashSet<string> reservationList = new HashSet<string>();

            while (true) {

                reservation = Console.ReadLine();

                if (reservation == "PARTY" || reservation == "END") {
                    break;
                }

                reservationList.Add(reservation);
            }

            while (true) {
                reservation = Console.ReadLine();

                if (reservation == "END") {
                    break;
                }

                reservationList.Remove(reservation);
            }


            Console.WriteLine(reservationList.Count);

            foreach (string invitation in reservationList) {
                if (char.IsDigit(invitation[0])) {
                    Console.WriteLine(invitation);
                }
            }

            foreach (string invitation in reservationList) {
                if (char.IsLetter(invitation[0])) {
                    Console.WriteLine(invitation);
                }
            }
        }
    }
}
