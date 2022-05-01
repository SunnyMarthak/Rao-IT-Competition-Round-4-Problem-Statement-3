import java.util.Scanner;

public class Palindrome {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String str = sc.nextLine();
        char[] arr = str.toCharArray();
        int j = arr.length - 1, flag = 0;

        for (int i = 0; i < arr.length; i++) {

            if(arr[i] == arr[j]){
                flag = 1;
            }

            if(arr[i] != arr[j]){
                flag = 0;
                break;
            }
            j--;
        }

         if(flag == 1) {
             System.out.println("Yes");
         }
         else
            System.out.println("No");
    }
}
