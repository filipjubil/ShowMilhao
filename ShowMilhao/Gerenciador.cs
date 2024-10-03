using ShowMilhao;

namespace ShowMilhao;

List <Questao> listaQuestoes = new ListViewCachingStrategy<Questao>();
List <int> listaQuestoesRespondidas = new Lista<int>();
Questao questaoCorrente;
public Gerenciador(Label labelPergunta,btnResp01...,Button btnResp05)

{

    CriarQuestoes(labelPergunta,btnResp05,btnResp04,btnRwes05);

} 

void CriarQuestoes(Label labelPergunta,Button btnResp01,Button btnResp02,..,Button btnResp05)
{

List<Questao> ListaQuestoes = new List<Questao>();

// Pergunta 1
var q1 = new Questao();
q1.pergunta = "Quanto é 2 + 2?";
q1.resposta01 = "1";
q1.resposta02 = "13";
q1.resposta03 = "21";
q1.resposta04 = "11";
q1.resposta05 = "4";
q1.respostaCorreta = 5;
q1.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q1);

// Pergunta 2
var q2 = new Questao();
q2.pergunta = "Qual é a capital da França?";
q2.resposta01 = "Londres";
q2.resposta02 = "Paris";
q2.resposta03 = "Berlim";
q2.resposta04 = "Roma";
q2.resposta05 = "Madrid";
q2.respostaCorreta = 2;
q2.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q2);

// Pergunta 3
var q3 = new Questao();
q3.pergunta = "Qual é o maior planeta do Sistema Solar?";
q3.resposta01 = "Terra";
q3.resposta02 = "Marte";
q3.resposta03 = "Júpiter";
q3.resposta04 = "Saturno";
q3.resposta05 = "Vênus";
q3.respostaCorreta = 3;
q3.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q3);

// Pergunta 4
var q4 = new Questao();
q4.pergunta = "Quem escreveu 'Dom Quixote'?";
q4.resposta01 = "William Shakespeare";
q4.resposta02 = "Miguel de Cervantes";
q4.resposta03 = "Gabriel García Márquez";
q4.resposta04 = "Jorge Luis Borges";
q4.resposta05 = "Fernando Pessoa";
q4.respostaCorreta = 2;
q4.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q4);

// Pergunta 5
var q5 = new Questao();
q5.pergunta = "Quantos estados possui o Brasil?";
q5.resposta01 = "25";
q5.resposta02 = "26";
q5.resposta03 = "27";
q5.resposta04 = "28";
q5.resposta05 = "24";
q5.respostaCorreta = 3;
q5.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q5);

// Pergunta 6
var q6 = new Questao();
q6.pergunta = "Qual o elemento químico com símbolo 'O'?";
q6.resposta01 = "Ouro";
q6.resposta02 = "Oxigênio";
q6.resposta03 = "Ozônio";
q6.resposta04 = "Osmium";
q6.resposta05 = "Óxido";
q6.respostaCorreta = 2;
q6.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q6);

// Pergunta 7
var q7 = new Questao();
q7.pergunta = "Qual é a moeda do Japão?";
q7.resposta01 = "Iene";
q7.resposta02 = "Dólar";
q7.resposta03 = "Euro";
q7.resposta04 = "Peso";
q7.resposta05 = "Real";
q7.respostaCorreta = 1;
q7.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q7);

// Pergunta 8
var q8 = new Questao();
q8.pergunta = "Quem pintou 'A Última Ceia'?";
q8.resposta01 = "Vincent Van Gogh";
q8.resposta02 = "Pablo Picasso";
q8.resposta03 = "Leonardo da Vinci";
q8.resposta04 = "Claude Monet";
q8.resposta05 = "Salvador Dalí";
q8.respostaCorreta = 3;
q8.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q8);

// Pergunta 9
var q9 = new Questao();
q9.pergunta = "Qual o valor de π (pi) arredondado a duas casas decimais?";
q9.resposta01 = "3.14";
q9.resposta02 = "2.71";
q9.resposta03 = "1.62";
q9.resposta04 = "3.00";
q9.resposta05 = "3.15";
q9.respostaCorreta = 1;
q9.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q9);

// Pergunta 10
var q5 = new Questao();
q5.pergunta = "Quantos estados possui o Brasil?";
q5.resposta01 = "25";
q5.resposta02 = "26";
q5.resposta03 = "27";
q5.resposta04 = "28";
q5.resposta05 = "24";
q5.respostaCorreta = 3;
q5.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q5);

// Pergunta 11
var q11 = new Questao();
q11.pergunta = "Qual é a equação da relatividade geral de Einstein?";
q11.resposta01 = "E = mc²";
q11.resposta02 = "F = ma";
q11.resposta03 = "Rμν - ½Rgμν + Λgμν = (8πG/c⁴)Tμν";
q11.resposta04 = "pV = nRT";
q11.resposta05 = "ΔE = hν";
q11.respostaCorreta = 3;
q11.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q11);

// Pergunta 12
var q12 = new Questao();
q12.pergunta = "Quem é o autor da teoria dos buracos negros evaporando, conhecida como radiação de Hawking?";
q12.resposta01 = "Albert Einstein";
q12.resposta02 = "Stephen Hawking";
q12.resposta03 = "Niels Bohr";
q12.resposta04 = "Roger Penrose";
q12.resposta05 = "Richard Feynman";
q12.respostaCorreta = 2;
q12.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q12);

// Pergunta 13
var q13 = new Questao();
q13.pergunta = "Qual é o composto químico conhecido como ácido prússico?";
q13.resposta01 = "HCl";
q13.resposta02 = "H2SO4";
q13.resposta03 = "HCN";
q13.resposta04 = "HNO3";
q13.resposta05 = "HF";
q13.respostaCorreta = 3;
q13.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q13);

// Pergunta 14
var q14 = new Questao();
q14.pergunta = "Quem é considerado o pai da física quântica?";
q14.resposta01 = "Max Planck";
q14.resposta02 = "Werner Heisenberg";
q14.resposta03 = "Albert Einstein";
q14.resposta04 = "Niels Bohr";
q14.resposta05 = "Erwin Schrödinger";
q14.respostaCorreta = 1;
q14.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q14);

// Pergunta 15
var q15 = new Questao();
q15.pergunta = "Qual filósofo grego escreveu 'A República'?";
q15.resposta01 = "Aristóteles";
q15.resposta02 = "Platão";
q15.resposta03 = "Sócrates";
q15.resposta04 = "Epicuro";
q15.resposta05 = "Parmênides";
q15.respostaCorreta = 2;
q15.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q15);

// Pergunta 16
var q16 = new Questao();
q16.pergunta = "O que é o gato de Schrödinger na teoria quântica?";
q16.resposta01 = "Um experimento mental para ilustrar o conceito de superposição quântica";
q16.resposta02 = "Um modelo matemático para explicar a dualidade onda-partícula";
q16.resposta03 = "Uma fórmula para calcular a função de onda";
q16.resposta04 = "Uma teoria sobre o movimento de partículas subatômicas";
q16.resposta05 = "Uma proposta sobre a existência de buracos de minhoca";
q16.respostaCorreta = 1;
q16.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q16);

// Pergunta 17
var q17 = new Questao();
q17.pergunta = "Qual é a definição de entropia em termos de física termodinâmica?";
q17.resposta01 = "A energia total em um sistema isolado";
q17.resposta02 = "A medida da desordem ou desorganização de um sistema";
q17.resposta03 = "A capacidade de realizar trabalho";
q17.resposta04 = "A conservação da energia dentro de um sistema fechado";
q17.resposta05 = "A quantidade de calor transferido em um processo";
q17.respostaCorreta = 2;
q17.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q17);

// Pergunta 18
var q18 = new Questao();
q18.pergunta = "Quem é o autor do 'Manifesto Comunista'?";
q18.resposta01 = "Karl Marx e Friedrich Engels";
q18.resposta02 = "Vladimir Lenin";
q18.resposta03 = "Mao Zedong";
q18.resposta04 = "Jean-Jacques Rousseau";
q18.resposta05 = "Adam Smith";
q18.respostaCorreta = 1;
q18.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q18);

// Pergunta 19
var q19 = new Questao();
q19.pergunta = "Qual é a diferença entre fissão e fusão nuclear?";
q19.resposta01 = "Fissão divide átomos, enquanto fusão os une";
q19.resposta02 = "Fissão ocorre no sol, enquanto fusão ocorre em reatores nucleares";
q19.resposta03 = "Fusão é uma reação exotérmica, enquanto fissão é endotérmica";
q19.resposta04 = "Fissão envolve hidrogênio, enquanto fusão envolve urânio";
q19.resposta05 = "Não há diferença significativa entre fissão e fusão";
q19.respostaCorreta = 1;
q19.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q19);

// Pergunta 20
var q20 = new Questao();
q20.pergunta = "Qual é a forma geométrica de uma molécula de metano (CH₄)?";
q20.resposta01 = "Linear";
q20.resposta02 = "Angular";
q20.resposta03 = "Trigonal plana";
q20.resposta04 = "Tetraédrica";
q20.resposta05 = "Bipiramidal";
q20.respostaCorreta = 4;
q20.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q20);

// Pergunta 21
var q21 = new Questao();
q21.pergunta = "Qual das seguintes é uma partícula mediadora da força nuclear forte?";
q21.resposta01 = "Fóton";
q21.resposta02 = "Bóson de Higgs";
q21.resposta03 = "Glúon";
q21.resposta04 = "Gráviton";
q21.resposta05 = "Neutrino";
q21.respostaCorreta = 3;
q21.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q21);

// Pergunta 22
var q22 = new Questao();
q22.pergunta = "Quem formulou o conceito de 'Vontade de Potência'?";
q22.resposta01 = "Friedrich Nietzsche";
q22.resposta02 = "Georg Hegel";
q22.resposta03 = "Arthur Schopenhauer";
q22.resposta04 = "Jean-Paul Sartre";
q22.resposta05 = "René Descartes";
q22.respostaCorreta = 1;
q22.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q22);

// Pergunta 23
var q23 = new Questao();
q23.pergunta = "Qual é a função do ribossomo na célula?";
q23.resposta01 = "Síntese de proteínas";
q23.resposta02 = "Produção de ATP";
q23.resposta03 = "Replicação do DNA";
q23.resposta04 = "Degradação de resíduos celulares";
q23.resposta05 = "Transporte de lipídios";
q23.respostaCorreta = 1;
q23.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q23);

// Pergunta 24
var q24 = new Questao();
q24.pergunta = "Qual imperador romano dividiu o Império em Tetrarquia?";
q24.resposta01 = "Constantino I";
q24.resposta02 = "Júlio César";
q24.resposta03 = "Diocleciano";
q24.resposta04 = "Nero";
q24.resposta05 = "Augusto";
q24.respostaCorreta = 3;
q24.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q24);

// Pergunta 25
var q25 = new Questao();
q25.pergunta = "Qual é a teoria que afirma que o universo está em constante expansão acelerada?";
q25.resposta01 = "Teoria do Big Crunch";
q25.resposta02 = "Teoria da Inflacionária";
q25.resposta03 = "Teoria da Expansão Constante";
q25.resposta04 = "Teoria do Big Bang";
q25.resposta05 = "Teoria da Energia Escura";
q25.respostaCorreta = 5;
q25.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q25);

// Pergunta 26
var q26 = new Questao();
q26.pergunta = "Qual molécula é conhecida como a 'molécula da vida' por armazenar informação genética?";
q26.resposta01 = "ATP";
q26.resposta02 = "DNA";
q26.resposta03 = "RNA";
q26.resposta04 = "Proteína";
q26.resposta05 = "NADH";
q26.respostaCorreta = 2;
q26.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q26);

// Pergunta 27
var q27 = new Questao();
q27.pergunta = "Quem foi responsável pela teoria dos campos de força gravitacional que substituiu a ideia de ação à distância?";
q27.resposta01 = "Isaac Newton";
q27.resposta02 = "Albert Einstein";
q27.resposta03 = "Michael Faraday";
q27.resposta04 = "James Clerk Maxwell";
q27.resposta05 = "Galileu Galilei";
q27.respostaCorreta = 2;
q27.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q27);

// Pergunta 28
var q28 = new Questao();
q28.pergunta = "Em qual país ocorreu a Revolução Meiji, que modernizou o país no século XIX?";
q28.resposta01 = "China";
q28.resposta02 = "Japão";
q28.resposta03 = "Coreia do Sul";
q28.resposta04 = "Tailândia";
q28.resposta05 = "Vietnã";
q28.respostaCorreta = 2;
q28.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q28);

// Pergunta 29
var q29 = new Questao();
q29.pergunta = "Qual é a principal diferença entre as células procarióticas e eucarióticas?";
q29.resposta01 = "Presença de ribossomos nas células procarióticas";
q29.resposta02 = "Procarióticas não possuem núcleo definido, enquanto eucarióticas possuem";
q29.resposta03 = "Eucarióticas não possuem parede celular, enquanto procarióticas possuem";
q29.resposta04 = "Procarióticas possuem mitocôndrias, enquanto eucarióticas não";
q29.resposta05 = "Somente células eucarióticas têm DNA";
q29.respostaCorreta = 2;
q29.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q29);

// Pergunta 30
var q30 = new Questao();
q30.pergunta = "Qual é o terceiro movimento de uma sinfonia clássica geralmente chamado?";
q30.resposta01 = "Adagio";
q30.resposta02 = "Allegro";
q30.resposta03 = "Minueto e Trio";
q30.resposta04 = "Scherzo";
q30.resposta05 = "Presto";
q30.respostaCorreta = 3;
q30.ConfigurarDesenho9(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
ListaQuestoes.Add(q30);

// Continue criando perguntas desafiadoras até completar as 100, explorando temas complexos e detalhes aprofundados de diversas áreas como biologia, física teórica, filosofia e história.


// Continue criando perguntas mais complexas até completar as 100, abrangendo temas como química orgânica, física moderna, filosofia clássica, literatura antiga, e outros tópicos desafiadores.



}
var q2=new Questao();
{ 
public void ProximaQuestao()
   {
         var numRandomico=Random.Shared.Next(0,ListaQuestoes.Cout-1);
        while(listaQuestoesRespondidas.Add(numRandomico))
        numRandomico=Randon.Shared.next(0,ListaQuestoes.Count-1);
          listaQuestoesRespondidas.Add(num)
   }



}
   public int pontuacao{get;private set;}
   int nivel Atual=0;,
   void Inicializar()
{
  pontuacao=0;
  nivelAtual=0;
  ProximaQuestao();

}
    public async void VerificaCorreta(int rr)
    {
     if(questaoCorrente.EstaCorreto(rr))
    {
    await Task.Delay(1000);
    AdicionaPontuacao(NivelAtual);
    NivelAtual++;
    ProximaQuestao();
}
        else
    
         awaint DisplayAlert("Game over","voce Perdeu!","ok");
         Inicializar();
    }

{
        Void AdicionaPontuacao(int rr)
     {    
        if(==1)
        Pontuacao=1000;
        else if (n==2)
        Pontuacao=2000;
        else if (n==3)
        Pontuacao=5000;
        else if (n==4)
        Pontuacao==10 000;
        else if (n==5)
        Pontuacao=20 000;
        else if (n==6)
        Pontuacao=50 000;
        else if (n==7)
        Pontuacao=100 000;
        else if (n==8)
        Pontuacao=200 000;
        else if (n==9)
        Pontuacao=500 000;
        else
        Pontuacao=1000 000;
     }
    
    




}

