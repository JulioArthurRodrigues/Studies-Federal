programa
{	//Prontuário
	inclua biblioteca Matematica --> mat
	funcao inicio()
	{
		real diametro, raio, volume, pi

		pi = 3.14159

		escreva("Digite o valor do diâmetro da esfera: ")
		leia(diametro)

		raio = diametro / 2

		mat.potencia(raio, 3.0)
		volume = (4.0 / 3.0) * pi * mat.potencia(raio, 3.0)

		volume = mat.arredondar(volume, 2)

		escreva("O raio da esfera é: ", raio, "\n")
		escreva("O volume da esfera")



	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 420; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */