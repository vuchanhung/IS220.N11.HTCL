using System;

public class TaiKhoan
{
    public long soTK;
    public string tenTK;
    public double soTien;
    public TaiKhoan()
    {

    }
    public TaiKhoan(long soTK, string tenTK, double soTien)
    {
        this.soTK = soTK;
        this.tenTK = tenTK;
        this.soTien = soTien;
    }
    public void inTaiKhoan()
    {
        Console.WriteLine("soTK:{1},tenTK:{2},soTien:{3}");
    }

    public Boolean NapTien(double st)
    {

        if (st <= 0)
        {
            Console.WriteLine("Nap tien khong thanh cong");
            return false;
        }
        Console.WriteLine("Nap tien thanh cong");
        this.soTien = this.soTien + st;
        return true;

    }
    public Boolean RutTien()
    {
        Console.Write("Nhap so tien muon rut: ");
        double soTienRut = Convert.ToDouble(Console.ReadLine());
        if (soTienRut < this.soTien)
        {
            Console.WriteLine("Rut tien thanh cong");
            this.soTien = this.soTien - (soTienRut + soTienRut * 0.01);
            return true;
        }
        Console.WriteLine("Rut tien khong thanh cong");
        return RutTien();
    }

}