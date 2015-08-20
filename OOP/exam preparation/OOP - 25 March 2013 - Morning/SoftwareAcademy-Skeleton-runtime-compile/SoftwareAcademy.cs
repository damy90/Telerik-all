using System;
using System.IO;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections.Generic;

namespace SoftwareAcademy
{
    public interface ITeacher
    {
        string Name { get; set; }
        void AddCourse(ICourse course);
        string ToString();
    }

    public interface ICourse
    {
        string Name { get; set; }
        ITeacher Teacher { get; set; }
        void AddTopic(string topic);
        string ToString();
    }

    public interface ILocalCourse : ICourse
    {
        string Lab { get; set; }
    }

    public interface IOffsiteCourse : ICourse
    {
        string Town { get; set; }
    }

    public interface ICourseFactory
    {
        ITeacher CreateTeacher(string name);
        ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab);
        IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town);
    }

    public class Course:ICourse
    {
        public ITeacher Teacher { get; set; }
        public List<string> Topics { get; private set; }
        private string name;
        public Course(string courseName, ITeacher teacher)
        {
            this.name = courseName;
            this.Teacher = teacher;
            this.Topics = new List<string>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this.name = value;
                else throw new ArgumentNullException();
            }
        }

        public void AddTopic(string topic)
        {
            Topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Name={0}; {1}", Name, Teacher != null ? string.Format("Teacher={0}; ", Teacher.Name) : "");
            if (Topics.Count > 0)
                output.AppendFormat("Topics=[{0}]; ", string.Join(", ", Topics));
            return output.ToString();
        }
    }

    public class LocalCourse:Course, ILocalCourse
    {
        private string lab;
        public LocalCourse(string courseName, ITeacher teacher, string room)
            :base(courseName, teacher)
        {
            this.Lab = room;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this.lab = value;
                else throw new ArgumentNullException();
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("LocalCourse: {0}Lab={1}", base.ToString(), Lab);
            return output.ToString();
        }
    }

    public class OffsiteCourse:Course, IOffsiteCourse
    {
        private string town;
        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this.town = value;
                else throw new ArgumentNullException();
            }
        }

        public OffsiteCourse(string courseName, ITeacher teacher, string place)
            :base(courseName, teacher)
        {
            this.Town = place;
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("OffsiteCourse: {0}Town={1}", base.ToString(), Town);
            return output.ToString();
        }
    }

    public class Teacher:ITeacher
    {
        public List<ICourse> Courses;

        public Teacher(string name)
        {
            this.Name = name;
            this.Courses = new List<ICourse>();
        }
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this.name = value;
                else throw new ArgumentNullException();
            }
        }

        public void AddCourse(ICourse course)
        {
            this.Courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Teacher: Name={0}", this.Name);
            if (Courses.Count>0)
                output.AppendFormat("; Courses=[{0}]", string.Join(", ", Courses.Select(course=>course.Name)));
            return output.ToString();
        }
    }

    public class CourseFactory : ICourseFactory
    {
        public ITeacher CreateTeacher(string name)
        {
            return new Teacher(name);
        }

        public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
        {
            return new LocalCourse(name, teacher, lab);
        }

        public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
        {
            return new OffsiteCourse(name, teacher, town);
        }
    }

    public class SoftwareAcademyCommandExecutor
    {
        static void Main()
        {
            StreamWriter sw = new StreamWriter(new FileStream("../../output.txt", FileMode.Create));
            Console.SetOut(sw);

            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);

            sw.Close();
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using SoftwareAcademy;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                        + csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }
}
