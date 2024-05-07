System.Console.Write("How many rooms will be rented? ");
int n = int.Parse(Console.ReadLine());

Rent[] rooms = new Rent[9];

for (int i = 0; i < n; i++){
    System.Console.WriteLine($"Rent #{i + 1}:");
    System.Console.Write("Name: ");
    string name = Console.ReadLine();
    System.Console.Write("Email: ");
    string email = Console.ReadLine();
    System.Console.Write("Room: ");
    int room = int.Parse(Console.ReadLine());
    while(rooms[room-1] != null){
        System.Console.Write("This room is busy, choose another: ");
        room = int.Parse(Console.ReadLine());
    }
    rooms[room-1] = new Rent(name, email, room);
    System.Console.WriteLine();
}

System.Console.WriteLine("Busy rooms: ");
for (int i = 0; i < rooms.Length; i++){
    if (rooms[i] is not null){
        System.Console.WriteLine(rooms[i]);
    }
}