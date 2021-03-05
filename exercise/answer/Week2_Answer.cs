        static int Medium(){
            Boolean isEnd = false;
            Console.Write("temperature of Celsius:");
            try{
                double degreesCelsius = Double.Parse(Console.ReadLine());
                double degreesFahrenheit = 9/5 * degreesCelsius + 32;
                if(degreesFahrenheit < -459.67){
                    throw new ArgumentException();
                }
                if(degreesFahrenheit> 82.4){
                    Console.Write("It's hot!");
                }else if(degreesFahrenheit >59.00){
                    Console.Write("It's warm!");
                }else if(degreesFahrenheit > 50.00){
                    Console.Write("It's cool!");
                }else if(degreesFahrenheit > 41.00){
                    Console.Write("It's chilly!");
                }else if(degreesFahrenheit > 32.00){
                    Console.Write("It's cold!");
                }else{
                    Console.Write("It's freezing!");
                }
                isEnd = true;
            }catch(Exception e){}
            Console.Write(isEnd? "\nEnd" : "\nSomething wrong, please check.");
            return isEnd? 0 : -1;
        }
        static void Hard(){
            Console.WriteLine("Input formula:");
            string str = Console.ReadLine();
            decimal a = (int)Char.GetNumericValue(str[0]);
            decimal b = (int)Char.GetNumericValue(str[2]);
            if(str[1] == '+'){
                Console.WriteLine(a+b);
            }else if(str[1]=='-'){
                Console.WriteLine(a-b);
            }else if(str[1] == '*'){
                Console.WriteLine(a*b);
            }else if(str[1]=='/'){
                Console.WriteLine(a/b);
            }
             
        }
        static void Easy(){
            string seniorStudentString = "senior student";
            string juniorStudentString = "junior student";
            int myGrade = 4;
            decimal myTargetGPAofThisSemester = 4.3m;
            bool isSeniorStudent = myGrade > 2;
            if(isSeniorStudent){
                Console.WriteLine("I am {0} at NTU, and my target GPA of this semester is {1}.", seniorStudentString,  myTargetGPAofThisSemester);
            }else{
                 Console.WriteLine("I am {0} at NTU, and my target GPA of this semester is {1}.", juniorStudentString,  myTargetGPAofThisSemester);
           
            }

        }
        