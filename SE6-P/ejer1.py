num = int(input("Ingrese un número: "))

while num<=0:
    num = int(input("Número inválido. Ingrese un número: "))

i=1
print()
while i<=12:
    print(f"{num} x {i} = {num*i}")
    i+=1