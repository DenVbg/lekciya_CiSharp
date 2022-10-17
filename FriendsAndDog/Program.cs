Console.WriteLine("Cколько раз собака пробежит между двумя друзьями, пока они идут друг другу навстречу. ");
Console.Write("Укажите дистанцию между друзьями: ");
int distance = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите расстояние встречи: ");
int end_distance = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите скорость движения 1-го друга: ");
int firstFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите скорость движения 2-го друга: ");
int secondFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите скорость движения собаки: ");
int dogSpeed = Convert.ToInt32(Console.ReadLine());

int count = 0;
int friend = 2;
int time = 0;

while (distance > end_distance)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}

Console.WriteLine($"До встречи друзей собака пробежит между ними {count} раз.");
