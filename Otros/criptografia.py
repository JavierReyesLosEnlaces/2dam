from Crypto.PublicKey import RSA
from Crypto.Cipher import PKCS1_OAEP

# Generar un par de claves RSA
clave_privada = RSA.generate(2048)
clave_publica = clave_privada.publickey()

# Mensaje a cifrar
mensaje_original = b'Hola, mundo secreto!'

# Cifrado con la clave pública
cipher = PKCS1_OAEP.new(clave_publica)
mensaje_cifrado = cipher.encrypt(mensaje_original)

# Descifrado con la clave privada
cipher = PKCS1_OAEP.new(clave_privada)
mensaje_descifrado = cipher.decrypt(mensaje_cifrado)

# Mostrar resultados
print("Mensaje original:", mensaje_original)
print("Mensaje cifrado:", mensaje_cifrado)
print("Mensaje descifrado:", mensaje_descifrado.decode())
