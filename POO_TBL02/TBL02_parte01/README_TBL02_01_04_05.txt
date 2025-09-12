README ex 01, 04, 05

EX_01
Para puxar o código da dll "tbl02_dll_ex_01", o código estará a seguir:

using System;
using tbl02_dll_ex_01;

var vi = new VerificaIdade();

try
{
    vi.IdadeIdadeInvalidaException();
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}


EX_04
Para puxar o código da dll "tbl02_dll_ex_04", o código estará a seguir:

using System;
using tbl02_dll_ex_04;

var dpz = new DivisaoperZero();

try
{
    dpz.DivisaoPorZeroException();
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

EX_05
Para puxar o código da dll "tbl02_dll_ex_05", o código estará a seguir:

using System;
using tbl02_dll_ex_05;

var ei = new EstoqueInsuficiente();

try
{
    ei.EstoqueInsuficienteException();
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}