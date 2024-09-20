using SeguroAutomoveis;

Cliente cliente = new Cliente("Luciano");

// Criando dois seguros de cada tipo
SeguroCarro carro1 = new SeguroCarro("Ford", "2020", 50000, 2000, 5);
SeguroCarro carro2 = new SeguroCarro("Chevrolet", "2021", 60000, 2500, 4);
SeguroMoto moto1 = new SeguroMoto("Honda", "2019", 15000, 500, 3);
SeguroMoto moto2 = new SeguroMoto("Yamaha", "2018", 20000, 700, 2);
SeguroCaminhao caminhao1 = new SeguroCaminhao("Volvo", "2017", 150000, 10000, 10);
SeguroCaminhao caminhao2 = new SeguroCaminhao("Scania", "2016", 200000, 12000, 8);

// Verificando carga dos caminhões
caminhao1.VerificaCarga(6); // Carga maior que 5 toneladas
caminhao2.VerificaCarga(4); // Carga menor que 5 toneladas

// Adquirindo seguros
cliente.AdquirirSeguro(carro1);
cliente.AdquirirSeguro(carro2);
cliente.AdquirirSeguro(moto1);
cliente.AdquirirSeguro(moto2);
cliente.AdquirirSeguro(caminhao1);
cliente.AdquirirSeguro(caminhao2);

// Listando os seguros adquiridos
cliente.ListaDeSeguros();

// Exibindo o total dos seguros
Console.WriteLine($"Total dos seguros: {cliente.TotalSeguros():C}");

Console.ReadLine();