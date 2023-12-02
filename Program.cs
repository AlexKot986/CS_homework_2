


var bits = new Bits(11);
byte b = bits;
int i = bits;
long l = bits;

Console.WriteLine($"b = {b}, i = {i}, l = {l}");

b = 22;
bits = (Bits)b;
Console.WriteLine(bits.Value);
i = 33;
bits = (Bits)i;
Console.WriteLine(bits.Value);
l = 44;
bits = (Bits)l;
Console.WriteLine(bits.Value);