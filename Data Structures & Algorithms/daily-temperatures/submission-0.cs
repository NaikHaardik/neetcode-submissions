public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] res = new int[temperatures.Length];
        Stack<int[]> stack = new Stack<int[]>();

        for(int i = 0; i<temperatures.Length;i++){
            int temp= temperatures[i];
            while(stack.Count>0 && temp > stack.Peek()[0]){
                int[] pair = stack.Pop();
                res[pair[1]] = i-pair[1];
            }
            stack.Push(new int[]{temp,i});
        }
        return res;
        
    }
}
