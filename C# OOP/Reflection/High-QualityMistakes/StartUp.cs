using System;
using System.Linq;
using System.Reflection;

namespace CreateAttribute {
    [Author("Victor")]
    class StartUp {
        [Author("George")]
        static void Main(string[] args) {
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor();

        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AuthorAttribute: Attribute {
        public AuthorAttribute(string name) {
            this.Name = name;
        }

        public string Name { get; set; }
    }

    public class Tracker {
        public void PrintMethodsByAuthor() {
            var type = typeof(StartUp);
            var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
            foreach (var method in methods) {
                if (method.CustomAttributes.Any(x => x.AttributeType == typeof(AuthorAttribute))) {
                    var attributes = method.GetCustomAttributes(false);
                    foreach (AuthorAttribute attribute in attributes) {
                        Console.WriteLine($"{method.Name} is written by {attribute.Name}");
                    }
                }
            }
        }
    }
}
