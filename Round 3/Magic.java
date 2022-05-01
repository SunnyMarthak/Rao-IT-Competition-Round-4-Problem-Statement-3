import java.util.Scanner;

public class Magic {
    public static void main(String[] args) {
        int[][] iCards = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                System.out.print(iCards[i][j] + ",");
            }
            System.out.println();
        }
        Scanner scanner = new Scanner(System.in);
        int row1 = scanner.nextInt() - 1;
        for(int i = 0;i<4;i++){
            int tempSwap = iCards[row1][i];
            iCards[row1][i] = iCards[i][0];
            iCards[i][0] = tempSwap;
        }
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                System.out.print(iCards[i][j] + ",");
            }
            System.out.println();
        }
        int row2 = scanner.nextInt() - 1;
        System.out.println(iCards[row2][0]);
    }
}
