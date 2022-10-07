using System;

public class Sach
{
	public long maSach;
	public string tenSach;
	public double donGia;
	public int soLuong;
	public string NXB;
	public Sach()
	{

	}
	public Sach(long maSach, string tenSach, double donGia, int soLuong, string nxb)
	{
		this.maSach = maSach;	
		this.tenSach = tenSach;
		this.donGia = donGia;
		this.soLuong = soLuong;
		this.NXB = nxb;
	}
	public virtual void ToString()
	{

	}
	public virtual double thanhTien()
	{
		return this.donGia*Convert.ToDouble(this.soLuong);
	}
}
