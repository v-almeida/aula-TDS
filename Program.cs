// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Instanciar um objeto professor
//professor Professor = new professor("999");
//Professor.setNome("Emilia");
//Professor.nome = "Escobar, o belo";
//onsole.WriteLine(Professor.getNome());

//Professor = new professor("1010", "Escobar, o belo");
//Console.WriteLine(Professor.getNome());

///////////////////////////
//INJEÇÃO DE DEPENDÊNCIA
//motor Motor = new motor();
//Motor.cilindrada = "2.0";
//Motor.potencia = "150 cv";

//carro Chevette = new carro(Motor);

//Motor = new motor();// constroi um novo objeto
//Motor.cilindrada = "1.0";


//Chevette.ano = "1970";
//Chevette.marca = "GM";

//Console.WriteLine(Chevette.marca);
//Console.WriteLine(Chevette.Motor.cilindrada);
//Console.WriteLine(Chevette.Motor.potencia);
//Console.WriteLine(Chevette.Motor.ligar());
//Console.WriteLine(Chevette.Motor.desligar());

//ave Tucano = new ave();
//Tucano.porte = "Médio";
//Tucano.alimentacao = "Onivoro";
//Tucano.tipo_plumagem = "Colorida";
//Console.WriteLine(Tucano.porte);

//mamifero Elefante = new mamifero();
//Elefante.porte = "Grande";
//Console.WriteLine(Elefante.somEmitido());
//Console.WriteLine(Tucano.somEmitido());

pedagio Pedagio = new pedagio();
Pedagio.NomePraca = "Sao Luiz do purunun";
Pedagio.PrecoPorEixo = 5.0;

veiculoPasseio Passeio = new veiculoPasseio();
Passeio.Eixos = 2;
Passeio.Tecnologia = "Hibrido";

Pedagio.CobrarPedagio(Passeio);

// caminhao

caminhao Scania = new caminhao();
Scania.Eixos = 10;
Scania.CargaRisco = true;
Scania.TipoCarga = "Querosene";
Pedagio.CobrarPedagio(Scania);