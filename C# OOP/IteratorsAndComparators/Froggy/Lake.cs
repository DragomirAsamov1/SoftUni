using System.Collections;
using System.Collections.Generic;

namespace Froggy {
    public class Lake : IEnumerable<int> {
        private List<int> stones;

        public Lake(List<int> stones) {
            this.stones = stones;
        }
        public IEnumerator GetEnumerator() {
            return GetEnumerator();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator() {
            for (int i = 0; i < stones.Count; i += 2) {
                yield return stones[i];
            }

            int index = (stones.Count - 1) % 2 != 0 ? stones.Count - 1 : stones.Count - 2;

            for (int i = index; i >= 0; i -= 2) {
                yield return stones[i];
            }
        }
    }
}
