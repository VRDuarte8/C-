System.Console.Write("Enter file full path: ");
string path = Console.ReadLine();
Dictionary<string,int> votes = new();

try{
    using(StreamReader sr = File.OpenText(path)){
        while(!sr.EndOfStream){
            string[] line = sr.ReadLine().Split(',');
            if(votes.ContainsKey(line[0])){
                votes[line[0]] += int.Parse(line[1]);
            } else{
                votes[line[0]] = int.Parse(line[1]);
            }
        }
    }

    foreach (var vote in votes)
    {
        System.Console.WriteLine($"{vote.Key}: {vote.Value}");
    }
}
catch (IOException e){
    System.Console.WriteLine(e.Message);
}
