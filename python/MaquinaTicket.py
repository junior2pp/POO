class MaquinaTicket:
    """docstring for MaquinaTicket."""
    def __init__(self,precio=0,balance=0,total=0,contadorTicket=0):
        if precio>0:
            self.__precio = precio
            self.__balance = balance
            self.__contadorTicket = contadorTicket
            self.__total = total
        else:
            print "Inserte un precio mayor a 0"

    """METODOS DE LA CLASE"""
    def getPrecio(self):
        return self.__precio

    def getBalance(self):
        return self.__balance

    def InsertarMoneda(self,moneda=0):
        if moneda>0:
            self.__balance += moneda
        else:
            print "Inserte Moneda mayor a 0"


    def VaciarMaquina(self):
        TotalTemp = self.__total
        self.__total = 0
        return TotalTemp

    def ImprimirTicket(self):
        if self.__balance >= self.__precio:
            self.__contadorTicket += 1
            print "----------------"
            print "TICKET # %d" % self.__contadorTicket
            print "PRECIO = %d" % self.__precio
            print "----------------"
            self.__total += self.__precio
            self.__balance -= self.__precio
        else:
            print "Necesita %d centavos mas" % (self.__precio - self.__balance)









objeto = MaquinaTicket(10)
objeto.InsertarMoneda(50)

print objeto.getPrecio()
