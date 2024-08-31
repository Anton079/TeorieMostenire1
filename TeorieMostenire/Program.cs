using System.Security.Cryptography.X509Certificates;
using TeorieMostenire;
using TeorieMostenire.Animale;
using TeorieMostenire.Legume;
using TeorieMostenire.Sticle;
using TeorieMostenire.vehicule;

internal class Program
{
    private static void Main(string[] args)
    {
        Aspirator Doz = new Aspirator("PestetipAripi ,PestedimensiuneCioc ,Pestepicioare, Pestecoada, Pestenas, Pesteblana, Pestearipi, Pestearipi, Pestearipi");

        Televizor Pet = new Televizor("VulpeatipAripi ,VulpeadimensiuneCioc ,Vulpeapicioare, Vulpeacoada, Vulpeanas, Vulpeablana, Vulpeaaripi, Pestearipi, Pestearipi");

        Frigider Sticla = new Frigider("PasaretipAripi, PasaredimensiuneCioc, Pasarepicioare, Pasarecoada, Pasarenas, Pasareblana, Pasarearipi, Pestearipi, Pestearipi");
    }
}