import java.io.FileWriter;
import java.io.FileReader;
import java.util.Scanner;
import java.io.File;
import java.io.FileNotFoundException;


public class Xep_cot_tru {
    public int xeptru(int[] arr, int h) {
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] >= h) {
                return 1;
            }
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] < key) {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }
        int sh = 0, k = 0;
        for (int i = 0; i < arr.length; i++) {
            if (sh < h) {
                sh += arr[i];
                k++;
            } 
            if (sh >= h) {
                System.out.println(sh);
                return k;
            }
        }
        System.out.println(h);
        return -1;
    }

    
    public static void main(String[] args) throws FileNotFoundException, Exception  {
        Xep_cot_tru xepcottru = new Xep_cot_tru();
        FileWriter fileWriter = new FileWriter("VOL.OUT.txt");
        Scanner scanner = new Scanner(new File("VOL.INP.txt"));
        int k = Integer.parseInt(scanner.nextLine()); // k la so luong test
        while (k > 0) {
            String line1 = scanner.nextLine();
            int n = Integer.parseInt(line1.split(" ")[0]);
            int h = Integer.parseInt(line1.split(" ")[1]);
            
            int[] arr = new int[n];
            for (int i = 0; i < n; i++) {
                String line2 = scanner.nextLine();
                arr[i] = Integer.parseInt(line2.split(" ")[0]);
            }
            
            int result = xepcottru.xeptru(arr, h);
            
            fileWriter.write(result + "\n");
            k--;
        }
        fileWriter.close();
        scanner.close();
    }
}
