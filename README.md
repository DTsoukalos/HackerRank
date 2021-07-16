# HackerRank
Migratory Birds - Dictionary solution 

//url-> https://www.hackerrank.com/challenges/migratory-birds/problem
//difficulty ->easy

    public static int migratoryBirds(List<int> arr)
    {
        Dictionary<int, int> theDictionary=new Dictionary<int, int>();
        for(int i=0;i< arr.Count;i++){
            if (theDictionary.ContainsKey(arr[i])) {
                theDictionary[arr[i]]++;
            }
            else{
                theDictionary.Add(arr[i], 1);
            }
        }
        int theReturnNumber=0;
        int theApiaringTimes=0;
        foreach(var item in theDictionary){
            if(item.Value>theApiaringTimes){
            theReturnNumber=item.Key;
            theApiaringTimes=item.Value;
            }
            else if(item.Value==theApiaringTimes && theReturnNumber>item.Key){
                theReturnNumber=item.Key;
                theApiaringTimes=item.Value;
            }
        }
        return theReturnNumber;
    }
