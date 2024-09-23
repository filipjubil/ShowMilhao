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
Var q1=new Questao();
q1.pergunta=quanto e 2+2;
q1.resposta01="1";
q1.resposta02="13";
q1.resposta03="21";
q1.resposta04="11";
q1.resposta05="4";
q1.respostaCorreta=5;
q1.ConfigurarDesenho9(Label labelPergunta,Button btnResp01,Button btnResp02,..,Button btnResp05);
ListaQuestoes.Add(q1);
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

