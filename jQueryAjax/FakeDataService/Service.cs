using System.Collections.Generic;
using jQueryAjax.FakeRepo;
using System.Linq;
using MoreLinq;

namespace jQueryAjax.FakeDataService
{
    public static class Service
    {
        internal static List<Person> GetPeople()
        {
            return new List<Person>
                {
                    new Person
                        {
                            ID = 1,
                            EyeColor = "Blue",
                            FullName = "Joe Smith",
                            HairColor = "Blonde",
                            Height = "6'3'",
                            Hometown = "Broomall, PA"
                        },
                    new Person
                        {
                            ID = 2,
                            EyeColor = "Brown",
                            FullName = "Jane Smith",
                            HairColor = "Brown",
                            Height = "6'2",
                            Hometown = "Ardmore, PA"
                        },
                    new Person
                        {
                            ID = 3,
                            EyeColor = "Green",
                            FullName = "John Smith",
                            HairColor = "Red",
                            Height = "5'11",
                            Hometown = "West Chester, PA"
                        },
                    new Person
                        {
                            ID = 4,
                            EyeColor = "Yellow",
                            FullName = "Jackie Smith",
                            HairColor = "Black",
                            Height = "6'2",
                            Hometown = "Levittown, PA"
                        },
                    new Person
                        {
                            ID = 5,
                            EyeColor = "Aquamarine",
                            FullName = "Janelle Smith",
                            HairColor = "Blonde",
                            Height = "5'8",
                            Hometown = "Pittsfield, PA"
                        },
                    new Person
                        {
                            ID = 6,
                            EyeColor = "Hazel",
                            FullName = "Frongadu Hosadahha",
                            HairColor = "None",
                            Height = "4'3",
                            Hometown = "Dallas, PA"
                        },

                };
        }

        internal static List<Person> RemovePerson(int id)
        {
            var list = Service.GetPeople();
            return list.Where(p => p.ID !=id).ToList();
        }

        internal static List<Person> AddPerson(Person newGuy)
        {
            var list = Service.GetPeople();
            list.Add(newGuy);
            return list;
        }

        internal static int GetNextID()
        {
            var list = GetPeople();
            return list.Max(a => a.ID)+1;
        }


    }
}