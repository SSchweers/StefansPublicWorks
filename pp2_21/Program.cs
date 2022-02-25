//Practice problem for 2-21-2022
//Create largest pandigital 9-digit number
public class Pandigital{
    public static void Main(String[] args){
        Console.WriteLine(generatePandigital());
    }

    static string generatePandigital(){

        string answer = "0";
        int maxPro = 0;
        int maxInt = 0;

        //setting max to 9876 so that there must atleast be two products
        for(int i = 1; i <= 9876; i++){

            string temp = "";
            string hold = "";
            int num = 0;
            int j = 1;
            bool check = true;
            int a = i;
            int b = j;
           
            while (check){
                num = i * j;
                hold = temp + num.ToString();                

                if(hold.Length < 10 && CheckRepeats(hold) == true){
                    temp += num.ToString();
                    j += 1;
                }
                else{
                    check = false;
                }
            }

            int x = Int32.Parse(temp);
            int y = Int32.Parse(answer);

            if(x > y){
                answer = temp;
                maxPro = i;
                maxInt = j - 1;
            }
        }

        answer = "Pandigital: " + answer + " | MaxProduct: " + maxPro + " | MaxInt " + maxInt;
        return answer;
    }

    static bool CheckRepeats(string input){
        bool check = true;
        int n = 0;

        var digits = input.Select(t => int.Parse(t.ToString())).ToArray();
                
        foreach(var digit in digits){
            for(int l = 0; l < digits.Length; l++){
                if(digit == digits[l] && l != n){
                    check = false;
                    break;
                }
                n++;
            }
            if(check == false){
                break;
            }
            //reset counter
            n = 0;
        }

        return check;
    }

}
