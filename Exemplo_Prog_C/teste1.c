#pragma region libraries
#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#pragma endregion libraries

#pragma region console_colors
#define RED     "\x1b[31m"
#define GREEN   "\x1b[32m"
#define BLUE    "\x1b[34m"
#define RESET   "\x1b[0m"
#pragma endregion console_colors

#pragma region declare_sub_rotines
void menu();
void submenu_signalsimulator();
void resistorParallel(int n, float resistencias[]);
void resistorSerie(int n, float resistencias[]);
void calcularCapacitancia(float carga, float diferenca_potencial);
void calcularIndutancia(float fluxo_magnetico, float corrente);
void gerarSinalSinusoidal(float amplitude, float frequencia);
void gerarSinalQuadrada(float amplitude, float frequencia);
void gerarSinalTriangular(float amplitude, float frequencia);
#pragma endregion declare_sub_rotines

void main()
{
    float resistencias_serie[] = {10.0, 20.0, 30.0};
    float resistencias_paralelo[] = {10.0, 20.0, 30.0};
    float carga = 0.0001;  // 0.0001 C
    float diferenca_potencial = 10.0;  // 10 V
    float fluxo_magnetico = 0.001;  // 0.001 Wb
    float corrente = 1.0;  // 1 A
    float amplitude = 5.0;
    float frequencia = 1.0;
    char optionMenu, optionSubMenu_SignalSimulator;
    while(optionMenu!='X')
    {
        menu();
        scanf("%c", &optionMenu);
        switch (optionMenu)
        {
            case '1':               
                resistorSerie(3,resistencias_serie);
                break;
            case '2':

                resistorParallel(3,resistencias_paralelo);
                break;
            case '3':
               
                calcularCapacitancia(carga, diferenca_potencial);
                break;
            case '4':
                calcularIndutancia(fluxo_magnetico, corrente);
                break;
            case '5':
                break;
            case '6':
                //system("clear");
                System(“cls”);
                submenu_signalsimulator();
                scanf("%c", &optionSubMenu_SignalSimulator);
                switch (optionSubMenu_SignalSimulator)
                {
                    case '1':
                        gerarSinalSinusoidal(amplitude, frequencia);
                        break;
                    case '2':
                        gerarSinalQuadrada(amplitude, frequencia);
                        break;
                    case '3':
                        gerarSinalTriangular(amplitude, frequencia);
                        break; 
                    case 'X':
                         // clean console
                         menu();
                        break;         
                    default:
                        printf("Opcao invalida");
                        menu();
                        break;
                }
                break;
            default:
                printf("Opcao invalida");
                break;
            }
    }
}

#pragma region menus
void menu()
{
    printf(RED "------------------------------\n");
    printf(RED "---------- MultiSim ----------\n");
    printf(RED "------------------------------\n");
    printf(RESET "\n");
    printf("(Escolha uma opcao)\n");
    printf(GREEN "-> Calcular:\n");
    printf(BLUE "    1- Resistencia equivalente serie\n");
    printf(BLUE "    2- Resistencia equivalente paralelo\n");
    printf(BLUE "    3- Condensadores\n");
    printf(BLUE "    4- Bobines\n");
    printf(GREEN "-> Simular:\n");
    printf(BLUE "    5- Circuito eletrico\n");
    printf(BLUE "    6- Sinal eletrico\n");
    printf(GREEN "X- Sair\n");
    printf(RESET "\n");
}

void submenu_signalsimulator()
{
    printf(RED "-------------------------------\n");
    printf(RED "---------- Simulador ----------\n");
    printf(RED "-------------------------------\n");
    printf(RESET "\n");
    printf("(Escolha uma opcao)\n");
    printf(BLUE "    1- Onda sinusoidal\n");
    printf(BLUE "    2- Onda quadrada\n");
    printf(BLUE "    3- Onda triangular\n");
    printf(GREEN "   X- Voltar\n");
    printf(RESET "\n");
}
#pragma endregion menus

#pragma region resistores
void resistorParallel(int n, float resistencias[]) 
{
    float req_paralelo = 0;
    for (int i = 0; i < n; i++) 
    {
        req_paralelo += 1.0 / resistencias[i];
    }
    float res=  1.0 / req_paralelo;
    printf("Resistencia paralelo: %.3f", res);
}

void resistorSerie(int n, float resistencias[]) 
{
    float req_serie = 0;
    for (int i = 0; i < n; i++) 
    {
        req_serie += resistencias[i];
    }
    float res=  req_serie;
    printf("Resistencia serie: %.3f", res);
}
#pragma endregion resistores

#pragma region capacitors
void calcularCapacitancia(float carga, float diferenca_potencial) 
{
    float res= carga / diferenca_potencial;
    printf("Capacitancia: %.3f", res);
}
#pragma endregion capacitors

#pragma region bobines
void calcularIndutancia(float fluxo_magnetico, float corrente) 
{
    double res=  fluxo_magnetico / corrente;
    printf("Indutancia: %.3f", res);
}
#pragma endregion bobines

#pragma region signalGenerator
void gerarSinalSinusoidal(float amplitude, float frequencia) {
    printf("Sinais Elétricos:\n");

    // Onda Sinusoidal
    printf("Onda Sinusoidal:\n");

}
void gerarSinalQuadrada(float amplitude, float frequencia) {
    // Onda Quadrada
    printf("\nOnda Quadrada:\n");
    for (float t = 0; t <= 1.0; t += 0.1) {
        float v = (t < 0.5) ? amplitude : -amplitude;
        printf("%.2f segundos: %.2f V\n", t, v);
    }
}
void gerarSinalTriangular(float amplitude, float frequencia) {
    // Onda Triangular
    printf("\nOnda Triangular:\n");

}
#pragma endregion signalGenerator

#pragma region circuitSimulator
void circuitSimulator(struct components)
{

}
#pragma endregion circuitSimulator

#pragma region language
#define MAX_LINHAS 100
#define TAMANHO_LINHA 100
/*
char[][] openfileLanguage(char language)
{
    FILE *arquivo;
    char nomeArquivo[100];
    char linhas[MAX_LINHAS][TAMANHO_LINHA];
    int numLinhas = 0;

    if (char=='P')
    {
       //definir nome do arquivo    
        strcpy(nomeArquivo, "C:\Users\Public\Documents\PT.txt");  
    }
    else
    {
        //definir nome do arquivo
        strcpy(nomeArquivo, "C:\Users\Public\Documents\ENG.txt");
    }
    
    arquivo = fopen(nomeArquivo, "r");
    if (arquivo == NULL) 
    {
        printf("Erro ao abrir o arquivo.\n");
        return NULL; // Termina o programa com código de erro
    }

    // vai ler cada linha do arquivo e armazena no array
    while (numLinhas < MAX_LINHAS && fgets(linhas[numLinhas], TAMANHO_LINHA, arquivo) != NULL) {
        // Remove o caractere \n do final de cada linha
        linhas[numLinhas][strcspn(linhas[numLinhas], "\n")] = '\0';
        numLinhas++;
    }
    fclose(arquivo);
    return linhas;
}
*/
#pragma endregion circuitSimulator