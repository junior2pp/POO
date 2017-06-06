package main

import (
	"fmt"

	"github.com/junior2pp/MaquinaTicket"
)

func main() {

	m := new(maquina.Ticket)
	m.Init(10)
	precio := m.GetPrecio()
	fmt.Println("PRECIO DEL TICKET")
	fmt.Println(precio)
	m.SetBalance(50)
	fmt.Println("BALANCE")
	fmt.Println(m.GetBalance())
	//comprar ticket
	if m.GetBalance() >= m.GetPrecio() {
		m.IncrementarContador()
		m.SetTotal(m.GetTotal() + m.GetPrecio())
		m.SetBalance(m.GetBalance() - m.GetPrecio())
		contador, precio := m.ImprimirTicket()
		fmt.Println("TICKET #", contador)
		fmt.Println("PRECIO", precio)
	}
	fmt.Println(m.GetTotal())
	fmt.Println(m.GetBalance())
}
