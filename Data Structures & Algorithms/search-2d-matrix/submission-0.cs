public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int bigLength = 0;
        for(int i =0;i<matrix.Length;i++){
            bigLength += matrix[i].Length;
        }
        int[] bigArray = new int[bigLength];
        int left = 0, right = bigArray.Length-1;

        int index = 0;

for (int i = 0; i < matrix.Length; i++)
{
    for (int j = 0; j < matrix[i].Length; j++)
    {
        bigArray[index++] = matrix[i][j];
    }
}

        while(left<=right){
            int mid = left +(right-left)/2;
            if(bigArray[mid]==target){
                return true;
            }
            else if(bigArray[mid]<target){
                left = mid+1;
            }
            else{
                right = mid-1;
            }
        }
        return false;
    }
    
}
