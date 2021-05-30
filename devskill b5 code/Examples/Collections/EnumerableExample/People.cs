using System.Collections;
using System.Linq;

namespace Examples.Collections.EnumerableExample
{
    public class People : IEnumerable
    {
        private Person[] _people;
        public People(Person[] pArray)
        {
            _people = new Person[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }

        public Person this[int index]
        {
            get
            {
                return _people[index];
            }
            set
            {
                _people[index] = value;
            }
        }

        public Person this[string index]
        {
            get
            {
                return _people.Where(x => x.firstName == index).First();
            }
            set
            {
                var person = this[index];
                person.lastName = value.lastName;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_people);
        }
    }
}
