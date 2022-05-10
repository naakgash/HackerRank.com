import java.util.*;
import java.io.*;

class Solution {
    public static void main(String []args)
    {
        Scanner input = new Scanner(System.in);
        int t=input.nextInt();

        for(int i=0;i<t;i++)
        {

            try
            {
                long data = input.nextLong();
                System.out.println(data + " can be fitted in:");
                if(data >= (-(Math.pow(2,7))) && data <= (Math.pow(2,7)-1)) System.out.println("* byte");
                if(data >= (-(Math.pow(2,15))) && data <= ( Math.pow(2,15)-1)) System.out.println("* short");
                if(data >= (-(Math.pow(2,31))) && data<= (Math.pow(2,31)-1)) System.out.println("* int");
                if(data >= (-(Math.pow(2,63))) && data <= (Math.pow(2,63)-1)) System.out.println("* long");
            }
            catch(Exception e)
            {
                System.out.println(input.next()+" can't be fitted anywhere.");
            }

        }
    }
}
