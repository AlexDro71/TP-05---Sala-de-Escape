class Escape{

public static string[] incognitasSalas{get; private set;}

public static int estadoJuego{get; set;}


private static void inicializarJuego(){

incognitasSalas = new string[] {"5557", "CENTRAL", "candado3", "AVION"};
  estadoJuego = 1;
}


public static int getEstadoJuego(){
  
    return estadoJuego;
}


public static bool ResolverSala(int Sala, string Incognita){
if(incognitasSalas.Length < 1){
    inicializarJuego();
}

if(estadoJuego != Sala){
return false;
}
if(Incognita == incognitasSalas[Sala-1]){
estadoJuego++;
return true;
}else{
    return false;
}

}






}