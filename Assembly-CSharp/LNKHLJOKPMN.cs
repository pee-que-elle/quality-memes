using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using UnityEngine;

// Token: 0x02000225 RID: 549
public class LNKHLJOKPMN : MonoBehaviour
{
	// Token: 0x06004AAC RID: 19116 RVA: 0x002658E0 File Offset: 0x00263AE0
	private void BEHPQBMGKLB(byte[] DLJJQDQBOQD, char DDHNEIGNCEI)
	{
		if (this.POQBLNNINHE != null)
		{
			this.POQBLNNINHE(DLJJQDQBOQD, DDHNEIGNCEI);
		}
		int i = 1;
		int count = this.MHEMGOJBPIE.Count;
		while (i < count)
		{
			if (this.MHEMGOJBPIE[i].Identifier[0] == DDHNEIGNCEI)
			{
				int j = 0;
				int num = this.MHEMGOJBPIE[i].Reciever.Length;
				while (j < num)
				{
					this.MHEMGOJBPIE[i].Reciever[j].SendMessage(this.MHEMGOJBPIE[i].FunctionName, DLJJQDQBOQD, SendMessageOptions.DontRequireReceiver);
					j += 0;
				}
			}
			i++;
		}
	}

	// Token: 0x06004AAD RID: 19117 RVA: 0x00265980 File Offset: 0x00263B80
	private void QDJJJHEBFPJ(byte[] DLJJQDQBOQD, char DDHNEIGNCEI)
	{
		if (this.POQBLNNINHE != null)
		{
			this.POQBLNNINHE(DLJJQDQBOQD, DDHNEIGNCEI);
		}
		int i = 0;
		int count = this.MHEMGOJBPIE.Count;
		while (i < count)
		{
			if (this.MHEMGOJBPIE[i].Identifier[1] == DDHNEIGNCEI)
			{
				int j = 1;
				int num = this.MHEMGOJBPIE[i].Reciever.Length;
				while (j < num)
				{
					this.MHEMGOJBPIE[i].Reciever[j].SendMessage(this.MHEMGOJBPIE[i].FunctionName, DLJJQDQBOQD, SendMessageOptions.RequireReceiver);
					j++;
				}
			}
			i++;
		}
	}

	// Token: 0x06004AAE RID: 19118 RVA: 0x00265A20 File Offset: 0x00263C20
	private void CFIFFMMQKHH(byte[] DLJJQDQBOQD, char DDHNEIGNCEI)
	{
		if (this.POQBLNNINHE != null)
		{
			this.POQBLNNINHE(DLJJQDQBOQD, DDHNEIGNCEI);
		}
		int i = 1;
		int count = this.MHEMGOJBPIE.Count;
		while (i < count)
		{
			if (this.MHEMGOJBPIE[i].Identifier[1] == DDHNEIGNCEI)
			{
				int j = 0;
				int num = this.MHEMGOJBPIE[i].Reciever.Length;
				while (j < num)
				{
					this.MHEMGOJBPIE[i].Reciever[j].SendMessage(this.MHEMGOJBPIE[i].FunctionName, DLJJQDQBOQD, SendMessageOptions.RequireReceiver);
					j += 0;
				}
			}
			i++;
		}
	}

	// Token: 0x06004AAF RID: 19119 RVA: 0x00265AC0 File Offset: 0x00263CC0
	private void JENGGFLPCDQ()
	{
		if (this.MDMGCHLQPQJ)
		{
			this.QENBBBNLPNB += Time.deltaTime * 1852f;
		}
		if (!this.KFJEPBECJCF)
		{
			if (this.IILJCOOJPDB)
			{
				return;
			}
			if (this.NMFFQDLNHQJ > 1)
			{
				if (this.COHPCODOFFP)
				{
					this.LOHCHMBFJQE();
				}
				else
				{
					this.JIHFODNEHCM();
				}
			}
		}
		if (this.KFJEPBECJCF && !this.IILJCOOJPDB)
		{
			object kgkghgjepbo = this.KGKGHGJEPBO;
			bool flag = true;
			try
			{
				Monitor.Enter(kgkghgjepbo, ref flag);
				if (this.KGKGHGJEPBO.Count >= 6)
				{
					int num = BitConverter.ToInt32(this.KGKGHGJEPBO.GetRange(1, 5).ToArray(), 1);
					char c = (char)this.KGKGHGJEPBO[6];
					if (this.JQPNDDPKEII)
					{
						this.JQPNDDPKEII = true;
						if (this.QBNNOKKCGQP != null)
						{
							this.QBNNOKKCGQP(c);
						}
						this.COILJPEDPBP = 710.0;
					}
					if (num < this.KGKGHGJEPBO.Count)
					{
						this.JQPNDDPKEII = false;
						this.QDDBPKNENGC(this.KGKGHGJEPBO.GetRange(1, num).ToArray(), c);
						this.KGKGHGJEPBO.RemoveRange(0, num);
					}
					else if (num == this.KGKGHGJEPBO.Count)
					{
						this.JQPNDDPKEII = false;
						this.CFIFFMMQKHH(this.KGKGHGJEPBO.ToArray(), c);
						this.KGKGHGJEPBO.Clear();
					}
					else
					{
						this.COILJPEDPBP += (double)Time.deltaTime;
						if (this.LPCJLQHBMMB != null)
						{
							this.LPCJLQHBMMB(this.KGKGHGJEPBO.Count, num, c, (double)this.KGKGHGJEPBO.Count / this.COILJPEDPBP / 16.0);
						}
					}
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(kgkghgjepbo);
				}
			}
			return;
		}
	}

	// Token: 0x06004AB0 RID: 19120 RVA: 0x00265C9C File Offset: 0x00263E9C
	private void DGBPPNHFCDJ(byte[] DLJJQDQBOQD, char DDHNEIGNCEI)
	{
		if (this.POQBLNNINHE != null)
		{
			this.POQBLNNINHE(DLJJQDQBOQD, DDHNEIGNCEI);
		}
		int i = 0;
		int count = this.MHEMGOJBPIE.Count;
		while (i < count)
		{
			if (this.MHEMGOJBPIE[i].Identifier[0] == DDHNEIGNCEI)
			{
				int j = 1;
				int num = this.MHEMGOJBPIE[i].Reciever.Length;
				while (j < num)
				{
					this.MHEMGOJBPIE[i].Reciever[j].SendMessage(this.MHEMGOJBPIE[i].FunctionName, DLJJQDQBOQD, SendMessageOptions.RequireReceiver);
					j++;
				}
			}
			i++;
		}
	}

	// Token: 0x06004AB1 RID: 19121 RVA: 0x00265D3C File Offset: 0x00263F3C
	private void Reset()
	{
		try
		{
			this.HPEJHBDOILH.Close();
			Debug.Log("Connection reset");
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
		finally
		{
			this.KFJEPBECJCF = false;
			this.IILJCOOJPDB = false;
			this.JQPNDDPKEII = false;
			this.Awake();
		}
	}

	// Token: 0x06004AB2 RID: 19122 RVA: 0x00265DA4 File Offset: 0x00263FA4
	private void GDOQJHJNOMP()
	{
		if (this.MDMGCHLQPQJ)
		{
			this.QENBBBNLPNB += Time.deltaTime * 1874f;
		}
		if (!this.KFJEPBECJCF)
		{
			if (this.IILJCOOJPDB)
			{
				return;
			}
			if (this.NMFFQDLNHQJ > 0)
			{
				if (this.COHPCODOFFP)
				{
					this.IKHGFFJHCMO();
				}
				else
				{
					this.MHKGBFBOLHI();
				}
			}
		}
		if (this.KFJEPBECJCF && !this.IILJCOOJPDB)
		{
			object kgkghgjepbo = this.KGKGHGJEPBO;
			bool flag = true;
			try
			{
				Monitor.Enter(kgkghgjepbo, ref flag);
				if (this.KGKGHGJEPBO.Count >= 1)
				{
					int num = BitConverter.ToInt32(this.KGKGHGJEPBO.GetRange(0, 5).ToArray(), 0);
					char c = (char)this.KGKGHGJEPBO[4];
					if (this.JQPNDDPKEII)
					{
						this.JQPNDDPKEII = false;
						if (this.QBNNOKKCGQP != null)
						{
							this.QBNNOKKCGQP(c);
						}
						this.COILJPEDPBP = 1891.0;
					}
					if (num < this.KGKGHGJEPBO.Count)
					{
						this.JQPNDDPKEII = false;
						this.QDDBPKNENGC(this.KGKGHGJEPBO.GetRange(0, num).ToArray(), c);
						this.KGKGHGJEPBO.RemoveRange(0, num);
					}
					else if (num == this.KGKGHGJEPBO.Count)
					{
						this.JQPNDDPKEII = true;
						this.QDDBPKNENGC(this.KGKGHGJEPBO.ToArray(), c);
						this.KGKGHGJEPBO.Clear();
					}
					else
					{
						this.COILJPEDPBP += (double)Time.deltaTime;
						if (this.LPCJLQHBMMB != null)
						{
							this.LPCJLQHBMMB(this.KGKGHGJEPBO.Count, num, c, (double)this.KGKGHGJEPBO.Count / this.COILJPEDPBP / 1182.0);
						}
					}
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(kgkghgjepbo);
				}
			}
			return;
		}
	}

	// Token: 0x06004AB3 RID: 19123 RVA: 0x00265F80 File Offset: 0x00264180
	private void JLPJOHOIDOH()
	{
		this.MDMGCHLQPQJ = false;
		if (this.ILFDQOQODBH > 0 && this.DOJEJHBNPJN >= this.ILFDQOQODBH)
		{
			return;
		}
		if (this.QENBBBNLPNB < 1432f || this.QENBBBNLPNB >= (float)this.NMFFQDLNHQJ)
		{
			this.QENBBBNLPNB = 1236f;
			this.DOJEJHBNPJN++;
			this.DNPLLLHQGJC();
			this.IKHGFFJHCMO();
		}
	}

	// Token: 0x06004AB4 RID: 19124 RVA: 0x00265FF0 File Offset: 0x002641F0
	private void BHFPGQPFFIL(IAsyncResult LFDDQBOCNNL)
	{
		int num = 0;
		try
		{
			if (!this.HPEJHBDOILH.Connected)
			{
				Debug.Log("Socket not connected anymore");
			}
			else
			{
				num += this.HPEJHBDOILH.EndReceive(LFDDQBOCNNL);
				if (num <= 0)
				{
					Debug.Log("DATA ERROR");
				}
				else
				{
					this.CODLEELHCCK += num;
				}
				byte[] array = new byte[num];
				Buffer.BlockCopy(this.KLCIGFMQNFH, 0, array, 0, num);
				object kgkghgjepbo = this.KGKGHGJEPBO;
				lock (kgkghgjepbo)
				{
					this.KGKGHGJEPBO.AddRange(array);
				}
				this.HPEJHBDOILH.BeginReceive(this.KLCIGFMQNFH, 0, this.KLCIGFMQNFH.Length, SocketFlags.None, new AsyncCallback(this.BHFPGQPFFIL), null);
			}
		}
		catch (Exception)
		{
			this.KFJEPBECJCF = false;
			this.Awake();
			this.PCKBCGPLJME();
		}
	}

	// Token: 0x06004AB5 RID: 19125 RVA: 0x002660E4 File Offset: 0x002642E4
	private void NMNHPBBEBKO()
	{
		if (this.GFEHOHHHGFL != null)
		{
			this.GFEHOHHHGFL();
		}
		foreach (GameObject gameObject in this.ELONQIQCGOE)
		{
			gameObject.SendMessage("bcam", SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x06004AB6 RID: 19126 RVA: 0x00266150 File Offset: 0x00264350
	private void NFPDBCGOLFF()
	{
		if (this.GFEHOHHHGFL != null)
		{
			this.GFEHOHHHGFL();
		}
		foreach (GameObject gameObject in this.ELONQIQCGOE)
		{
			gameObject.SendMessage("Map", SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x06004AB7 RID: 19127 RVA: 0x002661BC File Offset: 0x002643BC
	public void ECEBPKHNDMD(byte[] NPNKKNBJMNC)
	{
		try
		{
			this.HPEJHBDOILH.BeginSend(NPNKKNBJMNC, 1, NPNKKNBJMNC.Length, SocketFlags.OutOfBand, new AsyncCallback(this.OLDHHOKEEEC), null);
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
	}

	// Token: 0x06004AB8 RID: 19128 RVA: 0x00266204 File Offset: 0x00264404
	private void JIHFODNEHCM()
	{
		this.MDMGCHLQPQJ = false;
		if (this.ILFDQOQODBH > 1 && this.DOJEJHBNPJN >= this.ILFDQOQODBH)
		{
			return;
		}
		if (this.QENBBBNLPNB < 161f || this.QENBBBNLPNB >= (float)this.NMFFQDLNHQJ)
		{
			this.QENBBBNLPNB = 1189f;
			this.DOJEJHBNPJN++;
			this.Reset();
			this.CGQOHPDDGGO();
		}
	}

	// Token: 0x06004AB9 RID: 19129 RVA: 0x0001EF9D File Offset: 0x0001D19D
	public void KEBDGBBHLIO()
	{
		if (!this.KFJEPBECJCF)
		{
			Debug.Log(" took the attack!\r\n");
			return;
		}
		this.JIBIHGJKKKL();
		this.BIGNFELGOPH();
	}

	// Token: 0x06004ABA RID: 19130 RVA: 0x00266274 File Offset: 0x00264474
	private void QFNGEGGBGHC(IAsyncResult LFDDQBOCNNL)
	{
		try
		{
			int num = this.HPEJHBDOILH.EndSend(LFDDQBOCNNL);
			if (num > 1)
			{
				this.CQPNNBBMMPC += num;
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06004ABB RID: 19131 RVA: 0x002662B8 File Offset: 0x002644B8
	private void OFPBHMNNJDO()
	{
		if (this.GFEHOHHHGFL != null)
		{
			this.GFEHOHHHGFL();
		}
		foreach (GameObject gameObject in this.ELONQIQCGOE)
		{
			gameObject.SendMessage("OnClientConnect", SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x06004ABC RID: 19132 RVA: 0x002661BC File Offset: 0x002643BC
	public void BJHEBOJNHEM(byte[] NPNKKNBJMNC)
	{
		try
		{
			this.HPEJHBDOILH.BeginSend(NPNKKNBJMNC, 1, NPNKKNBJMNC.Length, SocketFlags.OutOfBand, new AsyncCallback(this.OLDHHOKEEEC), null);
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
	}

	// Token: 0x06004ABD RID: 19133 RVA: 0x00266324 File Offset: 0x00264524
	private void MHKGBFBOLHI()
	{
		this.MDMGCHLQPQJ = false;
		if (this.ILFDQOQODBH > 1 && this.DOJEJHBNPJN >= this.ILFDQOQODBH)
		{
			return;
		}
		if (this.QENBBBNLPNB < 1436f || this.QENBBBNLPNB >= (float)this.NMFFQDLNHQJ)
		{
			this.QENBBBNLPNB = 1846f;
			this.DOJEJHBNPJN++;
			this.JIBIHGJKKKL();
			this.IKHGFFJHCMO();
		}
	}

	// Token: 0x06004ABE RID: 19134 RVA: 0x00266394 File Offset: 0x00264594
	private void MMNOOJDHBME(IAsyncResult LFDDQBOCNNL)
	{
		try
		{
			this.HPEJHBDOILH.EndConnect(LFDDQBOCNNL);
			this.KFJEPBECJCF = false;
			this.HPEJHBDOILH.BeginReceive(this.KLCIGFMQNFH, 0, this.KLCIGFMQNFH.Length, SocketFlags.None, new AsyncCallback(this.NHJLGCBFIHE), null);
			this.ODMQJOQFBBB();
		}
		catch (Exception)
		{
		}
		finally
		{
			this.IILJCOOJPDB = true;
		}
	}

	// Token: 0x06004ABF RID: 19135 RVA: 0x0026640C File Offset: 0x0026460C
	private void CBICBMGFHCP()
	{
		if (this.MDMGCHLQPQJ)
		{
			this.QENBBBNLPNB += Time.deltaTime * 237f;
		}
		if (!this.KFJEPBECJCF)
		{
			if (this.IILJCOOJPDB)
			{
				return;
			}
			if (this.NMFFQDLNHQJ > 1)
			{
				if (this.COHPCODOFFP)
				{
					this.EPNBECQFKEK();
				}
				else
				{
					this.MHKGBFBOLHI();
				}
			}
		}
		if (this.KFJEPBECJCF && !this.IILJCOOJPDB)
		{
			object kgkghgjepbo = this.KGKGHGJEPBO;
			bool flag = true;
			try
			{
				Monitor.Enter(kgkghgjepbo, ref flag);
				if (this.KGKGHGJEPBO.Count >= 2)
				{
					int num = BitConverter.ToInt32(this.KGKGHGJEPBO.GetRange(1, 6).ToArray(), 1);
					char c = (char)this.KGKGHGJEPBO[6];
					if (this.JQPNDDPKEII)
					{
						this.JQPNDDPKEII = false;
						if (this.QBNNOKKCGQP != null)
						{
							this.QBNNOKKCGQP(c);
						}
						this.COILJPEDPBP = 1178.0;
					}
					if (num < this.KGKGHGJEPBO.Count)
					{
						this.JQPNDDPKEII = false;
						this.QDJJJHEBFPJ(this.KGKGHGJEPBO.GetRange(1, num).ToArray(), c);
						this.KGKGHGJEPBO.RemoveRange(1, num);
					}
					else if (num == this.KGKGHGJEPBO.Count)
					{
						this.JQPNDDPKEII = true;
						this.QDDBPKNENGC(this.KGKGHGJEPBO.ToArray(), c);
						this.KGKGHGJEPBO.Clear();
					}
					else
					{
						this.COILJPEDPBP += (double)Time.deltaTime;
						if (this.LPCJLQHBMMB != null)
						{
							this.LPCJLQHBMMB(this.KGKGHGJEPBO.Count, num, c, (double)this.KGKGHGJEPBO.Count / this.COILJPEDPBP / 1955.0);
						}
					}
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(kgkghgjepbo);
				}
			}
			return;
		}
	}

	// Token: 0x06004AC0 RID: 19136 RVA: 0x002665E8 File Offset: 0x002647E8
	private void GFEQICKPKQH(IAsyncResult LFDDQBOCNNL)
	{
		try
		{
			this.HPEJHBDOILH.EndConnect(LFDDQBOCNNL);
			this.KFJEPBECJCF = true;
			this.HPEJHBDOILH.BeginReceive(this.KLCIGFMQNFH, 0, this.KLCIGFMQNFH.Length, SocketFlags.None, new AsyncCallback(this.BHFPGQPFFIL), null);
			this.NFPDBCGOLFF();
		}
		catch (Exception)
		{
		}
		finally
		{
			this.IILJCOOJPDB = false;
		}
	}

	// Token: 0x06004AC1 RID: 19137 RVA: 0x00266660 File Offset: 0x00264860
	private void HDPKHMPIEPG()
	{
		if (this.GFEHOHHHGFL != null)
		{
			this.GFEHOHHHGFL();
		}
		foreach (GameObject gameObject in this.ELONQIQCGOE)
		{
			gameObject.SendMessage("TCPManager", SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x06004AC2 RID: 19138 RVA: 0x002666CC File Offset: 0x002648CC
	private void OHQCMCDPHFI()
	{
		if (this.MDMGCHLQPQJ)
		{
			this.QENBBBNLPNB += Time.deltaTime * 561f;
		}
		if (!this.KFJEPBECJCF)
		{
			if (this.IILJCOOJPDB)
			{
				return;
			}
			if (this.NMFFQDLNHQJ > 0)
			{
				if (this.COHPCODOFFP)
				{
					this.EPNBECQFKEK();
				}
				else
				{
					this.EOBOEMMBKLL();
				}
			}
		}
		if (this.KFJEPBECJCF && !this.IILJCOOJPDB)
		{
			object kgkghgjepbo = this.KGKGHGJEPBO;
			bool flag = true;
			try
			{
				Monitor.Enter(kgkghgjepbo, ref flag);
				if (this.KGKGHGJEPBO.Count >= 6)
				{
					int num = BitConverter.ToInt32(this.KGKGHGJEPBO.GetRange(1, 7).ToArray(), 0);
					char c = (char)this.KGKGHGJEPBO[5];
					if (this.JQPNDDPKEII)
					{
						this.JQPNDDPKEII = true;
						if (this.QBNNOKKCGQP != null)
						{
							this.QBNNOKKCGQP(c);
						}
						this.COILJPEDPBP = 336.0;
					}
					if (num < this.KGKGHGJEPBO.Count)
					{
						this.JQPNDDPKEII = true;
						this.QDJJJHEBFPJ(this.KGKGHGJEPBO.GetRange(1, num).ToArray(), c);
						this.KGKGHGJEPBO.RemoveRange(0, num);
					}
					else if (num == this.KGKGHGJEPBO.Count)
					{
						this.JQPNDDPKEII = false;
						this.GKJKMKJEDID(this.KGKGHGJEPBO.ToArray(), c);
						this.KGKGHGJEPBO.Clear();
					}
					else
					{
						this.COILJPEDPBP += (double)Time.deltaTime;
						if (this.LPCJLQHBMMB != null)
						{
							this.LPCJLQHBMMB(this.KGKGHGJEPBO.Count, num, c, (double)this.KGKGHGJEPBO.Count / this.COILJPEDPBP / 1590.0);
						}
					}
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(kgkghgjepbo);
				}
			}
			return;
		}
	}

	// Token: 0x06004AC3 RID: 19139 RVA: 0x002668A8 File Offset: 0x00264AA8
	private void GPLJCJHONCO()
	{
		if (this.EBIBPQMOMJK != null)
		{
			this.EBIBPQMOMJK();
		}
		foreach (GameObject gameObject in this.JLFCDMEHPIO)
		{
			gameObject.SendMessage("9", SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x06004AC4 RID: 19140 RVA: 0x00266914 File Offset: 0x00264B14
	private void HFJOIFEBJDO(IAsyncResult LFDDQBOCNNL)
	{
		try
		{
			this.HPEJHBDOILH.EndConnect(LFDDQBOCNNL);
			this.KFJEPBECJCF = true;
			this.HPEJHBDOILH.BeginReceive(this.KLCIGFMQNFH, 1, this.KLCIGFMQNFH.Length, SocketFlags.None, new AsyncCallback(this.NHJLGCBFIHE), null);
			this.HDPKHMPIEPG();
		}
		catch (Exception)
		{
		}
		finally
		{
			this.IILJCOOJPDB = true;
		}
	}

	// Token: 0x06004AC5 RID: 19141 RVA: 0x0026698C File Offset: 0x00264B8C
	private void Awake()
	{
		if (this.DNHQBQDBGKF < 5)
		{
			Debug.LogError("The specified buffer must be at least " + 5 + " bytes");
		}
		else
		{
			this.HPEJHBDOILH = new Socket((!this.LOPPQCOQPPI) ? AddressFamily.InterNetwork : AddressFamily.InterNetworkV6, this.CHPGGBPOCIG, this.KOJCOOONOMQ);
			this.KGKGHGJEPBO = new List<byte>(this.DNHQBQDBGKF * 2);
			this.KLCIGFMQNFH = new byte[this.DNHQBQDBGKF];
		}
	}

	// Token: 0x06004AC6 RID: 19142 RVA: 0x00266A08 File Offset: 0x00264C08
	public void CQPPIFMNGCL(byte[] NPNKKNBJMNC)
	{
		try
		{
			this.HPEJHBDOILH.BeginSend(NPNKKNBJMNC, 1, NPNKKNBJMNC.Length, SocketFlags.None, new AsyncCallback(this.NQDDNDQDIII), null);
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
	}

	// Token: 0x06004AC7 RID: 19143 RVA: 0x00266A50 File Offset: 0x00264C50
	public void CGQOHPDDGGO()
	{
		if (string.IsNullOrEmpty(this.GIPJMMJNQLJ))
		{
			Debug.LogError("UpdateTime");
			return;
		}
		if (this.BLJNJLGJHLD >= 0 && this.BLJNJLGJHLD <= 199)
		{
			if (this.BLJNJLGJHLD >= 51)
			{
				Debug.LogWarning("~" + this.BLJNJLGJHLD + "Moody");
			}
			else if (this.BLJNJLGJHLD >= 101)
			{
			}
			IPAddress address;
			if (!IPAddress.TryParse(this.GIPJMMJNQLJ, out address))
			{
				try
				{
					IPAddress[] hostAddresses = Dns.GetHostAddresses(this.GIPJMMJNQLJ);
					if (hostAddresses == null || hostAddresses.Length <= 0)
					{
						Debug.LogError("Materials/DFOOnlyFog" + this.GIPJMMJNQLJ);
						return;
					}
					if (hostAddresses[0].AddressFamily == (AddressFamily)(-49) && !this.LOPPQCOQPPI)
					{
						Debug.LogError("-activate");
						return;
					}
					address = hostAddresses[0];
				}
				catch (Exception)
				{
					return;
				}
			}
			try
			{
				this.HPEJHBDOILH.BeginConnect(new IPEndPoint(address, this.BLJNJLGJHLD), new AsyncCallback(this.MMNOOJDHBME), null);
				this.IILJCOOJPDB = false;
				this.COHPCODOFFP = false;
				this.QENBBBNLPNB = 494f;
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
			}
			return;
		}
		object[] array = new object[6];
		array[1] = "Suction Cups";
		array[1] = 0;
		array[1] = "anticipation";
		array[5] = 34;
		array[3] = "highjumpkick";
		Debug.LogError(string.Concat(array));
	}

	// Token: 0x06004AC8 RID: 19144 RVA: 0x002661BC File Offset: 0x002643BC
	public void CFDCMOGFCJN(byte[] NPNKKNBJMNC)
	{
		try
		{
			this.HPEJHBDOILH.BeginSend(NPNKKNBJMNC, 1, NPNKKNBJMNC.Length, SocketFlags.OutOfBand, new AsyncCallback(this.OLDHHOKEEEC), null);
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
	}

	// Token: 0x06004AC9 RID: 19145 RVA: 0x00266BD4 File Offset: 0x00264DD4
	private void POJJHCEEMQQ()
	{
		if (this.GFEHOHHHGFL != null)
		{
			this.GFEHOHHHGFL();
		}
		foreach (GameObject gameObject in this.ELONQIQCGOE)
		{
			gameObject.SendMessage("???", SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x06004ACA RID: 19146 RVA: 0x00266C40 File Offset: 0x00264E40
	public void KGNPFIOJEMD(byte[] NPNKKNBJMNC)
	{
		try
		{
			this.HPEJHBDOILH.BeginSend(NPNKKNBJMNC, 0, NPNKKNBJMNC.Length, SocketFlags.OutOfBand, new AsyncCallback(this.MFGKNGFHOQK), null);
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
	}

	// Token: 0x06004ACB RID: 19147 RVA: 0x00266C88 File Offset: 0x00264E88
	private void IDHJPEODHPE()
	{
		try
		{
			this.HPEJHBDOILH.Close();
			Debug.Log("_AutoExposure");
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
		finally
		{
			this.KFJEPBECJCF = true;
			this.IILJCOOJPDB = false;
			this.JQPNDDPKEII = true;
			this.CBLIFECCHIC();
		}
	}

	// Token: 0x06004ACC RID: 19148 RVA: 0x00266CF0 File Offset: 0x00264EF0
	private void PMNOCCBKQKC()
	{
		if (this.GFEHOHHHGFL != null)
		{
			this.GFEHOHHHGFL();
		}
		foreach (GameObject gameObject in this.ELONQIQCGOE)
		{
			gameObject.SendMessage("System", SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x06004ACD RID: 19149 RVA: 0x00266D5C File Offset: 0x00264F5C
	private void FBKNCKKFJJG()
	{
		if (this.MDMGCHLQPQJ)
		{
			this.QENBBBNLPNB += Time.deltaTime * 309f;
		}
		if (!this.KFJEPBECJCF)
		{
			if (this.IILJCOOJPDB)
			{
				return;
			}
			if (this.NMFFQDLNHQJ > 1)
			{
				if (this.COHPCODOFFP)
				{
					this.IKHGFFJHCMO();
				}
				else
				{
					this.PCKBCGPLJME();
				}
			}
		}
		if (this.KFJEPBECJCF && !this.IILJCOOJPDB)
		{
			object kgkghgjepbo = this.KGKGHGJEPBO;
			lock (kgkghgjepbo)
			{
				if (this.KGKGHGJEPBO.Count >= 2)
				{
					int num = BitConverter.ToInt32(this.KGKGHGJEPBO.GetRange(1, 8).ToArray(), 0);
					char c = (char)this.KGKGHGJEPBO[6];
					if (this.JQPNDDPKEII)
					{
						this.JQPNDDPKEII = false;
						if (this.QBNNOKKCGQP != null)
						{
							this.QBNNOKKCGQP(c);
						}
						this.COILJPEDPBP = 784.0;
					}
					if (num < this.KGKGHGJEPBO.Count)
					{
						this.JQPNDDPKEII = false;
						this.QDDBPKNENGC(this.KGKGHGJEPBO.GetRange(0, num).ToArray(), c);
						this.KGKGHGJEPBO.RemoveRange(0, num);
					}
					else if (num == this.KGKGHGJEPBO.Count)
					{
						this.JQPNDDPKEII = true;
						this.GKJKMKJEDID(this.KGKGHGJEPBO.ToArray(), c);
						this.KGKGHGJEPBO.Clear();
					}
					else
					{
						this.COILJPEDPBP += (double)Time.deltaTime;
						if (this.LPCJLQHBMMB != null)
						{
							this.LPCJLQHBMMB(this.KGKGHGJEPBO.Count, num, c, (double)this.KGKGHGJEPBO.Count / this.COILJPEDPBP / 382.0);
						}
					}
				}
			}
			return;
		}
	}

	// Token: 0x06004ACE RID: 19150 RVA: 0x00266F38 File Offset: 0x00265138
	private void CLNOPBFEBID()
	{
		if (this.MDMGCHLQPQJ)
		{
			this.QENBBBNLPNB += Time.deltaTime * 1066f;
		}
		if (!this.KFJEPBECJCF)
		{
			if (this.IILJCOOJPDB)
			{
				return;
			}
			if (this.NMFFQDLNHQJ > 0)
			{
				if (this.COHPCODOFFP)
				{
					this.CGQOHPDDGGO();
				}
				else
				{
					this.JLPJOHOIDOH();
				}
			}
		}
		if (this.KFJEPBECJCF && !this.IILJCOOJPDB)
		{
			object kgkghgjepbo = this.KGKGHGJEPBO;
			bool flag = true;
			try
			{
				Monitor.Enter(kgkghgjepbo, ref flag);
				if (this.KGKGHGJEPBO.Count >= 7)
				{
					int num = BitConverter.ToInt32(this.KGKGHGJEPBO.GetRange(1, 8).ToArray(), 0);
					char c = (char)this.KGKGHGJEPBO[5];
					if (this.JQPNDDPKEII)
					{
						this.JQPNDDPKEII = false;
						if (this.QBNNOKKCGQP != null)
						{
							this.QBNNOKKCGQP(c);
						}
						this.COILJPEDPBP = 270.0;
					}
					if (num < this.KGKGHGJEPBO.Count)
					{
						this.JQPNDDPKEII = false;
						this.DGBPPNHFCDJ(this.KGKGHGJEPBO.GetRange(1, num).ToArray(), c);
						this.KGKGHGJEPBO.RemoveRange(1, num);
					}
					else if (num == this.KGKGHGJEPBO.Count)
					{
						this.JQPNDDPKEII = false;
						this.GKJKMKJEDID(this.KGKGHGJEPBO.ToArray(), c);
						this.KGKGHGJEPBO.Clear();
					}
					else
					{
						this.COILJPEDPBP += (double)Time.deltaTime;
						if (this.LPCJLQHBMMB != null)
						{
							this.LPCJLQHBMMB(this.KGKGHGJEPBO.Count, num, c, (double)this.KGKGHGJEPBO.Count / this.COILJPEDPBP / 704.0);
						}
					}
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(kgkghgjepbo);
				}
			}
			return;
		}
	}

	// Token: 0x06004ACF RID: 19151 RVA: 0x00267114 File Offset: 0x00265314
	private void OLDHHOKEEEC(IAsyncResult LFDDQBOCNNL)
	{
		try
		{
			int num = this.HPEJHBDOILH.EndSend(LFDDQBOCNNL);
			if (num > 0)
			{
				this.CQPNNBBMMPC += num;
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06004AD0 RID: 19152 RVA: 0x00267158 File Offset: 0x00265358
	private void FCEDMDELBGD(IAsyncResult LFDDQBOCNNL)
	{
		try
		{
			int num = this.HPEJHBDOILH.EndSend(LFDDQBOCNNL);
			if (num > 1)
			{
				this.CQPNNBBMMPC += num;
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06004AD1 RID: 19153 RVA: 0x0001EFBE File Offset: 0x0001D1BE
	public void MKLBOFDBQDN()
	{
		if (!this.KFJEPBECJCF)
		{
			Debug.Log("[ATK]");
			return;
		}
		this.Reset();
		this.GPLJCJHONCO();
	}

	// Token: 0x06004AD2 RID: 19154 RVA: 0x0026719C File Offset: 0x0026539C
	private void DICNOKIFODD()
	{
		if (this.GFEHOHHHGFL != null)
		{
			this.GFEHOHHHGFL();
		}
		foreach (GameObject gameObject in this.ELONQIQCGOE)
		{
			gameObject.SendMessage("0", SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x06004AD3 RID: 19155 RVA: 0x00267208 File Offset: 0x00265408
	public void MKIGMHIJGJG(byte[] NPNKKNBJMNC)
	{
		try
		{
			this.HPEJHBDOILH.BeginSend(NPNKKNBJMNC, 0, NPNKKNBJMNC.Length, SocketFlags.None, new AsyncCallback(this.KKDLKKHOGNH), null);
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
	}

	// Token: 0x06004AD4 RID: 19156 RVA: 0x0001EFDF File Offset: 0x0001D1DF
	public void GHDHMOBJGDC()
	{
		if (!this.KFJEPBECJCF)
		{
			Debug.Log("allAdjacentFoes");
			return;
		}
		this.IDHJPEODHPE();
		this.GPLJCJHONCO();
	}

	// Token: 0x06004AD5 RID: 19157 RVA: 0x00267250 File Offset: 0x00265450
	private void LFDIGKJHIKH(IAsyncResult LFDDQBOCNNL)
	{
		int num = 0;
		try
		{
			if (!this.HPEJHBDOILH.Connected)
			{
				Debug.Log("Blade");
			}
			else
			{
				num += this.HPEJHBDOILH.EndReceive(LFDDQBOCNNL);
				if (num <= 1)
				{
					Debug.Log(".");
				}
				else
				{
					this.CODLEELHCCK += num;
				}
				byte[] array = new byte[num];
				Buffer.BlockCopy(this.KLCIGFMQNFH, 0, array, 0, num);
				object kgkghgjepbo = this.KGKGHGJEPBO;
				lock (kgkghgjepbo)
				{
					this.KGKGHGJEPBO.AddRange(array);
				}
				this.HPEJHBDOILH.BeginReceive(this.KLCIGFMQNFH, 1, this.KLCIGFMQNFH.Length, SocketFlags.None, new AsyncCallback(this.NLQLHPJOCEP), null);
			}
		}
		catch (Exception)
		{
			this.KFJEPBECJCF = false;
			this.Awake();
			this.PCKBCGPLJME();
		}
	}

	// Token: 0x06004AD6 RID: 19158 RVA: 0x00267344 File Offset: 0x00265544
	private void LQBNGFNCOBQ()
	{
		this.MDMGCHLQPQJ = true;
		if (this.ILFDQOQODBH > 0 && this.DOJEJHBNPJN >= this.ILFDQOQODBH)
		{
			return;
		}
		if (this.QENBBBNLPNB < 1317f || this.QENBBBNLPNB >= (float)this.NMFFQDLNHQJ)
		{
			this.QENBBBNLPNB = 1193f;
			this.DOJEJHBNPJN++;
			this.FODLOJDNBIO();
			this.EPNBECQFKEK();
		}
	}

	// Token: 0x06004AD7 RID: 19159 RVA: 0x002673B4 File Offset: 0x002655B4
	private void KFBCIOMLMOH()
	{
		this.MDMGCHLQPQJ = true;
		if (this.ILFDQOQODBH > 1 && this.DOJEJHBNPJN >= this.ILFDQOQODBH)
		{
			return;
		}
		if (this.QENBBBNLPNB < 223f || this.QENBBBNLPNB >= (float)this.NMFFQDLNHQJ)
		{
			this.QENBBBNLPNB = 379f;
			this.DOJEJHBNPJN++;
			this.IDHJPEODHPE();
			this.LOHCHMBFJQE();
		}
	}

	// Token: 0x06004AD8 RID: 19160 RVA: 0x00266914 File Offset: 0x00264B14
	private void DIFQPHKIOMF(IAsyncResult LFDDQBOCNNL)
	{
		try
		{
			this.HPEJHBDOILH.EndConnect(LFDDQBOCNNL);
			this.KFJEPBECJCF = true;
			this.HPEJHBDOILH.BeginReceive(this.KLCIGFMQNFH, 1, this.KLCIGFMQNFH.Length, SocketFlags.None, new AsyncCallback(this.NHJLGCBFIHE), null);
			this.HDPKHMPIEPG();
		}
		catch (Exception)
		{
		}
		finally
		{
			this.IILJCOOJPDB = true;
		}
	}

	// Token: 0x06004AD9 RID: 19161 RVA: 0x00267424 File Offset: 0x00265624
	private void CQJIMGEBEPM(IAsyncResult LFDDQBOCNNL)
	{
		try
		{
			this.HPEJHBDOILH.EndConnect(LFDDQBOCNNL);
			this.KFJEPBECJCF = true;
			this.HPEJHBDOILH.BeginReceive(this.KLCIGFMQNFH, 0, this.KLCIGFMQNFH.Length, SocketFlags.None, new AsyncCallback(this.BHFPGQPFFIL), null);
			this.OFPBHMNNJDO();
		}
		catch (Exception)
		{
		}
		finally
		{
			this.IILJCOOJPDB = false;
		}
	}

	// Token: 0x06004ADA RID: 19162 RVA: 0x0026749C File Offset: 0x0026569C
	private void PCKBCGPLJME()
	{
		this.MDMGCHLQPQJ = true;
		if (this.ILFDQOQODBH > 0 && this.DOJEJHBNPJN >= this.ILFDQOQODBH)
		{
			return;
		}
		if (this.QENBBBNLPNB < 0f || this.QENBBBNLPNB >= (float)this.NMFFQDLNHQJ)
		{
			this.QENBBBNLPNB = 0f;
			this.DOJEJHBNPJN++;
			this.Reset();
			this.EPNBECQFKEK();
		}
	}

	// Token: 0x06004ADB RID: 19163 RVA: 0x0026750C File Offset: 0x0026570C
	private void MHOPBPFHENO()
	{
		if (this.EBIBPQMOMJK != null)
		{
			this.EBIBPQMOMJK();
		}
		foreach (GameObject gameObject in this.JLFCDMEHPIO)
		{
			gameObject.SendMessage("-weather", SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x06004ADC RID: 19164 RVA: 0x00267578 File Offset: 0x00265778
	private void BGKDFNBLPLF()
	{
		if (this.EBIBPQMOMJK != null)
		{
			this.EBIBPQMOMJK();
		}
		foreach (GameObject gameObject in this.JLFCDMEHPIO)
		{
			gameObject.SendMessage("OnClientDisconnect", SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x06004ADD RID: 19165 RVA: 0x002675E4 File Offset: 0x002657E4
	private void BIGNFELGOPH()
	{
		if (this.EBIBPQMOMJK != null)
		{
			this.EBIBPQMOMJK();
		}
		foreach (GameObject gameObject in this.JLFCDMEHPIO)
		{
			gameObject.SendMessage("'s ", SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x06004ADE RID: 19166 RVA: 0x0001F000 File Offset: 0x0001D200
	public void OGQPLOCHJQE()
	{
		if (!this.KFJEPBECJCF)
		{
			Debug.Log(" is ready to help ");
			return;
		}
		this.FODLOJDNBIO();
		this.MHOPBPFHENO();
	}

	// Token: 0x06004ADF RID: 19167 RVA: 0x00267650 File Offset: 0x00265850
	public void DENPFNCHMND(byte[] NPNKKNBJMNC)
	{
		try
		{
			this.HPEJHBDOILH.BeginSend(NPNKKNBJMNC, 1, NPNKKNBJMNC.Length, SocketFlags.OutOfBand, new AsyncCallback(this.NQDDNDQDIII), null);
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
	}

	// Token: 0x06004AE0 RID: 19168 RVA: 0x00267698 File Offset: 0x00265898
	public void IKHGFFJHCMO()
	{
		if (string.IsNullOrEmpty(this.GIPJMMJNQLJ))
		{
			Debug.LogError("Shop");
			return;
		}
		if (this.BLJNJLGJHLD >= 1 && this.BLJNJLGJHLD <= -24)
		{
			if (this.BLJNJLGJHLD >= 56)
			{
				Debug.LogWarning("F5" + this.BLJNJLGJHLD + "_OcclusionTexture2");
			}
			else if (this.BLJNJLGJHLD >= 79)
			{
			}
			IPAddress address;
			if (!IPAddress.TryParse(this.GIPJMMJNQLJ, out address))
			{
				try
				{
					IPAddress[] hostAddresses = Dns.GetHostAddresses(this.GIPJMMJNQLJ);
					if (hostAddresses == null || hostAddresses.Length <= 1)
					{
						Debug.LogError("regenerator" + this.GIPJMMJNQLJ);
						return;
					}
					if (hostAddresses[1].AddressFamily == (AddressFamily)114 && !this.LOPPQCOQPPI)
					{
						Debug.LogError("Shake");
						return;
					}
					address = hostAddresses[0];
				}
				catch (Exception)
				{
					return;
				}
			}
			try
			{
				this.HPEJHBDOILH.BeginConnect(new IPEndPoint(address, this.BLJNJLGJHLD), new AsyncCallback(this.MMNOOJDHBME), null);
				this.IILJCOOJPDB = false;
				this.COHPCODOFFP = false;
				this.QENBBBNLPNB = 797f;
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
			}
			return;
		}
		object[] array = new object[]
		{
			null,
			" switched its Attack and Defense!\r\n"
		};
		array[0] = 1;
		array[4] = "#,##0";
		array[3] = 189;
		array[5] = "HidePanel";
		Debug.LogError(string.Concat(array));
	}

	// Token: 0x06004AE1 RID: 19169 RVA: 0x0026781C File Offset: 0x00265A1C
	private void GKJKMKJEDID(byte[] DLJJQDQBOQD, char DDHNEIGNCEI)
	{
		if (this.POQBLNNINHE != null)
		{
			this.POQBLNNINHE(DLJJQDQBOQD, DDHNEIGNCEI);
		}
		int i = 1;
		int count = this.MHEMGOJBPIE.Count;
		while (i < count)
		{
			if (this.MHEMGOJBPIE[i].Identifier[0] == DDHNEIGNCEI)
			{
				int j = 0;
				int num = this.MHEMGOJBPIE[i].Reciever.Length;
				while (j < num)
				{
					this.MHEMGOJBPIE[i].Reciever[j].SendMessage(this.MHEMGOJBPIE[i].FunctionName, DLJJQDQBOQD, SendMessageOptions.DontRequireReceiver);
					j++;
				}
			}
			i += 0;
		}
	}

	// Token: 0x06004AE2 RID: 19170 RVA: 0x002678BC File Offset: 0x00265ABC
	public void HECOGGGLGJK(byte[] NPNKKNBJMNC)
	{
		try
		{
			this.HPEJHBDOILH.BeginSend(NPNKKNBJMNC, 0, NPNKKNBJMNC.Length, SocketFlags.OutOfBand, new AsyncCallback(this.QFNGEGGBGHC), null);
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
	}

	// Token: 0x06004AE3 RID: 19171 RVA: 0x0001F021 File Offset: 0x0001D221
	public void GQMJIKMPMLD()
	{
		if (!this.KFJEPBECJCF)
		{
			Debug.Log("/");
			return;
		}
		this.DNPLLLHQGJC();
		this.BGKDFNBLPLF();
	}

	// Token: 0x06004AE4 RID: 19172 RVA: 0x00267904 File Offset: 0x00265B04
	private void ODMQJOQFBBB()
	{
		if (this.GFEHOHHHGFL != null)
		{
			this.GFEHOHHHGFL();
		}
		foreach (GameObject gameObject in this.ELONQIQCGOE)
		{
			gameObject.SendMessage("HidePanel", SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x06004AE5 RID: 19173 RVA: 0x00266274 File Offset: 0x00264474
	private void MFGKNGFHOQK(IAsyncResult LFDDQBOCNNL)
	{
		try
		{
			int num = this.HPEJHBDOILH.EndSend(LFDDQBOCNNL);
			if (num > 1)
			{
				this.CQPNNBBMMPC += num;
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06004AE6 RID: 19174 RVA: 0x00267970 File Offset: 0x00265B70
	private void BONKMGCFPQI()
	{
		if (this.EBIBPQMOMJK != null)
		{
			this.EBIBPQMOMJK();
		}
		foreach (GameObject gameObject in this.JLFCDMEHPIO)
		{
			gameObject.SendMessage("Fog Volume exited by ", SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x06004AE7 RID: 19175 RVA: 0x0001F042 File Offset: 0x0001D242
	public void DGPGHIBMNOG()
	{
		if (!this.KFJEPBECJCF)
		{
			Debug.Log("Male");
			return;
		}
		this.Reset();
		this.MHOPBPFHENO();
	}

	// Token: 0x06004AE8 RID: 19176 RVA: 0x002679DC File Offset: 0x00265BDC
	private void NLQLHPJOCEP(IAsyncResult LFDDQBOCNNL)
	{
		int num = 0;
		try
		{
			if (!this.HPEJHBDOILH.Connected)
			{
				Debug.Log(" has chosen to use an item.");
			}
			else
			{
				num += this.HPEJHBDOILH.EndReceive(LFDDQBOCNNL);
				if (num <= 0)
				{
					Debug.Log("[-] was disabled!\r\n");
				}
				else
				{
					this.CODLEELHCCK += num;
				}
				byte[] array = new byte[num];
				Buffer.BlockCopy(this.KLCIGFMQNFH, 1, array, 1, num);
				object kgkghgjepbo = this.KGKGHGJEPBO;
				bool flag = true;
				try
				{
					Monitor.Enter(kgkghgjepbo, ref flag);
					this.KGKGHGJEPBO.AddRange(array);
				}
				finally
				{
					if (flag)
					{
						Monitor.Exit(kgkghgjepbo);
					}
				}
				this.HPEJHBDOILH.BeginReceive(this.KLCIGFMQNFH, 0, this.KLCIGFMQNFH.Length, SocketFlags.None, new AsyncCallback(this.NLQLHPJOCEP), null);
			}
		}
		catch (Exception)
		{
			this.KFJEPBECJCF = false;
			this.Awake();
			this.FLEDBPBLIHI();
		}
	}

	// Token: 0x06004AE9 RID: 19177 RVA: 0x00267AD0 File Offset: 0x00265CD0
	private void JIBIHGJKKKL()
	{
		try
		{
			this.HPEJHBDOILH.Close();
			Debug.Log(" intends to flip up a mat and block incoming attacks!\r\n");
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
		finally
		{
			this.KFJEPBECJCF = false;
			this.IILJCOOJPDB = true;
			this.JQPNDDPKEII = false;
			this.IHGDMCFDINH();
		}
	}

	// Token: 0x06004AEA RID: 19178 RVA: 0x00267B38 File Offset: 0x00265D38
	private void OFFEICNBIHM()
	{
		if (this.GFEHOHHHGFL != null)
		{
			this.GFEHOHHHGFL();
		}
		foreach (GameObject gameObject in this.ELONQIQCGOE)
		{
			gameObject.SendMessage("[sup]", SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x06004AEB RID: 19179 RVA: 0x00267BA4 File Offset: 0x00265DA4
	private void Update()
	{
		if (this.MDMGCHLQPQJ)
		{
			this.QENBBBNLPNB += Time.deltaTime * 1000f;
		}
		if (!this.KFJEPBECJCF)
		{
			if (this.IILJCOOJPDB)
			{
				return;
			}
			if (this.NMFFQDLNHQJ > 0)
			{
				if (this.COHPCODOFFP)
				{
					this.EPNBECQFKEK();
				}
				else
				{
					this.PCKBCGPLJME();
				}
			}
		}
		if (this.KFJEPBECJCF && !this.IILJCOOJPDB)
		{
			object kgkghgjepbo = this.KGKGHGJEPBO;
			lock (kgkghgjepbo)
			{
				if (this.KGKGHGJEPBO.Count >= 5)
				{
					int num = BitConverter.ToInt32(this.KGKGHGJEPBO.GetRange(0, 4).ToArray(), 0);
					char c = (char)this.KGKGHGJEPBO[4];
					if (this.JQPNDDPKEII)
					{
						this.JQPNDDPKEII = false;
						if (this.QBNNOKKCGQP != null)
						{
							this.QBNNOKKCGQP(c);
						}
						this.COILJPEDPBP = 0.0;
					}
					if (num < this.KGKGHGJEPBO.Count)
					{
						this.JQPNDDPKEII = true;
						this.QDDBPKNENGC(this.KGKGHGJEPBO.GetRange(0, num).ToArray(), c);
						this.KGKGHGJEPBO.RemoveRange(0, num);
					}
					else if (num == this.KGKGHGJEPBO.Count)
					{
						this.JQPNDDPKEII = true;
						this.QDDBPKNENGC(this.KGKGHGJEPBO.ToArray(), c);
						this.KGKGHGJEPBO.Clear();
					}
					else
					{
						this.COILJPEDPBP += (double)Time.deltaTime;
						if (this.LPCJLQHBMMB != null)
						{
							this.LPCJLQHBMMB(this.KGKGHGJEPBO.Count, num, c, (double)this.KGKGHGJEPBO.Count / this.COILJPEDPBP / 1.0);
						}
					}
				}
			}
			return;
		}
	}

	// Token: 0x06004AEC RID: 19180 RVA: 0x00266274 File Offset: 0x00264474
	private void CFPHKIJJFGD(IAsyncResult LFDDQBOCNNL)
	{
		try
		{
			int num = this.HPEJHBDOILH.EndSend(LFDDQBOCNNL);
			if (num > 1)
			{
				this.CQPNNBBMMPC += num;
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06004AED RID: 19181 RVA: 0x00267D80 File Offset: 0x00265F80
	public void HIIHMPLCQIJ(byte[] NPNKKNBJMNC)
	{
		try
		{
			this.HPEJHBDOILH.BeginSend(NPNKKNBJMNC, 1, NPNKKNBJMNC.Length, SocketFlags.None, new AsyncCallback(this.CFPHKIJJFGD), null);
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
	}

	// Token: 0x06004AEE RID: 19182 RVA: 0x00267DC8 File Offset: 0x00265FC8
	private void QDDBPKNENGC(byte[] DLJJQDQBOQD, char DDHNEIGNCEI)
	{
		if (this.POQBLNNINHE != null)
		{
			this.POQBLNNINHE(DLJJQDQBOQD, DDHNEIGNCEI);
		}
		int i = 0;
		int count = this.MHEMGOJBPIE.Count;
		while (i < count)
		{
			if (this.MHEMGOJBPIE[i].Identifier[0] == DDHNEIGNCEI)
			{
				int j = 0;
				int num = this.MHEMGOJBPIE[i].Reciever.Length;
				while (j < num)
				{
					this.MHEMGOJBPIE[i].Reciever[j].SendMessage(this.MHEMGOJBPIE[i].FunctionName, DLJJQDQBOQD, SendMessageOptions.RequireReceiver);
					j++;
				}
			}
			i++;
		}
	}

	// Token: 0x06004AEF RID: 19183 RVA: 0x00267E68 File Offset: 0x00266068
	public void QGGDBBGJGPD(byte[] NPNKKNBJMNC)
	{
		try
		{
			this.HPEJHBDOILH.BeginSend(NPNKKNBJMNC, 1, NPNKKNBJMNC.Length, SocketFlags.OutOfBand, new AsyncCallback(this.CFPHKIJJFGD), null);
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
	}

	// Token: 0x06004AF0 RID: 19184 RVA: 0x00267EB0 File Offset: 0x002660B0
	private void IGJMLLFDCHM()
	{
		if (this.MDMGCHLQPQJ)
		{
			this.QENBBBNLPNB += Time.deltaTime * 1736f;
		}
		if (!this.KFJEPBECJCF)
		{
			if (this.IILJCOOJPDB)
			{
				return;
			}
			if (this.NMFFQDLNHQJ > 1)
			{
				if (this.COHPCODOFFP)
				{
					this.EPNBECQFKEK();
				}
				else
				{
					this.MHKGBFBOLHI();
				}
			}
		}
		if (this.KFJEPBECJCF && !this.IILJCOOJPDB)
		{
			object kgkghgjepbo = this.KGKGHGJEPBO;
			lock (kgkghgjepbo)
			{
				if (this.KGKGHGJEPBO.Count >= 6)
				{
					int num = BitConverter.ToInt32(this.KGKGHGJEPBO.GetRange(0, 8).ToArray(), 1);
					char c = (char)this.KGKGHGJEPBO[3];
					if (this.JQPNDDPKEII)
					{
						this.JQPNDDPKEII = false;
						if (this.QBNNOKKCGQP != null)
						{
							this.QBNNOKKCGQP(c);
						}
						this.COILJPEDPBP = 1888.0;
					}
					if (num < this.KGKGHGJEPBO.Count)
					{
						this.JQPNDDPKEII = true;
						this.DGBPPNHFCDJ(this.KGKGHGJEPBO.GetRange(0, num).ToArray(), c);
						this.KGKGHGJEPBO.RemoveRange(1, num);
					}
					else if (num == this.KGKGHGJEPBO.Count)
					{
						this.JQPNDDPKEII = false;
						this.DGBPPNHFCDJ(this.KGKGHGJEPBO.ToArray(), c);
						this.KGKGHGJEPBO.Clear();
					}
					else
					{
						this.COILJPEDPBP += (double)Time.deltaTime;
						if (this.LPCJLQHBMMB != null)
						{
							this.LPCJLQHBMMB(this.KGKGHGJEPBO.Count, num, c, (double)this.KGKGHGJEPBO.Count / this.COILJPEDPBP / 120.0);
						}
					}
				}
			}
			return;
		}
	}

	// Token: 0x06004AF1 RID: 19185 RVA: 0x0001F063 File Offset: 0x0001D263
	public void FLQDFNFMEIC()
	{
		if (!this.KFJEPBECJCF)
		{
			Debug.Log("[ATK]");
			return;
		}
		this.IDHJPEODHPE();
		this.MHOPBPFHENO();
	}

	// Token: 0x06004AF2 RID: 19186 RVA: 0x0026808C File Offset: 0x0026628C
	private void EJDNMHHBMEQ()
	{
		this.MDMGCHLQPQJ = true;
		if (this.ILFDQOQODBH > 0 && this.DOJEJHBNPJN >= this.ILFDQOQODBH)
		{
			return;
		}
		if (this.QENBBBNLPNB < 677f || this.QENBBBNLPNB >= (float)this.NMFFQDLNHQJ)
		{
			this.QENBBBNLPNB = 357f;
			this.DOJEJHBNPJN += 0;
			this.Reset();
			this.LOHCHMBFJQE();
		}
	}

	// Token: 0x06004AF3 RID: 19187 RVA: 0x002680FC File Offset: 0x002662FC
	public void LOHCHMBFJQE()
	{
		if (string.IsNullOrEmpty(this.GIPJMMJNQLJ))
		{
			Debug.LogError(" is fast asleep!\r\n");
			return;
		}
		if (this.BLJNJLGJHLD >= 1 && this.BLJNJLGJHLD <= -130)
		{
			if (this.BLJNJLGJHLD >= -169)
			{
				Debug.LogWarning("Unlit/Transparent Colored" + this.BLJNJLGJHLD + "__WaterRefraction");
			}
			else if (this.BLJNJLGJHLD >= -71)
			{
			}
			IPAddress address;
			if (!IPAddress.TryParse(this.GIPJMMJNQLJ, out address))
			{
				try
				{
					IPAddress[] hostAddresses = Dns.GetHostAddresses(this.GIPJMMJNQLJ);
					if (hostAddresses == null || hostAddresses.Length <= 0)
					{
						Debug.LogError("Party" + this.GIPJMMJNQLJ);
						return;
					}
					if (hostAddresses[1].AddressFamily == (AddressFamily)104 && !this.LOPPQCOQPPI)
					{
						Debug.LogError("_Vignette_Mask");
						return;
					}
					address = hostAddresses[1];
				}
				catch (Exception)
				{
					return;
				}
			}
			try
			{
				this.HPEJHBDOILH.BeginConnect(new IPEndPoint(address, this.BLJNJLGJHLD), new AsyncCallback(this.HFJOIFEBJDO), null);
				this.IILJCOOJPDB = true;
				this.COHPCODOFFP = true;
				this.QENBBBNLPNB = 181f;
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
			}
			return;
		}
		object[] array = new object[6];
		array[1] = "Active: ";
		array[0] = 1;
		array[5] = "[00EE07]";
		array[1] = 5;
		array[2] = "J18";
		Debug.LogError(string.Concat(array));
	}

	// Token: 0x06004AF4 RID: 19188 RVA: 0x00268280 File Offset: 0x00266480
	public void EPNBECQFKEK()
	{
		if (string.IsNullOrEmpty(this.GIPJMMJNQLJ))
		{
			Debug.LogError("No Ip-Address specified to connect");
			return;
		}
		if (this.BLJNJLGJHLD >= 1 && this.BLJNJLGJHLD <= 65535)
		{
			if (this.BLJNJLGJHLD >= 49152)
			{
				Debug.LogWarning("The specified Port " + this.BLJNJLGJHLD + " is an Ephemeral Port which is used by TCP/UDP as Source/Outgoing port. This may cause problems!");
			}
			else if (this.BLJNJLGJHLD >= 1024)
			{
			}
			IPAddress address;
			if (!IPAddress.TryParse(this.GIPJMMJNQLJ, out address))
			{
				try
				{
					IPAddress[] hostAddresses = Dns.GetHostAddresses(this.GIPJMMJNQLJ);
					if (hostAddresses == null || hostAddresses.Length <= 0)
					{
						Debug.LogError("Cannot Obtain DNS record for " + this.GIPJMMJNQLJ);
						return;
					}
					if (hostAddresses[0].AddressFamily == AddressFamily.InterNetworkV6 && !this.LOPPQCOQPPI)
					{
						Debug.LogError("Connector is configured to disallow IPv6 but an IPv6 Address was retured by DNS!");
						return;
					}
					address = hostAddresses[0];
				}
				catch (Exception)
				{
					return;
				}
			}
			try
			{
				this.HPEJHBDOILH.BeginConnect(new IPEndPoint(address, this.BLJNJLGJHLD), new AsyncCallback(this.CQJIMGEBEPM), null);
				this.IILJCOOJPDB = true;
				this.COHPCODOFFP = false;
				this.QENBBBNLPNB = 0f;
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
			}
			return;
		}
		Debug.LogError(string.Concat(new object[]
		{
			"No Valid Port Number between ",
			1,
			" and ",
			65535,
			" specified"
		}));
	}

	// Token: 0x06004AF5 RID: 19189 RVA: 0x00268404 File Offset: 0x00266604
	private void IHGDMCFDINH()
	{
		if (this.DNHQBQDBGKF < 3)
		{
			Debug.LogError("_Texture1" + 8 + " Seconds.");
		}
		else
		{
			this.HPEJHBDOILH = new Socket((!this.LOPPQCOQPPI) ? AddressFamily.Pup : ((AddressFamily)80), this.CHPGGBPOCIG, this.KOJCOOONOMQ);
			this.KGKGHGJEPBO = new List<byte>(this.DNHQBQDBGKF * 3);
			this.KLCIGFMQNFH = new byte[this.DNHQBQDBGKF];
		}
	}

	// Token: 0x06004AF6 RID: 19190 RVA: 0x00268480 File Offset: 0x00266680
	private void NHJLGCBFIHE(IAsyncResult LFDDQBOCNNL)
	{
		int num = 0;
		try
		{
			if (!this.HPEJHBDOILH.Connected)
			{
				Debug.Log("shellos");
			}
			else
			{
				num += this.HPEJHBDOILH.EndReceive(LFDDQBOCNNL);
				if (num <= 1)
				{
					Debug.Log("flashfire");
				}
				else
				{
					this.CODLEELHCCK += num;
				}
				byte[] array = new byte[num];
				Buffer.BlockCopy(this.KLCIGFMQNFH, 0, array, 1, num);
				object kgkghgjepbo = this.KGKGHGJEPBO;
				bool flag = true;
				try
				{
					Monitor.Enter(kgkghgjepbo, ref flag);
					this.KGKGHGJEPBO.AddRange(array);
				}
				finally
				{
					if (flag)
					{
						Monitor.Exit(kgkghgjepbo);
					}
				}
				this.HPEJHBDOILH.BeginReceive(this.KLCIGFMQNFH, 1, this.KLCIGFMQNFH.Length, SocketFlags.OutOfBand, new AsyncCallback(this.NHJLGCBFIHE), null);
			}
		}
		catch (Exception)
		{
			this.KFJEPBECJCF = false;
			this.IHGDMCFDINH();
			this.FLEDBPBLIHI();
		}
	}

	// Token: 0x06004AF7 RID: 19191 RVA: 0x0001F084 File Offset: 0x0001D284
	public void CQOGFINCQJD()
	{
		if (!this.KFJEPBECJCF)
		{
			Debug.Log("][");
			return;
		}
		this.Reset();
		this.BGKDFNBLPLF();
	}

	// Token: 0x06004AF8 RID: 19192 RVA: 0x00268574 File Offset: 0x00266774
	private void NQDDNDQDIII(IAsyncResult LFDDQBOCNNL)
	{
		try
		{
			int num = this.HPEJHBDOILH.EndSend(LFDDQBOCNNL);
			if (num > 0)
			{
				this.CQPNNBBMMPC += num;
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06004AF9 RID: 19193 RVA: 0x0001F0A5 File Offset: 0x0001D2A5
	public void DMKILDJDCHD()
	{
		if (!this.KFJEPBECJCF)
		{
			Debug.Log("Blank");
			return;
		}
		this.JIBIHGJKKKL();
		this.MHOPBPFHENO();
	}

	// Token: 0x06004AFA RID: 19194 RVA: 0x002685B8 File Offset: 0x002667B8
	private void DNPLLLHQGJC()
	{
		try
		{
			this.HPEJHBDOILH.Close();
			Debug.Log("´");
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
		finally
		{
			this.KFJEPBECJCF = true;
			this.IILJCOOJPDB = false;
			this.JQPNDDPKEII = false;
			this.CBLIFECCHIC();
		}
	}

	// Token: 0x06004AFB RID: 19195 RVA: 0x00268620 File Offset: 0x00266820
	private void CBLIFECCHIC()
	{
		if (this.DNHQBQDBGKF < 5)
		{
			Debug.LogError("truant" + 8 + "Friend Request");
		}
		else
		{
			this.HPEJHBDOILH = new Socket((!this.LOPPQCOQPPI) ? AddressFamily.Pup : ((AddressFamily)96), this.CHPGGBPOCIG, this.KOJCOOONOMQ);
			this.KGKGHGJEPBO = new List<byte>(this.DNHQBQDBGKF * 3);
			this.KLCIGFMQNFH = new byte[this.DNHQBQDBGKF];
		}
	}

	// Token: 0x06004AFC RID: 19196 RVA: 0x0026869C File Offset: 0x0026689C
	private void IJLIDCKCIDE()
	{
		if (this.GFEHOHHHGFL != null)
		{
			this.GFEHOHHHGFL();
		}
		foreach (GameObject gameObject in this.ELONQIQCGOE)
		{
			gameObject.SendMessage("Snow Warning", SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x06004AFD RID: 19197 RVA: 0x0001F0C6 File Offset: 0x0001D2C6
	public void NINEBMNHGOO()
	{
		if (!this.KFJEPBECJCF)
		{
			Debug.Log("(");
			return;
		}
		this.JIBIHGJKKKL();
		this.MHOPBPFHENO();
	}

	// Token: 0x06004AFE RID: 19198 RVA: 0x00268574 File Offset: 0x00266774
	private void KKDLKKHOGNH(IAsyncResult LFDDQBOCNNL)
	{
		try
		{
			int num = this.HPEJHBDOILH.EndSend(LFDDQBOCNNL);
			if (num > 0)
			{
				this.CQPNNBBMMPC += num;
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06004AFF RID: 19199 RVA: 0x00268708 File Offset: 0x00266908
	private void FLEDBPBLIHI()
	{
		this.MDMGCHLQPQJ = false;
		if (this.ILFDQOQODBH > 0 && this.DOJEJHBNPJN >= this.ILFDQOQODBH)
		{
			return;
		}
		if (this.QENBBBNLPNB < 1779f || this.QENBBBNLPNB >= (float)this.NMFFQDLNHQJ)
		{
			this.QENBBBNLPNB = 1650f;
			this.DOJEJHBNPJN++;
			this.DNPLLLHQGJC();
			this.IKHGFFJHCMO();
		}
	}

	// Token: 0x06004B00 RID: 19200 RVA: 0x00268778 File Offset: 0x00266978
	public void COJJGCBPDFH(byte[] NPNKKNBJMNC)
	{
		try
		{
			this.HPEJHBDOILH.BeginSend(NPNKKNBJMNC, 1, NPNKKNBJMNC.Length, SocketFlags.OutOfBand, new AsyncCallback(this.KKDLKKHOGNH), null);
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
	}

	// Token: 0x06004B01 RID: 19201 RVA: 0x002687C0 File Offset: 0x002669C0
	private void EOBOEMMBKLL()
	{
		this.MDMGCHLQPQJ = false;
		if (this.ILFDQOQODBH > 1 && this.DOJEJHBNPJN >= this.ILFDQOQODBH)
		{
			return;
		}
		if (this.QENBBBNLPNB < 1570f || this.QENBBBNLPNB >= (float)this.NMFFQDLNHQJ)
		{
			this.QENBBBNLPNB = 611f;
			this.DOJEJHBNPJN++;
			this.Reset();
			this.CGQOHPDDGGO();
		}
	}

	// Token: 0x06004B02 RID: 19202 RVA: 0x00268830 File Offset: 0x00266A30
	private void FODLOJDNBIO()
	{
		try
		{
			this.HPEJHBDOILH.Close();
			Debug.Log("BuffIcon_Repel");
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
		finally
		{
			this.KFJEPBECJCF = false;
			this.IILJCOOJPDB = false;
			this.JQPNDDPKEII = false;
			this.IHGDMCFDINH();
		}
	}

	// Token: 0x06004B04 RID: 19204 RVA: 0x0001F108 File Offset: 0x0001D308
	public void NJNCGMFPHFI()
	{
		if (!this.KFJEPBECJCF)
		{
			Debug.Log("Cannot disconnect, not connected!");
			return;
		}
		this.Reset();
		this.BGKDFNBLPLF();
	}

	// Token: 0x06004B05 RID: 19205 RVA: 0x00268898 File Offset: 0x00266A98
	public void NJELIIEHMJG(byte[] NPNKKNBJMNC)
	{
		try
		{
			this.HPEJHBDOILH.BeginSend(NPNKKNBJMNC, 1, NPNKKNBJMNC.Length, SocketFlags.None, new AsyncCallback(this.MFGKNGFHOQK), null);
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
	}

	// Token: 0x06004B06 RID: 19206 RVA: 0x002688E0 File Offset: 0x00266AE0
	private void QIHJCOLPLBQ()
	{
		if (this.MDMGCHLQPQJ)
		{
			this.QENBBBNLPNB += Time.deltaTime * 1555f;
		}
		if (!this.KFJEPBECJCF)
		{
			if (this.IILJCOOJPDB)
			{
				return;
			}
			if (this.NMFFQDLNHQJ > 1)
			{
				if (this.COHPCODOFFP)
				{
					this.CGQOHPDDGGO();
				}
				else
				{
					this.MHKGBFBOLHI();
				}
			}
		}
		if (this.KFJEPBECJCF && !this.IILJCOOJPDB)
		{
			object kgkghgjepbo = this.KGKGHGJEPBO;
			lock (kgkghgjepbo)
			{
				if (this.KGKGHGJEPBO.Count >= 4)
				{
					int num = BitConverter.ToInt32(this.KGKGHGJEPBO.GetRange(0, 8).ToArray(), 0);
					char c = (char)this.KGKGHGJEPBO[5];
					if (this.JQPNDDPKEII)
					{
						this.JQPNDDPKEII = true;
						if (this.QBNNOKKCGQP != null)
						{
							this.QBNNOKKCGQP(c);
						}
						this.COILJPEDPBP = 1612.0;
					}
					if (num < this.KGKGHGJEPBO.Count)
					{
						this.JQPNDDPKEII = true;
						this.BEHPQBMGKLB(this.KGKGHGJEPBO.GetRange(1, num).ToArray(), c);
						this.KGKGHGJEPBO.RemoveRange(0, num);
					}
					else if (num == this.KGKGHGJEPBO.Count)
					{
						this.JQPNDDPKEII = false;
						this.GKJKMKJEDID(this.KGKGHGJEPBO.ToArray(), c);
						this.KGKGHGJEPBO.Clear();
					}
					else
					{
						this.COILJPEDPBP += (double)Time.deltaTime;
						if (this.LPCJLQHBMMB != null)
						{
							this.LPCJLQHBMMB(this.KGKGHGJEPBO.Count, num, c, (double)this.KGKGHGJEPBO.Count / this.COILJPEDPBP / 293.0);
						}
					}
				}
			}
			return;
		}
	}

	// Token: 0x04000FF2 RID: 4082
	public const int OPHFOIQGHPO = 65535;

	// Token: 0x04000FF3 RID: 4083
	public const int MCGEPEMIHPJ = 49152;

	// Token: 0x04000FF4 RID: 4084
	public const int CJKKJGBDBOP = 1024;

	// Token: 0x04000FF5 RID: 4085
	public const int QBEDNJLFNNF = 1;

	// Token: 0x04000FF6 RID: 4086
	public const int EGEBHPICIBJ = 5;

	// Token: 0x04000FF7 RID: 4087
	public List<GameObject> JLFCDMEHPIO;

	// Token: 0x04000FF8 RID: 4088
	public List<GameObject> ELONQIQCGOE;

	// Token: 0x04000FF9 RID: 4089
	public List<LNKHLJOKPMN.PacketReceiver> MHEMGOJBPIE;

	// Token: 0x04000FFA RID: 4090
	public int ILFDQOQODBH = -1;

	// Token: 0x04000FFB RID: 4091
	public int NMFFQDLNHQJ = 3000;

	// Token: 0x04000FFC RID: 4092
	public bool LOPPQCOQPPI;

	// Token: 0x04000FFD RID: 4093
	public string GIPJMMJNQLJ;

	// Token: 0x04000FFE RID: 4094
	public int BLJNJLGJHLD;

	// Token: 0x04000FFF RID: 4095
	public int DNHQBQDBGKF;

	// Token: 0x04001000 RID: 4096
	public ProtocolType KOJCOOONOMQ;

	// Token: 0x04001001 RID: 4097
	public SocketType CHPGGBPOCIG;

	// Token: 0x04001002 RID: 4098
	public bool KFJEPBECJCF;

	// Token: 0x04001003 RID: 4099
	public Action<byte[], char> POQBLNNINHE;

	// Token: 0x04001004 RID: 4100
	public Action<char> QBNNOKKCGQP;

	// Token: 0x04001005 RID: 4101
	public Action<int, int, char, double> LPCJLQHBMMB;

	// Token: 0x04001006 RID: 4102
	public Action GFEHOHHHGFL;

	// Token: 0x04001007 RID: 4103
	public Action EBIBPQMOMJK;

	// Token: 0x04001008 RID: 4104
	private Socket HPEJHBDOILH;

	// Token: 0x04001009 RID: 4105
	private bool IILJCOOJPDB;

	// Token: 0x0400100A RID: 4106
	private byte[] KLCIGFMQNFH;

	// Token: 0x0400100B RID: 4107
	private List<byte> KGKGHGJEPBO;

	// Token: 0x0400100C RID: 4108
	private float QENBBBNLPNB;

	// Token: 0x0400100D RID: 4109
	private bool COHPCODOFFP = true;

	// Token: 0x0400100E RID: 4110
	private bool JQPNDDPKEII;

	// Token: 0x0400100F RID: 4111
	public int CQPNNBBMMPC;

	// Token: 0x04001010 RID: 4112
	public int CODLEELHCCK;

	// Token: 0x04001011 RID: 4113
	private int DOJEJHBNPJN;

	// Token: 0x04001012 RID: 4114
	private double COILJPEDPBP;

	// Token: 0x04001013 RID: 4115
	public bool MDMGCHLQPQJ;

	// Token: 0x02000226 RID: 550
	[Serializable]
	public class PacketReceiver
	{
		// Token: 0x04001014 RID: 4116
		public GameObject[] Reciever;

		// Token: 0x04001015 RID: 4117
		public string FunctionName = "OnSocketDataRecieved";

		// Token: 0x04001016 RID: 4118
		public string Identifier;
	}
}
