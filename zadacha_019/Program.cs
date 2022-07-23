int inpnumber =12221;
       int number =inpnumber;
       int sum=0;
       while(number>0){
           int num2=number%10;
           sum=sum*10+num2;
           number/=10;
       }
            if (inpnumber!=sum){
            Console.WriteLine ($"{sum}->Нет");
            }
            else {
            Console.WriteLine ($"{inpnumber}->Да");
            }