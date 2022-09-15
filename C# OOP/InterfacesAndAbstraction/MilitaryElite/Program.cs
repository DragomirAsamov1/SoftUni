using MilitaryElite.Contracts;
using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite {
    public class Program {
        static void Main(string[] args) {
            List<ISoldier> soldiers = new List<ISoldier>();
            while (true) {
                string[] command = Console.ReadLine().Split(' ');

                if (command[0] == "End") {
                    break;
                }

                string id = command[1];
                string firstName = command[2];
                string lastName = command[3];
                decimal salary = decimal.Parse(command[4]);

                switch (command[0]) {
                    case "Private":
                        Private @private = new Private(id, firstName, lastName, salary);
                        soldiers.Add(@private);
                        break;
                    case "LieutenantGeneral":
                        LieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);
                        string[] privateIds = command.Skip(5).ToArray();
                        foreach (var privateId in privateIds) {
                            ISoldier currPrivate = soldiers.FirstOrDefault(x => x.Id == privateId);
                            lieutenantGeneral.AddPrivate(currPrivate);
                        }
                        soldiers.Add(lieutenantGeneral);
                        break;
                    case "Engineer":
                        try {
                            string corps = command[5];
                            Engineer engineer = new Engineer(id, firstName, lastName, salary, corps);
                            string[] repairs = command.Skip(6).ToArray();
                            for (int i = 0; i < repairs.Length; i+=2) {
                                string repPart = repairs[i];
                                int hourForRep = int.Parse(repairs[i + 1]);
                                Repair repair = new Repair(repPart, hourForRep);
                                engineer.AddRepair(repair);
                            }
                            soldiers.Add(engineer);
                        } catch (Exception e) {
                            Console.WriteLine(e);
                        }
                        break;
                    case "Commando":
                        try {
                            string corps = command[5];
                            Commando commando = new Commando(id, firstName, lastName, salary, corps);
                            string[] missions = command.Skip(6).ToArray();
                            for (int i = 0; i < missions.Length; i += 2) {
                                string missionName = missions[i];
                                string state= missions[i + 1];
                                IMission mission;
                                try {
                                    mission = new Mission(missionName, state);
                                } catch (Exception) {

                                    continue;
                                }

                                commando.AddMission(mission);
                            }
                            soldiers.Add(commando);
                        } catch (Exception e) {
                            Console.WriteLine(e);
                        }
                        break;
                    case "Spy":
                        int codeNumber = (int)salary;
                        Spy spy = new Spy(id, firstName, lastName, codeNumber);
                        soldiers.Add(spy);
                        break;
                    default:
                        break;
                }
            }
            foreach (var soldier in soldiers) {
                Console.WriteLine(soldier);
            }
        }
    }
}
