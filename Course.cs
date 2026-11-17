using System;

namespace OOPHomework
{
    public class Course
    {
        private int credits;

        public string Code { get; init; }
        public string Name { get; set; }

        public int Credits
        {
            get { return credits; }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(Credits),
                        "Credits must be between 1 and 10."
                    );
                }

                credits = value;
            }
        }

        public Course(string code, string name, int credits)
        {
            Code = code;
            Name = name;
            Credits = credits;
        }

        public string Info()
        {
            return $"{Code} {Name} ({Credits} cr)";
        }
    }
}