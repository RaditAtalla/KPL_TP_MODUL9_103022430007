using System.Text.Json;
using TP_MODUL9_103022430007;

var json = File.ReadAllText("covid_config.json");
var options = new JsonSerializerOptions
{
    IncludeFields = true,
};

var config = JsonSerializer.Deserialize<CovidConfig>(json, options);

Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai " + config.satuan_suhu);
var suhu = double.Parse(Console.ReadLine());

Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
var hari = int.Parse(Console.ReadLine());

if (config.satuan_suhu == "celcius")
{
    Console.WriteLine((suhu >= 36.5 && suhu <= 37.5) && hari < config.batas_hari_deman
                        ? config.pesan_diterima : config.pesan_ditolak);
}
else if (config.satuan_suhu == "fahrenheit")
{
    Console.WriteLine((suhu >= 97.7 && suhu <= 99.5) && hari < config.batas_hari_deman
                        ? config.pesan_diterima : config.pesan_ditolak);
}