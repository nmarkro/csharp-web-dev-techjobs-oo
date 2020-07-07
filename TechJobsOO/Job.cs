using System;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string emptyMessage = "Data not available";

            string retMessage = "\n";
            retMessage += "Id: " + Id + "\n";
            retMessage += "Name: " + (Name != "" ? Name.ToString() : emptyMessage) + "\n";
            retMessage += "Employer: " + (EmployerName.ToString() != "" ? EmployerName.ToString() : emptyMessage) + "\n";
            retMessage += "Location: " + (EmployerLocation.ToString() != "" ? EmployerLocation.ToString() : emptyMessage) + "\n";
            retMessage += "Position Type: " + (JobType.ToString() != "" ? JobType.ToString() : emptyMessage) + "\n";
            retMessage += "Core Competency: " + (JobCoreCompetency.ToString() != "" ? JobCoreCompetency.ToString() : emptyMessage) + "\n";

            return retMessage;
        }
    }
}
