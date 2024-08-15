
using Smartphone.Models;

// Instanciando um novo objeto herdado de 'Smartphone'
Nokia nokia = new Nokia("G11", "NK095", "350123451234560", 128);
Iphone iphone = new Iphone("Apple", "14", "350123451234561", 128);

// Realizando uma ligação
nokia.Ligar();
iphone.Ligar();

// Recebendo uma ligação
nokia.ReceberLigacao();
iphone.ReceberLigacao();

// Instalando um aplicativo
nokia.InstalarAplicativo("Soundcloud");
iphone.InstalarAplicativo("Waze");

