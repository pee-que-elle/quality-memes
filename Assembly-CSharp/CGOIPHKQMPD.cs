using System;
using System.Collections.Generic;
using PSXAPI.Response;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x02000223 RID: 547
public class CGOIPHKQMPD : MonoBehaviour
{
	// Token: 0x06004A58 RID: 19032 RVA: 0x002593E4 File Offset: 0x002575E4
	private void HLHPCLEMCKI()
	{
		CGOIPHKQMPD.HBFFCJHOCPE = this;
		GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
		if (qoqonhoolne != null && qoqonhoolne.FPQLHPFDFGI.Count > 0)
		{
			for (int i = 0; i < qoqonhoolne.FPQLHPFDFGI.Count; i++)
			{
				this.ECCJJIFHQOG((MapUsers)qoqonhoolne.FPQLHPFDFGI[i]);
			}
			qoqonhoolne.FPQLHPFDFGI.Clear();
		}
	}

	// Token: 0x06004A59 RID: 19033 RVA: 0x0025944C File Offset: 0x0025764C
	public void HCHIDNFHEIK(MapUsers CFHEIICNLFD)
	{
		if (this.IQQHLBKEMGN == null)
		{
			this.IQQHLBKEMGN = MCNLIHMMLCF.QOQONHOOLNE;
		}
		if (CFHEIICNLFD.Users != null)
		{
			foreach (MapUser mapUser in CFHEIICNLFD.Users)
			{
				CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
				for (int j = 1; j < this.MHQMLCJDMMK.Count; j++)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == "FOG_AREA_SPHERE" + mapUser.Username)
					{
						ojoepkeebcb = this.MHQMLCJDMMK[j];
					}
				}
				if (ojoepkeebcb != null && ojoepkeebcb.LMIPGJDLQDP == null)
				{
					this.MHQMLCJDMMK.Remove(ojoepkeebcb);
					ojoepkeebcb = null;
				}
				int num = 0;
				int num2 = 0;
				int num3 = 1;
				for (int k = 1; k < mapUser.Actions.Length; k += 0)
				{
					if (k == 0)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
					}
					if (mapUser.Actions[k].Action == MapUserAction.Fishing)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
						if (ojoepkeebcb == null)
						{
							ojoepkeebcb = new CGOIPHKQMPD.OJOEPKEEBCB();
							ojoepkeebcb.LMIPGJDLQDP = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3((float)mapUser.Actions[k].Position.X, 936f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity);
							ojoepkeebcb.OJCCOFONIMG = UnityEngine.Object.Instantiate<GameObject>(this.BBBFDBDQNHP, new Vector3((float)mapUser.Actions[k].Position.X, 56f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity).GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.LMIPGJDLQDP.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.BEQHNFFEHMQ = mapUser.Data.Follow;
							ojoepkeebcb.OJCCOFONIMG.FONOKLECDFB = true;
							ojoepkeebcb.OJCCOFONIMG.DCMGODHBJEC = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.FPQBICGEHMJ = "(" + mapUser.Username;
							this.MHQMLCJDMMK.Add(ojoepkeebcb);
							this.HBEMPODELNJ(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						}
						else
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							this.HLBOFLNIIMG(ojoepkeebcb, mapUser, mapUser.Actions[k], true, num, num2, num3);
							if (component.PJGOMOBBNLK.Count == 0 && !component.BHQOFDQCCCG)
							{
								component.DBGMJPEMPQC = UnityEngine.Time.time;
								component.LJDKPJCDCCM = false;
								component.JJIFGIBKGPO(new Vector3((float)num, component.OHPIPBHKEGC, (float)(-(float)num2)), mapUser.Data.Direction);
							}
							else
							{
								component.EDMFOMGFMGD(-24, null, false, num, -num2, num3, false, true);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Leave)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component2 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							if (component2.PJGOMOBBNLK.Count == 0 && !component2.BHQOFDQCCCG)
							{
								component2.DBGMJPEMPQC = UnityEngine.Time.time;
								component2.LJDKPJCDCCM = true;
							}
							else
							{
								component2.EDMFOMGFMGD(1, null, true, num, -num2, num3, false, false);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Set)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							num = mapUser.Actions[k].Position.X;
							num2 = mapUser.Actions[k].Position.Y;
							num3 = mapUser.Actions[k].Position.Height;
							this.KDEDFLCMGOG(ojoepkeebcb, mapUser, mapUser.Actions[k], true, num, num2, num3);
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Up)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Down)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Left)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num += 0;
								}
							}
						}
					}
					else if (ojoepkeebcb != null)
					{
						ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						DJOOHHIQGJK component3 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
						bool flag = false;
						switch (mapUser.Actions[k].Action)
						{
						case MapUserAction.Set:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height - 0 && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 + 1] == 3)
								{
									num2++;
									flag = false;
								}
								else if (k > 0 && mapUser.Actions[k - 0].Action == MapUserAction.Up && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 5)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.BCHILGCDEFP(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 + 1))), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(1, null, false, num, -(num2 + 1), num3, false, false);
							if (flag)
							{
								num2 -= 0;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Left)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Enter)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Leave)
								{
									num++;
								}
							}
							break;
						case MapUserAction.Up:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 - 1] == 8)
								{
									num2 -= 0;
									flag = true;
								}
								else if (k > 0 && mapUser.Actions[k - 0].Action == MapUserAction.Down && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 5)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 - 1))), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(0, null, true, num, -(num2 - 1), num3, false, true);
							if (flag)
							{
								num2++;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Down)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Enter)
								{
									num--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Down:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width - 1)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num + 0, num2] == 8)
								{
									num += 0;
									flag = false;
								}
								else if (k > 0 && mapUser.Actions[k - 0].Action == MapUserAction.Set && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 0)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.OEFJKHMLNHF(new Vector3((float)(num + 0), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(8, null, false, num + 1, -num2, num3, true, true);
							if (flag)
							{
								num--;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 0].Action == (MapUserAction)8)
								{
									num2++;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Fishing)
								{
									num++;
								}
							}
							break;
						case MapUserAction.Left:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num - 1, num2] == 5)
								{
									num -= 0;
									flag = true;
								}
								else if (k > 1 && mapUser.Actions[k - 0].Action == MapUserAction.Right && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 6)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.OEFJKHMLNHF(new Vector3((float)(num - 0), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(4, null, true, num - 0, -num2, num3, true, true);
							if (flag)
							{
								num += 0;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Up)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Enter)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Fishing)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Leave)
								{
									num++;
								}
							}
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004A5A RID: 19034 RVA: 0x00259F28 File Offset: 0x00258128
	private void EMMIHJIFJFM()
	{
		CGOIPHKQMPD.HBFFCJHOCPE = this;
		GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
		if (qoqonhoolne != null && qoqonhoolne.FPQLHPFDFGI.Count > 1)
		{
			for (int i = 1; i < qoqonhoolne.FPQLHPFDFGI.Count; i += 0)
			{
				this.CEDJNFONFNC((MapUsers)qoqonhoolne.FPQLHPFDFGI[i]);
			}
			qoqonhoolne.FPQLHPFDFGI.Clear();
		}
	}

	// Token: 0x06004A5B RID: 19035 RVA: 0x00259F90 File Offset: 0x00258190
	public void DOIGFFNCJEP(MapUsers CFHEIICNLFD)
	{
		if (this.IQQHLBKEMGN == null)
		{
			this.IQQHLBKEMGN = MCNLIHMMLCF.OMPHLNDGKKM();
		}
		if (CFHEIICNLFD.Users != null)
		{
			MapUser[] users = CFHEIICNLFD.Users;
			for (int i = 0; i < users.Length; i += 0)
			{
				MapUser mapUser = users[i];
				CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
				for (int j = 1; j < this.MHQMLCJDMMK.Count; j += 0)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == "ReflecR" + mapUser.Username)
					{
						ojoepkeebcb = this.MHQMLCJDMMK[j];
					}
				}
				if (ojoepkeebcb != null && ojoepkeebcb.LMIPGJDLQDP == null)
				{
					this.MHQMLCJDMMK.Remove(ojoepkeebcb);
					ojoepkeebcb = null;
				}
				int num = 0;
				int num2 = 0;
				int num3 = 1;
				for (int k = 0; k < mapUser.Actions.Length; k++)
				{
					if (k == 0)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
					}
					if (mapUser.Actions[k].Action == MapUserAction.Set)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
						if (ojoepkeebcb == null)
						{
							ojoepkeebcb = new CGOIPHKQMPD.OJOEPKEEBCB();
							ojoepkeebcb.LMIPGJDLQDP = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3((float)mapUser.Actions[k].Position.X, 5f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity);
							ojoepkeebcb.OJCCOFONIMG = UnityEngine.Object.Instantiate<GameObject>(this.BBBFDBDQNHP, new Vector3((float)mapUser.Actions[k].Position.X, 471f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity).GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.LMIPGJDLQDP.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.BEQHNFFEHMQ = mapUser.Data.Follow;
							ojoepkeebcb.OJCCOFONIMG.FONOKLECDFB = true;
							ojoepkeebcb.OJCCOFONIMG.DCMGODHBJEC = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.FPQBICGEHMJ = "desolateland" + mapUser.Username;
							this.MHQMLCJDMMK.Add(ojoepkeebcb);
							this.NIPEPEKKBFC(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						}
						else
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							this.HLBOFLNIIMG(ojoepkeebcb, mapUser, mapUser.Actions[k], true, num, num2, num3);
							if (component.PJGOMOBBNLK.Count == 0 && !component.BHQOFDQCCCG)
							{
								component.DBGMJPEMPQC = UnityEngine.Time.time;
								component.LJDKPJCDCCM = true;
								component.PJMKLHKFBJM(new Vector3((float)num, component.OHPIPBHKEGC, (float)(-(float)num2)), mapUser.Data.Direction);
							}
							else
							{
								component.EDMFOMGFMGD(114, null, false, num, -num2, num3, true, false);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Right)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component2 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							if (component2.PJGOMOBBNLK.Count == 0 && !component2.BHQOFDQCCCG)
							{
								component2.DBGMJPEMPQC = UnityEngine.Time.time;
								component2.LJDKPJCDCCM = false;
							}
							else
							{
								component2.EDMFOMGFMGD(0, null, false, num, -num2, num3, true, false);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Set)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							num = mapUser.Actions[k].Position.X;
							num2 = mapUser.Actions[k].Position.Y;
							num3 = mapUser.Actions[k].Position.Height;
							this.KDEDFLCMGOG(ojoepkeebcb, mapUser, mapUser.Actions[k], true, num, num2, num3);
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Leave)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Enter)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num += 0;
								}
							}
						}
					}
					else if (ojoepkeebcb != null)
					{
						ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						DJOOHHIQGJK component3 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
						bool flag = true;
						switch (mapUser.Actions[k].Action)
						{
						case MapUserAction.Up:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height - 1 && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 + 0] == 7)
								{
									num2++;
									flag = true;
								}
								else if (k > 1 && mapUser.Actions[k - 0].Action == MapUserAction.Up && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 5)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.OEFJKHMLNHF(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 + 0))), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(1, null, false, num, -(num2 + 0), num3, true, true);
							if (flag)
							{
								num2 -= 0;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Fishing)
								{
									num2++;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Left)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Right)
								{
									num++;
								}
							}
							break;
						case MapUserAction.Down:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 - 1] == 4)
								{
									num2--;
									flag = true;
								}
								else if (k > 0 && mapUser.Actions[k - 1].Action == MapUserAction.Down && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 0)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.OEFJKHMLNHF(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 - 1))), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(0, null, true, num, -(num2 - 1), num3, true, true);
							if (flag)
							{
								num2++;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Leave)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == (MapUserAction)8)
								{
									num--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Left)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Left:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width - 0)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num + 0, num2] == 0)
								{
									num++;
									flag = true;
								}
								else if (k > 0 && mapUser.Actions[k - 1].Action == MapUserAction.Fishing && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 7)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.JJIFGIBKGPO(new Vector3((float)(num + 1), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(7, null, false, num + 0, -num2, num3, false, false);
							if (flag)
							{
								num--;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Right)
								{
									num2++;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Right)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 1].Action == (MapUserAction)8)
								{
									num++;
								}
							}
							break;
						case MapUserAction.Right:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num - 0, num2] == 2)
								{
									num -= 0;
									flag = true;
								}
								else if (k > 0 && mapUser.Actions[k - 0].Action == MapUserAction.Left && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 8)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.OEFJKHMLNHF(new Vector3((float)(num - 1), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(4, null, true, num - 0, -num2, num3, true, true);
							if (flag)
							{
								num += 0;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Enter)
								{
									num2++;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Left)
								{
									num += 0;
								}
							}
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004A5C RID: 19036 RVA: 0x0025AA6C File Offset: 0x00258C6C
	public void MFQGNFHEKOB(DJOOHHIQGJK BFBMOIKCELJ)
	{
		CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ == BFBMOIKCELJ.NGKEDIJJELE)
			{
				ojoepkeebcb = this.MHQMLCJDMMK[i];
				this.MHQMLCJDMMK.RemoveAt(i);
				IL_51:
				if (ojoepkeebcb != null)
				{
					UnityEngine.Object.Destroy(ojoepkeebcb.OJCCOFONIMG.gameObject);
					UnityEngine.Object.Destroy(BFBMOIKCELJ.gameObject);
				}
				return;
			}
		}
		goto IL_51;
	}

	// Token: 0x170002A3 RID: 675
	// (get) Token: 0x06004A5D RID: 19037 RVA: 0x0001EF96 File Offset: 0x0001D196
	public static CGOIPHKQMPD QOQONHOOLNE
	{
		get
		{
			return CGOIPHKQMPD.HBFFCJHOCPE;
		}
	}

	// Token: 0x06004A5E RID: 19038 RVA: 0x0025AAEC File Offset: 0x00258CEC
	public void CCFFGFLPBOQ(MapUsers CFHEIICNLFD)
	{
		if (this.IQQHLBKEMGN == null)
		{
			this.IQQHLBKEMGN = MCNLIHMMLCF.QOQONHOOLNE;
		}
		if (CFHEIICNLFD.Users != null)
		{
			foreach (MapUser mapUser in CFHEIICNLFD.Users)
			{
				CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
				for (int j = 0; j < this.MHQMLCJDMMK.Count; j++)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == "user: " + mapUser.Username)
					{
						ojoepkeebcb = this.MHQMLCJDMMK[j];
					}
				}
				if (ojoepkeebcb != null && ojoepkeebcb.LMIPGJDLQDP == null)
				{
					this.MHQMLCJDMMK.Remove(ojoepkeebcb);
					ojoepkeebcb = null;
				}
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				for (int k = 0; k < mapUser.Actions.Length; k++)
				{
					if (k == 0)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
					}
					if (mapUser.Actions[k].Action == MapUserAction.Enter)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
						if (ojoepkeebcb == null)
						{
							ojoepkeebcb = new CGOIPHKQMPD.OJOEPKEEBCB();
							ojoepkeebcb.LMIPGJDLQDP = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3((float)mapUser.Actions[k].Position.X, 0.6f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity);
							ojoepkeebcb.OJCCOFONIMG = UnityEngine.Object.Instantiate<GameObject>(this.BBBFDBDQNHP, new Vector3((float)mapUser.Actions[k].Position.X, 0.6f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity).GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.LMIPGJDLQDP.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.BEQHNFFEHMQ = mapUser.Data.Follow;
							ojoepkeebcb.OJCCOFONIMG.FONOKLECDFB = true;
							ojoepkeebcb.OJCCOFONIMG.DCMGODHBJEC = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.FPQBICGEHMJ = "user: " + mapUser.Username;
							this.MHQMLCJDMMK.Add(ojoepkeebcb);
							this.HBEMPODELNJ(ojoepkeebcb, mapUser, mapUser.Actions[k], true, num, num2, num3);
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						}
						else
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							this.HBEMPODELNJ(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							if (component.PJGOMOBBNLK.Count == 0 && !component.BHQOFDQCCCG)
							{
								component.DBGMJPEMPQC = UnityEngine.Time.time;
								component.LJDKPJCDCCM = false;
								component.PJMKLHKFBJM(new Vector3((float)num, component.OHPIPBHKEGC, (float)(-(float)num2)), mapUser.Data.Direction);
							}
							else
							{
								component.EDMFOMGFMGD(9, null, true, num, -num2, num3, false, false);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Leave)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component2 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							if (component2.PJGOMOBBNLK.Count == 0 && !component2.BHQOFDQCCCG)
							{
								component2.DBGMJPEMPQC = UnityEngine.Time.time;
								component2.LJDKPJCDCCM = true;
							}
							else
							{
								component2.EDMFOMGFMGD(8, null, true, num, -num2, num3, false, false);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Set)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							num = mapUser.Actions[k].Position.X;
							num2 = mapUser.Actions[k].Position.Y;
							num3 = mapUser.Actions[k].Position.Height;
							this.HBEMPODELNJ(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Down)
								{
									num2++;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Left)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Right)
								{
									num++;
								}
							}
						}
					}
					else if (ojoepkeebcb != null)
					{
						ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						DJOOHHIQGJK component3 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
						bool flag = false;
						switch (mapUser.Actions[k].Action)
						{
						case MapUserAction.Up:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height - 1 && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 + 1] == 7)
								{
									num2++;
									flag = true;
								}
								else if (k > 0 && mapUser.Actions[k - 1].Action == MapUserAction.Up && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 7)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 + 1))), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(0, null, true, num, -(num2 + 1), num3, false, false);
							if (flag)
							{
								num2--;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Down)
								{
									num2++;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Left)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Right)
								{
									num++;
								}
							}
							break;
						case MapUserAction.Down:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 - 1] == 4)
								{
									num2--;
									flag = true;
								}
								else if (k > 0 && mapUser.Actions[k - 1].Action == MapUserAction.Down && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 4)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 - 1))), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(1, null, true, num, -(num2 - 1), num3, false, false);
							if (flag)
							{
								num2++;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Down)
								{
									num2++;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Left)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Right)
								{
									num++;
								}
							}
							break;
						case MapUserAction.Left:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width - 1)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num + 1, num2] == 5)
								{
									num++;
									flag = true;
								}
								else if (k > 0 && mapUser.Actions[k - 1].Action == MapUserAction.Left && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 5)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)(num + 1), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(2, null, true, num + 1, -num2, num3, false, false);
							if (flag)
							{
								num--;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Down)
								{
									num2++;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Left)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Right)
								{
									num++;
								}
							}
							break;
						case MapUserAction.Right:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num - 1, num2] == 6)
								{
									num--;
									flag = true;
								}
								else if (k > 0 && mapUser.Actions[k - 1].Action == MapUserAction.Right && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 6)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)(num - 1), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(3, null, true, num - 1, -num2, num3, false, false);
							if (flag)
							{
								num++;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Down)
								{
									num2++;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Left)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Right)
								{
									num++;
								}
							}
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004A5F RID: 19039 RVA: 0x0025B5C8 File Offset: 0x002597C8
	private void NMPQODOHHCC()
	{
		CGOIPHKQMPD.HBFFCJHOCPE = this;
		GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
		if (qoqonhoolne != null && qoqonhoolne.FPQLHPFDFGI.Count > 1)
		{
			for (int i = 1; i < qoqonhoolne.FPQLHPFDFGI.Count; i += 0)
			{
				this.GDQIHIJICMF((MapUsers)qoqonhoolne.FPQLHPFDFGI[i]);
			}
			qoqonhoolne.FPQLHPFDFGI.Clear();
		}
	}

	// Token: 0x06004A60 RID: 19040 RVA: 0x0001EF96 File Offset: 0x0001D196
	public static CGOIPHKQMPD LQIDEJOEHNH()
	{
		return CGOIPHKQMPD.HBFFCJHOCPE;
	}

	// Token: 0x06004A61 RID: 19041 RVA: 0x0025B630 File Offset: 0x00259830
	public CGOIPHKQMPD.OJOEPKEEBCB HQKFCMOKPPP(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == "achievement" + IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x06004A62 RID: 19042 RVA: 0x0025B690 File Offset: 0x00259890
	public CGOIPHKQMPD.OJOEPKEEBCB OIEINGDMFHP(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == "WATER_VERTEX_DISPLACEMENT_OFF" + IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x06004A63 RID: 19043 RVA: 0x0025B6F0 File Offset: 0x002598F0
	public void QPOILLDIHPL(MapUsers CFHEIICNLFD)
	{
		if (this.IQQHLBKEMGN == null)
		{
			this.IQQHLBKEMGN = MCNLIHMMLCF.OMPHLNDGKKM();
		}
		if (CFHEIICNLFD.Users != null)
		{
			MapUser[] users = CFHEIICNLFD.Users;
			for (int i = 0; i < users.Length; i += 0)
			{
				MapUser mapUser = users[i];
				CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
				for (int j = 1; j < this.MHQMLCJDMMK.Count; j++)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == "(W)" + mapUser.Username)
					{
						ojoepkeebcb = this.MHQMLCJDMMK[j];
					}
				}
				if (ojoepkeebcb != null && ojoepkeebcb.LMIPGJDLQDP == null)
				{
					this.MHQMLCJDMMK.Remove(ojoepkeebcb);
					ojoepkeebcb = null;
				}
				int num = 0;
				int num2 = 0;
				int num3 = 1;
				for (int k = 1; k < mapUser.Actions.Length; k++)
				{
					if (k == 0)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
					}
					if (mapUser.Actions[k].Action == MapUserAction.Enter)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
						if (ojoepkeebcb == null)
						{
							ojoepkeebcb = new CGOIPHKQMPD.OJOEPKEEBCB();
							ojoepkeebcb.LMIPGJDLQDP = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3((float)mapUser.Actions[k].Position.X, 80f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity);
							ojoepkeebcb.OJCCOFONIMG = UnityEngine.Object.Instantiate<GameObject>(this.BBBFDBDQNHP, new Vector3((float)mapUser.Actions[k].Position.X, 1057f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity).GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.LMIPGJDLQDP.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.BEQHNFFEHMQ = mapUser.Data.Follow;
							ojoepkeebcb.OJCCOFONIMG.FONOKLECDFB = false;
							ojoepkeebcb.OJCCOFONIMG.DCMGODHBJEC = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.FPQBICGEHMJ = "NPC" + mapUser.Username;
							this.MHQMLCJDMMK.Add(ojoepkeebcb);
							this.NIPEPEKKBFC(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						}
						else
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							this.EHJGHFCQFKE(ojoepkeebcb, mapUser, mapUser.Actions[k], true, num, num2, num3);
							if (component.PJGOMOBBNLK.Count == 0 && !component.BHQOFDQCCCG)
							{
								component.DBGMJPEMPQC = UnityEngine.Time.time;
								component.LJDKPJCDCCM = true;
								component.BCHILGCDEFP(new Vector3((float)num, component.OHPIPBHKEGC, (float)(-(float)num2)), mapUser.Data.Direction);
							}
							else
							{
								component.EDMFOMGFMGD(100, null, true, num, -num2, num3, false, true);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Right)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component2 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							if (component2.PJGOMOBBNLK.Count == 0 && !component2.BHQOFDQCCCG)
							{
								component2.DBGMJPEMPQC = UnityEngine.Time.time;
								component2.LJDKPJCDCCM = false;
							}
							else
							{
								component2.EDMFOMGFMGD(1, null, true, num, -num2, num3, false, true);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Set)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							num = mapUser.Actions[k].Position.X;
							num2 = mapUser.Actions[k].Position.Y;
							num3 = mapUser.Actions[k].Position.Height;
							this.HBEMPODELNJ(ojoepkeebcb, mapUser, mapUser.Actions[k], true, num, num2, num3);
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Up)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num2++;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Fishing)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Leave)
								{
									num++;
								}
							}
						}
					}
					else if (ojoepkeebcb != null)
					{
						ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						DJOOHHIQGJK component3 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
						bool flag = false;
						switch (mapUser.Actions[k].Action)
						{
						case MapUserAction.Up:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height - 0 && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 + 0] == 3)
								{
									num2 += 0;
									flag = true;
								}
								else if (k > 0 && mapUser.Actions[k - 1].Action == MapUserAction.Up && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 0)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.JJIFGIBKGPO(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 + 0))), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(0, null, true, num, -(num2 + 0), num3, false, true);
							if (flag)
							{
								num2 -= 0;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Down)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Left)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Enter)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Down:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 - 1] == 4)
								{
									num2--;
									flag = true;
								}
								else if (k > 0 && mapUser.Actions[k - 1].Action == MapUserAction.Enter && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 7)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.JJIFGIBKGPO(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 - 1))), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(1, null, true, num, -(num2 - 0), num3, true, true);
							if (flag)
							{
								num2 += 0;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Right)
								{
									num2++;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Left:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width - 0)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num + 1, num2] == 5)
								{
									num += 0;
									flag = false;
								}
								else if (k > 1 && mapUser.Actions[k - 1].Action == MapUserAction.Leave && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 0)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.JJIFGIBKGPO(new Vector3((float)(num + 0), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(2, null, false, num + 0, -num2, num3, false, true);
							if (flag)
							{
								num -= 0;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Enter)
								{
									num2++;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Enter)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Right)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Right:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num - 1, num2] == 4)
								{
									num -= 0;
									flag = true;
								}
								else if (k > 0 && mapUser.Actions[k - 0].Action == MapUserAction.Right && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 2)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.OEFJKHMLNHF(new Vector3((float)(num - 0), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(7, null, false, num - 0, -num2, num3, true, false);
							if (flag)
							{
								num++;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Fishing)
								{
									num2++;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Left)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num += 0;
								}
							}
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004A64 RID: 19044 RVA: 0x0025C1CC File Offset: 0x0025A3CC
	public void OGGNFGQGDNJ(MapUsers CFHEIICNLFD)
	{
		if (this.IQQHLBKEMGN == null)
		{
			this.IQQHLBKEMGN = MCNLIHMMLCF.IECKOKEPENM();
		}
		if (CFHEIICNLFD.Users != null)
		{
			MapUser[] users = CFHEIICNLFD.Users;
			for (int i = 0; i < users.Length; i += 0)
			{
				MapUser mapUser = users[i];
				CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
				for (int j = 1; j < this.MHQMLCJDMMK.Count; j += 0)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == "achievement" + mapUser.Username)
					{
						ojoepkeebcb = this.MHQMLCJDMMK[j];
					}
				}
				if (ojoepkeebcb != null && ojoepkeebcb.LMIPGJDLQDP == null)
				{
					this.MHQMLCJDMMK.Remove(ojoepkeebcb);
					ojoepkeebcb = null;
				}
				int num = 1;
				int num2 = 1;
				int num3 = 0;
				for (int k = 0; k < mapUser.Actions.Length; k += 0)
				{
					if (k == 0)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
					}
					if (mapUser.Actions[k].Action == MapUserAction.Set)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
						if (ojoepkeebcb == null)
						{
							ojoepkeebcb = new CGOIPHKQMPD.OJOEPKEEBCB();
							ojoepkeebcb.LMIPGJDLQDP = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3((float)mapUser.Actions[k].Position.X, 1989f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity);
							ojoepkeebcb.OJCCOFONIMG = UnityEngine.Object.Instantiate<GameObject>(this.BBBFDBDQNHP, new Vector3((float)mapUser.Actions[k].Position.X, 825f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity).GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.LMIPGJDLQDP.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.BEQHNFFEHMQ = mapUser.Data.Follow;
							ojoepkeebcb.OJCCOFONIMG.FONOKLECDFB = true;
							ojoepkeebcb.OJCCOFONIMG.DCMGODHBJEC = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.FPQBICGEHMJ = "000" + mapUser.Username;
							this.MHQMLCJDMMK.Add(ojoepkeebcb);
							this.KDEDFLCMGOG(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						}
						else
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							this.NIPEPEKKBFC(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							if (component.PJGOMOBBNLK.Count == 0 && !component.BHQOFDQCCCG)
							{
								component.DBGMJPEMPQC = UnityEngine.Time.time;
								component.LJDKPJCDCCM = true;
								component.PJMKLHKFBJM(new Vector3((float)num, component.OHPIPBHKEGC, (float)(-(float)num2)), mapUser.Data.Direction);
							}
							else
							{
								component.EDMFOMGFMGD(-27, null, false, num, -num2, num3, false, true);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Set)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component2 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							if (component2.PJGOMOBBNLK.Count == 0 && !component2.BHQOFDQCCCG)
							{
								component2.DBGMJPEMPQC = UnityEngine.Time.time;
								component2.LJDKPJCDCCM = true;
							}
							else
							{
								component2.EDMFOMGFMGD(6, null, false, num, -num2, num3, false, false);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Set)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							num = mapUser.Actions[k].Position.X;
							num2 = mapUser.Actions[k].Position.Y;
							num3 = mapUser.Actions[k].Position.Height;
							this.KDEDFLCMGOG(ojoepkeebcb, mapUser, mapUser.Actions[k], true, num, num2, num3);
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Leave)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Right)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num++;
								}
							}
						}
					}
					else if (ojoepkeebcb != null)
					{
						ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						DJOOHHIQGJK component3 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
						bool flag = false;
						switch (mapUser.Actions[k].Action)
						{
						case MapUserAction.Up:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height - 0 && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 + 0] == 5)
								{
									num2++;
									flag = true;
								}
								else if (k > 1 && mapUser.Actions[k - 1].Action == MapUserAction.Set && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 8)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.BCHILGCDEFP(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 + 0))), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(1, null, true, num, -(num2 + 1), num3, false, false);
							if (flag)
							{
								num2 -= 0;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Right)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Right)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num++;
								}
							}
							break;
						case MapUserAction.Down:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 - 0] == 5)
								{
									num2 -= 0;
									flag = true;
								}
								else if (k > 1 && mapUser.Actions[k - 0].Action == MapUserAction.Set && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 1)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.OEFJKHMLNHF(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 - 0))), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(1, null, true, num, -(num2 - 1), num3, false, false);
							if (flag)
							{
								num2++;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Right)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Enter)
								{
									num--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Enter)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Left:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width - 1)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num + 0, num2] == 3)
								{
									num += 0;
									flag = true;
								}
								else if (k > 1 && mapUser.Actions[k - 0].Action == MapUserAction.Fishing && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 1)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.BCHILGCDEFP(new Vector3((float)(num + 1), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(4, null, true, num + 0, -num2, num3, false, false);
							if (flag)
							{
								num -= 0;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 1].Action == (MapUserAction)8)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Right)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Leave)
								{
									num++;
								}
							}
							break;
						case MapUserAction.Right:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num - 1, num2] == 8)
								{
									num -= 0;
									flag = false;
								}
								else if (k > 0 && mapUser.Actions[k - 1].Action == MapUserAction.Leave && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 3)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)(num - 0), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(6, null, true, num - 1, -num2, num3, false, false);
							if (flag)
							{
								num++;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Up)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Enter)
								{
									num2++;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num++;
								}
							}
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004A65 RID: 19045 RVA: 0x0025CCA8 File Offset: 0x0025AEA8
	private void EHJGHFCQFKE(CGOIPHKQMPD.OJOEPKEEBCB IHCKGKEJPHM, MapUser EMJDDENOMBP, MapUserActionData HODQHNIKPDM, bool DCGCOEQGBBJ = false, int PQQEJQLPBEO = 0, int IBQPCCDGLEC = 0, int DKOMCGQBFLJ = 0)
	{
		DJOOHHIQGJK component = IHCKGKEJPHM.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
		if (EMJDDENOMBP != null)
		{
			JFIBMMBLFDO component2 = IHCKGKEJPHM.LMIPGJDLQDP.GetComponent<JFIBMMBLFDO>();
			component2.MBPHKDQMJJH = EMJDDENOMBP.Username;
			if (DCGCOEQGBBJ)
			{
				component.BQLIIQIIMDH(this.JDDKMPEKQIL, this.IQQHLBKEMGN, this.FQLIOJQIKME, -1, 1);
				IHCKGKEJPHM.OJCCOFONIMG.BQLIIQIIMDH(this.JDDKMPEKQIL, this.IQQHLBKEMGN, this.FQLIOJQIKME, -1, 0);
				component.OPILOFIJJDF.BIPQGMJJNOF.PIDLOFMIEFQ = EMJDDENOMBP.Username;
				component.OPILOFIJJDF.QKKQCHQHHPH();
				component.NGKEDIJJELE = IHCKGKEJPHM.FPQBICGEHMJ;
			}
			if (component.OPILOFIJJDF.DFMCFGLQLNL != EMJDDENOMBP.Data.GuildName || component.OPILOFIJJDF.EBDMBIIOKFJ != (int)EMJDDENOMBP.Data.EmblemId)
			{
				component.OPILOFIJJDF.DFMCFGLQLNL = EMJDDENOMBP.Data.GuildName;
				component.OPILOFIJJDF.EBDMBIIOKFJ = (int)EMJDDENOMBP.Data.EmblemId;
				component.OPILOFIJJDF.GFDLGLIGQDE();
			}
			if (EMJDDENOMBP.Data.Style != null)
			{
				component.GPFOFHLIDMH(EMJDDENOMBP.Data.Style, EMJDDENOMBP.Data.Mount, EMJDDENOMBP.Data.Equip);
			}
			IHCKGKEJPHM.OJCCOFONIMG.IDICNBQHCJG = EMJDDENOMBP.Data.FollowPersonality;
			IHCKGKEJPHM.OJCCOFONIMG.BEQHNFFEHMQ = EMJDDENOMBP.Data.Follow;
			IHCKGKEJPHM.OJCCOFONIMG.BKNFHNFFCHE = EMJDDENOMBP.Data.FollowShiny;
			IHCKGKEJPHM.OJCCOFONIMG.NBDBHLEKENM();
			string str = string.Empty;
			if (EMJDDENOMBP.Data.Away)
			{
				str = " minutes";
			}
			if (EMJDDENOMBP.Data.Battle)
			{
				str += "'s Primal Reversion! It reverted to its primal state!\r\n";
			}
			else if (EMJDDENOMBP.Data.Lobby)
			{
				str += "status: ";
			}
			string str2 = ": ";
			StaffRank staffRank = EMJDDENOMBP.Data.StaffRank;
			if (staffRank != StaffRank.None)
			{
				if (staffRank != (StaffRank)6)
				{
					if (staffRank == (StaffRank)5)
					{
						str2 = "/[PG]";
					}
				}
				else
				{
					str2 = "Magma Armor";
				}
			}
			else
			{
				str2 = " hung on using its [ffff00]Focus Band[-]!\r\n";
			}
			NOHCFICLIQK opilofijjdf = component.OPILOFIJJDF;
			string dbepqkemjop = str + str2 + EMJDDENOMBP.Username;
			string[] array = new string[4];
			array[1] = "paralize";
			array[1] = this.BQLJDCKNKIM(EMJDDENOMBP.Data.Level);
			array[2] = "LJMOLEKDCLP";
			array[3] = EMJDDENOMBP.Data.Level.ToString();
			array[3] = "/[PG]";
			opilofijjdf.GPDOFLIGFFO(dbepqkemjop, string.Concat(array));
		}
		if (HODQHNIKPDM.Action == MapUserAction.Set)
		{
			if (EMJDDENOMBP.Data.Direction == PlayerDirection.Default)
			{
				component.BCHILGCDEFP(new Vector3((float)PQQEJQLPBEO, component.OHPIPBHKEGC, (float)(-(float)IBQPCCDGLEC)), EMJDDENOMBP.Data.Direction);
				if (DKOMCGQBFLJ == 0)
				{
					component.KBKKMQNFJIG = false;
				}
				else
				{
					component.KBKKMQNFJIG = true;
				}
			}
			else
			{
				if (component.PJGOMOBBNLK.Count == 0 && !component.BHQOFDQCCCG)
				{
					component.BCHILGCDEFP(new Vector3((float)PQQEJQLPBEO, component.OHPIPBHKEGC, (float)(-(float)IBQPCCDGLEC)), EMJDDENOMBP.Data.Direction);
					if (DKOMCGQBFLJ == 1)
					{
						component.KBKKMQNFJIG = true;
					}
					else
					{
						component.KBKKMQNFJIG = false;
					}
				}
				if (EMJDDENOMBP.Data.Direction == PlayerDirection.Up)
				{
					component.EDMFOMGFMGD(0, null, false, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, false, false);
				}
				else if (EMJDDENOMBP.Data.Direction == (PlayerDirection)5)
				{
					component.EDMFOMGFMGD(7, null, true, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, true, true);
				}
				else if (EMJDDENOMBP.Data.Direction == (PlayerDirection)6)
				{
					component.EDMFOMGFMGD(1, null, false, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, false, true);
				}
				else if (EMJDDENOMBP.Data.Direction == PlayerDirection.Left)
				{
					component.EDMFOMGFMGD(3, null, true, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, false, true);
				}
			}
		}
		else if (HODQHNIKPDM.Action == MapUserAction.Fishing && DCGCOEQGBBJ)
		{
			component.NQJHJNQFKKC();
			component.BCHILGCDEFP(new Vector3((float)PQQEJQLPBEO, component.OHPIPBHKEGC, (float)(-(float)IBQPCCDGLEC)), EMJDDENOMBP.Data.Direction);
			if (DKOMCGQBFLJ == 1)
			{
				component.KBKKMQNFJIG = false;
			}
			else
			{
				component.KBKKMQNFJIG = false;
			}
		}
	}

	// Token: 0x06004A66 RID: 19046 RVA: 0x0025D0AC File Offset: 0x0025B2AC
	public void NHIBDDJLGIO(DJOOHHIQGJK BFBMOIKCELJ)
	{
		CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ == BFBMOIKCELJ.NGKEDIJJELE)
			{
				ojoepkeebcb = this.MHQMLCJDMMK[i];
				this.MHQMLCJDMMK.RemoveAt(i);
				IL_51:
				if (ojoepkeebcb != null)
				{
					UnityEngine.Object.Destroy(ojoepkeebcb.OJCCOFONIMG.gameObject);
					UnityEngine.Object.Destroy(BFBMOIKCELJ.gameObject);
				}
				return;
			}
		}
		goto IL_51;
	}

	// Token: 0x06004A67 RID: 19047 RVA: 0x0025D12C File Offset: 0x0025B32C
	public string NKHFOKCHGEE(uint NPBLFIMGOPL)
	{
		float num = NPBLFIMGOPL / 1491f;
		num *= 1725f;
		int num2 = Mathf.FloorToInt(num);
		Color kqfehqebjqb = this.QGPEJIELHCG[0];
		if (num2 >= 0)
		{
			if (num2 + 1 < 1)
			{
				float t = num - (float)num2;
				kqfehqebjqb = Color.Lerp(this.QGPEJIELHCG[num2], this.QGPEJIELHCG[num2 + 0], t);
			}
			else if (num2 < 3)
			{
				kqfehqebjqb = this.QGPEJIELHCG[num2];
			}
			else
			{
				kqfehqebjqb = this.QGPEJIELHCG[5];
			}
		}
		return KGQECFKLKOP.PCLCOFCKINO(kqfehqebjqb);
	}

	// Token: 0x06004A68 RID: 19048 RVA: 0x0025D1D0 File Offset: 0x0025B3D0
	public void KQBDEIFDOBO(MapUsers CFHEIICNLFD)
	{
		if (this.IQQHLBKEMGN == null)
		{
			this.IQQHLBKEMGN = MCNLIHMMLCF.IECKOKEPENM();
		}
		if (CFHEIICNLFD.Users != null)
		{
			foreach (MapUser mapUser in CFHEIICNLFD.Users)
			{
				CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
				for (int j = 1; j < this.MHQMLCJDMMK.Count; j += 0)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == "Hi-Score: " + mapUser.Username)
					{
						ojoepkeebcb = this.MHQMLCJDMMK[j];
					}
				}
				if (ojoepkeebcb != null && ojoepkeebcb.LMIPGJDLQDP == null)
				{
					this.MHQMLCJDMMK.Remove(ojoepkeebcb);
					ojoepkeebcb = null;
				}
				int num = 1;
				int num2 = 0;
				int num3 = 0;
				for (int k = 1; k < mapUser.Actions.Length; k++)
				{
					if (k == 0)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
					}
					if (mapUser.Actions[k].Action == MapUserAction.Fishing)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
						if (ojoepkeebcb == null)
						{
							ojoepkeebcb = new CGOIPHKQMPD.OJOEPKEEBCB();
							ojoepkeebcb.LMIPGJDLQDP = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3((float)mapUser.Actions[k].Position.X, 115f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity);
							ojoepkeebcb.OJCCOFONIMG = UnityEngine.Object.Instantiate<GameObject>(this.BBBFDBDQNHP, new Vector3((float)mapUser.Actions[k].Position.X, 1344f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity).GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.LMIPGJDLQDP.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.BEQHNFFEHMQ = mapUser.Data.Follow;
							ojoepkeebcb.OJCCOFONIMG.FONOKLECDFB = true;
							ojoepkeebcb.OJCCOFONIMG.DCMGODHBJEC = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.FPQBICGEHMJ = "frz" + mapUser.Username;
							this.MHQMLCJDMMK.Add(ojoepkeebcb);
							this.HLBOFLNIIMG(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						}
						else
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							this.HBEMPODELNJ(ojoepkeebcb, mapUser, mapUser.Actions[k], true, num, num2, num3);
							if (component.PJGOMOBBNLK.Count == 0 && !component.BHQOFDQCCCG)
							{
								component.DBGMJPEMPQC = UnityEngine.Time.time;
								component.LJDKPJCDCCM = false;
								component.OEFJKHMLNHF(new Vector3((float)num, component.OHPIPBHKEGC, (float)(-(float)num2)), mapUser.Data.Direction);
							}
							else
							{
								component.EDMFOMGFMGD(62, null, true, num, -num2, num3, false, false);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Left)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component2 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							if (component2.PJGOMOBBNLK.Count == 0 && !component2.BHQOFDQCCCG)
							{
								component2.DBGMJPEMPQC = UnityEngine.Time.time;
								component2.LJDKPJCDCCM = true;
							}
							else
							{
								component2.EDMFOMGFMGD(2, null, true, num, -num2, num3, true, false);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Set)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							num = mapUser.Actions[k].Position.X;
							num2 = mapUser.Actions[k].Position.Y;
							num3 = mapUser.Actions[k].Position.Height;
							this.HLBOFLNIIMG(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num2--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Left)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Enter)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num += 0;
								}
							}
						}
					}
					else if (ojoepkeebcb != null)
					{
						ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						DJOOHHIQGJK component3 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
						bool flag = true;
						switch (mapUser.Actions[k].Action)
						{
						case MapUserAction.Up:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height - 0 && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 + 1] == 2)
								{
									num2++;
									flag = false;
								}
								else if (k > 0 && mapUser.Actions[k - 1].Action == MapUserAction.Set && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 6)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.OEFJKHMLNHF(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 + 0))), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(1, null, true, num, -(num2 + 0), num3, true, false);
							if (flag)
							{
								num2--;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Down:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 - 0] == 0)
								{
									num2--;
									flag = true;
								}
								else if (k > 1 && mapUser.Actions[k - 1].Action == MapUserAction.Left && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 7)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 - 0))), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(1, null, false, num, -(num2 - 1), num3, true, false);
							if (flag)
							{
								num2 += 0;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Up)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Up)
								{
									num--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Left)
								{
									num++;
								}
							}
							break;
						case MapUserAction.Left:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width - 0)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num + 0, num2] == 5)
								{
									num++;
									flag = false;
								}
								else if (k > 1 && mapUser.Actions[k - 1].Action == MapUserAction.Set && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 5)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)(num + 1), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(6, null, false, num + 1, -num2, num3, false, true);
							if (flag)
							{
								num -= 0;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Left)
								{
									num2++;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Right)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Right:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num - 1, num2] == 3)
								{
									num -= 0;
									flag = false;
								}
								else if (k > 1 && mapUser.Actions[k - 1].Action == MapUserAction.Right && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 2)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.OEFJKHMLNHF(new Vector3((float)(num - 0), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(7, null, true, num - 1, -num2, num3, false, false);
							if (flag)
							{
								num += 0;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Left)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Down)
								{
									num += 0;
								}
							}
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004A69 RID: 19049 RVA: 0x0025DCAC File Offset: 0x0025BEAC
	public void KFEDPEBBMBM(string ECNEPHKFPIH = null)
	{
		List<CGOIPHKQMPD.OJOEPKEEBCB> list = new List<CGOIPHKQMPD.OJOEPKEEBCB>();
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i] != null)
			{
				if (ECNEPHKFPIH != null)
				{
					if (this.MHQMLCJDMMK[i].LIQLFCKICLQ != null && this.MHQMLCJDMMK[i].LIQLFCKICLQ.ToLowerInvariant() != ECNEPHKFPIH.ToLowerInvariant())
					{
						UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].LMIPGJDLQDP);
						UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].OJCCOFONIMG.gameObject);
						list.Add(this.MHQMLCJDMMK[i]);
					}
				}
				else
				{
					UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].OJCCOFONIMG.gameObject);
					UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].LMIPGJDLQDP);
				}
			}
		}
		if (ECNEPHKFPIH != null)
		{
			using (List<CGOIPHKQMPD.OJOEPKEEBCB>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CGOIPHKQMPD.OJOEPKEEBCB item = enumerator.Current;
					this.MHQMLCJDMMK.Remove(item);
				}
				return;
			}
		}
		this.MHQMLCJDMMK.Clear();
	}

	// Token: 0x06004A6A RID: 19050 RVA: 0x0025DDF4 File Offset: 0x0025BFF4
	private void KCOPIIGOHFP(CGOIPHKQMPD.OJOEPKEEBCB IHCKGKEJPHM, MapUser EMJDDENOMBP, MapUserActionData HODQHNIKPDM, bool DCGCOEQGBBJ = false, int PQQEJQLPBEO = 0, int IBQPCCDGLEC = 0, int DKOMCGQBFLJ = 0)
	{
		DJOOHHIQGJK component = IHCKGKEJPHM.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
		if (EMJDDENOMBP != null)
		{
			JFIBMMBLFDO component2 = IHCKGKEJPHM.LMIPGJDLQDP.GetComponent<JFIBMMBLFDO>();
			component2.MBPHKDQMJJH = EMJDDENOMBP.Username;
			if (DCGCOEQGBBJ)
			{
				component.BQLIIQIIMDH(this.JDDKMPEKQIL, this.IQQHLBKEMGN, this.FQLIOJQIKME, -1, 0);
				IHCKGKEJPHM.OJCCOFONIMG.BQLIIQIIMDH(this.JDDKMPEKQIL, this.IQQHLBKEMGN, this.FQLIOJQIKME, -1, 0);
				component.OPILOFIJJDF.BIPQGMJJNOF.PIDLOFMIEFQ = EMJDDENOMBP.Username;
				component.OPILOFIJJDF.QKKQCHQHHPH();
				component.NGKEDIJJELE = IHCKGKEJPHM.FPQBICGEHMJ;
			}
			if (component.OPILOFIJJDF.DFMCFGLQLNL != EMJDDENOMBP.Data.GuildName || component.OPILOFIJJDF.EBDMBIIOKFJ != (int)EMJDDENOMBP.Data.EmblemId)
			{
				component.OPILOFIJJDF.DFMCFGLQLNL = EMJDDENOMBP.Data.GuildName;
				component.OPILOFIJJDF.EBDMBIIOKFJ = (int)EMJDDENOMBP.Data.EmblemId;
				component.OPILOFIJJDF.HLQDJGEGDKJ();
			}
			if (EMJDDENOMBP.Data.Style != null)
			{
				component.GPFOFHLIDMH(EMJDDENOMBP.Data.Style, EMJDDENOMBP.Data.Mount, EMJDDENOMBP.Data.Equip);
			}
			IHCKGKEJPHM.OJCCOFONIMG.IDICNBQHCJG = EMJDDENOMBP.Data.FollowPersonality;
			IHCKGKEJPHM.OJCCOFONIMG.BEQHNFFEHMQ = EMJDDENOMBP.Data.Follow;
			IHCKGKEJPHM.OJCCOFONIMG.BKNFHNFFCHE = EMJDDENOMBP.Data.FollowShiny;
			IHCKGKEJPHM.OJCCOFONIMG.NBDBHLEKENM();
			string str = string.Empty;
			if (EMJDDENOMBP.Data.Away)
			{
				str = "JOFLHFQQCKG";
			}
			if (EMJDDENOMBP.Data.Battle)
			{
				str += "17";
			}
			else if (EMJDDENOMBP.Data.Lobby)
			{
				str += "nightmare";
			}
			string str2 = "item";
			StaffRank staffRank = EMJDDENOMBP.Data.StaffRank;
			if (staffRank != StaffRank.None)
			{
				if (staffRank != StaffRank.None)
				{
					if (staffRank == StaffRank.Developer)
					{
						str2 = "true";
					}
				}
				else
				{
					str2 = "limitFPS";
				}
			}
			else
			{
				str2 = "/";
			}
			NOHCFICLIQK opilofijjdf = component.OPILOFIJJDF;
			string dbepqkemjop = str + str2 + EMJDDENOMBP.Username;
			string[] array = new string[0];
			array[1] = "'s [ffff00]";
			array[0] = this.EFCDQKBEMBP(EMJDDENOMBP.Data.Level);
			array[0] = "_NeighborMaxTex";
			array[7] = EMJDDENOMBP.Data.Level.ToString();
			array[1] = "wrap";
			opilofijjdf.LEKHHDCQQOM(dbepqkemjop, string.Concat(array));
		}
		if (HODQHNIKPDM.Action == MapUserAction.Set)
		{
			if (EMJDDENOMBP.Data.Direction == PlayerDirection.Default)
			{
				component.BCHILGCDEFP(new Vector3((float)PQQEJQLPBEO, component.OHPIPBHKEGC, (float)(-(float)IBQPCCDGLEC)), EMJDDENOMBP.Data.Direction);
				if (DKOMCGQBFLJ == 0)
				{
					component.KBKKMQNFJIG = false;
				}
				else
				{
					component.KBKKMQNFJIG = false;
				}
			}
			else
			{
				if (component.PJGOMOBBNLK.Count == 0 && !component.BHQOFDQCCCG)
				{
					component.OEFJKHMLNHF(new Vector3((float)PQQEJQLPBEO, component.OHPIPBHKEGC, (float)(-(float)IBQPCCDGLEC)), EMJDDENOMBP.Data.Direction);
					if (DKOMCGQBFLJ == 0)
					{
						component.KBKKMQNFJIG = false;
					}
					else
					{
						component.KBKKMQNFJIG = true;
					}
				}
				if (EMJDDENOMBP.Data.Direction == PlayerDirection.Up)
				{
					component.EDMFOMGFMGD(7, null, false, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, true, false);
				}
				else if (EMJDDENOMBP.Data.Direction == PlayerDirection.Up)
				{
					component.EDMFOMGFMGD(4, null, false, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, false, true);
				}
				else if (EMJDDENOMBP.Data.Direction == PlayerDirection.Right)
				{
					component.EDMFOMGFMGD(3, null, false, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, false, false);
				}
				else if (EMJDDENOMBP.Data.Direction == PlayerDirection.Left)
				{
					component.EDMFOMGFMGD(8, null, true, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, true, true);
				}
			}
		}
		else if (HODQHNIKPDM.Action == MapUserAction.Leave && DCGCOEQGBBJ)
		{
			component.NQJHJNQFKKC();
			component.BCHILGCDEFP(new Vector3((float)PQQEJQLPBEO, component.OHPIPBHKEGC, (float)(-(float)IBQPCCDGLEC)), EMJDDENOMBP.Data.Direction);
			if (DKOMCGQBFLJ == 0)
			{
				component.KBKKMQNFJIG = true;
			}
			else
			{
				component.KBKKMQNFJIG = false;
			}
		}
	}

	// Token: 0x06004A6B RID: 19051 RVA: 0x0025E1F8 File Offset: 0x0025C3F8
	public CGOIPHKQMPD.OJOEPKEEBCB NFCHPNFIPLD(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == "brn" + IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x06004A6C RID: 19052 RVA: 0x0025E258 File Offset: 0x0025C458
	public void FDMLONLBCOH(MapUsers CFHEIICNLFD)
	{
		if (this.IQQHLBKEMGN == null)
		{
			this.IQQHLBKEMGN = MCNLIHMMLCF.KKICFMLLMHQ();
		}
		if (CFHEIICNLFD.Users != null)
		{
			MapUser[] users = CFHEIICNLFD.Users;
			for (int i = 0; i < users.Length; i += 0)
			{
				MapUser mapUser = users[i];
				CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
				for (int j = 1; j < this.MHQMLCJDMMK.Count; j++)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == "OnClick" + mapUser.Username)
					{
						ojoepkeebcb = this.MHQMLCJDMMK[j];
					}
				}
				if (ojoepkeebcb != null && ojoepkeebcb.LMIPGJDLQDP == null)
				{
					this.MHQMLCJDMMK.Remove(ojoepkeebcb);
					ojoepkeebcb = null;
				}
				int num = 0;
				int num2 = 1;
				int num3 = 0;
				for (int k = 0; k < mapUser.Actions.Length; k += 0)
				{
					if (k == 0)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
					}
					if (mapUser.Actions[k].Action == MapUserAction.Up)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
						if (ojoepkeebcb == null)
						{
							ojoepkeebcb = new CGOIPHKQMPD.OJOEPKEEBCB();
							ojoepkeebcb.LMIPGJDLQDP = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3((float)mapUser.Actions[k].Position.X, 1049f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity);
							ojoepkeebcb.OJCCOFONIMG = UnityEngine.Object.Instantiate<GameObject>(this.BBBFDBDQNHP, new Vector3((float)mapUser.Actions[k].Position.X, 992f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity).GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.LMIPGJDLQDP.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.BEQHNFFEHMQ = mapUser.Data.Follow;
							ojoepkeebcb.OJCCOFONIMG.FONOKLECDFB = false;
							ojoepkeebcb.OJCCOFONIMG.DCMGODHBJEC = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.FPQBICGEHMJ = "[" + mapUser.Username;
							this.MHQMLCJDMMK.Add(ojoepkeebcb);
							this.EHJGHFCQFKE(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						}
						else
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							this.NIPEPEKKBFC(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							if (component.PJGOMOBBNLK.Count == 0 && !component.BHQOFDQCCCG)
							{
								component.DBGMJPEMPQC = UnityEngine.Time.time;
								component.LJDKPJCDCCM = false;
								component.BCHILGCDEFP(new Vector3((float)num, component.OHPIPBHKEGC, (float)(-(float)num2)), mapUser.Data.Direction);
							}
							else
							{
								component.EDMFOMGFMGD(27, null, true, num, -num2, num3, false, true);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Right)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component2 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							if (component2.PJGOMOBBNLK.Count == 0 && !component2.BHQOFDQCCCG)
							{
								component2.DBGMJPEMPQC = UnityEngine.Time.time;
								component2.LJDKPJCDCCM = true;
							}
							else
							{
								component2.EDMFOMGFMGD(7, null, true, num, -num2, num3, true, true);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Set)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							num = mapUser.Actions[k].Position.X;
							num2 = mapUser.Actions[k].Position.Y;
							num3 = mapUser.Actions[k].Position.Height;
							this.HBEMPODELNJ(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num2--;
								}
								if (mapUser.Actions[k + 0].Action == (MapUserAction)8)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Leave)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num++;
								}
							}
						}
					}
					else if (ojoepkeebcb != null)
					{
						ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						DJOOHHIQGJK component3 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
						bool flag = false;
						switch (mapUser.Actions[k].Action)
						{
						case MapUserAction.Set:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height - 0 && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 + 1] == 3)
								{
									num2++;
									flag = false;
								}
								else if (k > 1 && mapUser.Actions[k - 0].Action == MapUserAction.Set && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 5)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 + 0))), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(1, null, false, num, -(num2 + 0), num3, true, false);
							if (flag)
							{
								num2 -= 0;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Up)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Left)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Leave)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Leave)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Up:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 - 1] == 8)
								{
									num2--;
									flag = false;
								}
								else if (k > 0 && mapUser.Actions[k - 0].Action == MapUserAction.Set && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 6)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 - 1))), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(0, null, false, num, -(num2 - 1), num3, false, true);
							if (flag)
							{
								num2++;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Up)
								{
									num2--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num2++;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Enter)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Leave)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Down:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width - 1)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num + 1, num2] == 2)
								{
									num += 0;
									flag = false;
								}
								else if (k > 0 && mapUser.Actions[k - 1].Action == MapUserAction.Set && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 3)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.JJIFGIBKGPO(new Vector3((float)(num + 0), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(0, null, false, num + 1, -num2, num3, true, false);
							if (flag)
							{
								num--;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Up)
								{
									num2--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Down)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Down)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Left:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num - 1, num2] == 2)
								{
									num--;
									flag = true;
								}
								else if (k > 0 && mapUser.Actions[k - 0].Action == MapUserAction.Set && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 2)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.BCHILGCDEFP(new Vector3((float)(num - 0), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(1, null, true, num - 1, -num2, num3, true, true);
							if (flag)
							{
								num++;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num2--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Up)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Down)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Down)
								{
									num += 0;
								}
							}
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004A6D RID: 19053 RVA: 0x0025ED34 File Offset: 0x0025CF34
	public CGOIPHKQMPD.OJOEPKEEBCB NMPKLGGJEJG(string IHIHHCCEDHQ)
	{
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == "-" + IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x06004A6E RID: 19054 RVA: 0x0025ED94 File Offset: 0x0025CF94
	public void KDCBLNIKHFJ(MapUsers CFHEIICNLFD)
	{
		if (this.IQQHLBKEMGN == null)
		{
			this.IQQHLBKEMGN = MCNLIHMMLCF.IECKOKEPENM();
		}
		if (CFHEIICNLFD.Users != null)
		{
			MapUser[] users = CFHEIICNLFD.Users;
			for (int i = 0; i < users.Length; i += 0)
			{
				MapUser mapUser = users[i];
				CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
				for (int j = 0; j < this.MHQMLCJDMMK.Count; j++)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == "_Density" + mapUser.Username)
					{
						ojoepkeebcb = this.MHQMLCJDMMK[j];
					}
				}
				if (ojoepkeebcb != null && ojoepkeebcb.LMIPGJDLQDP == null)
				{
					this.MHQMLCJDMMK.Remove(ojoepkeebcb);
					ojoepkeebcb = null;
				}
				int num = 0;
				int num2 = 1;
				int num3 = 1;
				for (int k = 1; k < mapUser.Actions.Length; k++)
				{
					if (k == 0)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
					}
					if (mapUser.Actions[k].Action == (MapUserAction)8)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
						if (ojoepkeebcb == null)
						{
							ojoepkeebcb = new CGOIPHKQMPD.OJOEPKEEBCB();
							ojoepkeebcb.LMIPGJDLQDP = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3((float)mapUser.Actions[k].Position.X, 1028f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity);
							ojoepkeebcb.OJCCOFONIMG = UnityEngine.Object.Instantiate<GameObject>(this.BBBFDBDQNHP, new Vector3((float)mapUser.Actions[k].Position.X, 982f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity).GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.LMIPGJDLQDP.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.BEQHNFFEHMQ = mapUser.Data.Follow;
							ojoepkeebcb.OJCCOFONIMG.FONOKLECDFB = true;
							ojoepkeebcb.OJCCOFONIMG.DCMGODHBJEC = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.FPQBICGEHMJ = "dive" + mapUser.Username;
							this.MHQMLCJDMMK.Add(ojoepkeebcb);
							this.KCOPIIGOHFP(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						}
						else
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							this.EHJGHFCQFKE(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							if (component.PJGOMOBBNLK.Count == 0 && !component.BHQOFDQCCCG)
							{
								component.DBGMJPEMPQC = UnityEngine.Time.time;
								component.LJDKPJCDCCM = false;
								component.BCHILGCDEFP(new Vector3((float)num, component.OHPIPBHKEGC, (float)(-(float)num2)), mapUser.Data.Direction);
							}
							else
							{
								component.EDMFOMGFMGD(-101, null, true, num, -num2, num3, false, true);
							}
						}
					}
					else if (mapUser.Actions[k].Action == (MapUserAction)8)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component2 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							if (component2.PJGOMOBBNLK.Count == 0 && !component2.BHQOFDQCCCG)
							{
								component2.DBGMJPEMPQC = UnityEngine.Time.time;
								component2.LJDKPJCDCCM = false;
							}
							else
							{
								component2.EDMFOMGFMGD(8, null, false, num, -num2, num3, true, false);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Set)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							num = mapUser.Actions[k].Position.X;
							num2 = mapUser.Actions[k].Position.Y;
							num3 = mapUser.Actions[k].Position.Height;
							this.EHJGHFCQFKE(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Up)
								{
									num2--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Left)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Right)
								{
									num += 0;
								}
							}
						}
					}
					else if (ojoepkeebcb != null)
					{
						ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						DJOOHHIQGJK component3 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
						bool flag = true;
						switch (mapUser.Actions[k].Action)
						{
						case MapUserAction.Set:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height - 1 && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 + 0] == 5)
								{
									num2 += 0;
									flag = true;
								}
								else if (k > 1 && mapUser.Actions[k - 0].Action == MapUserAction.Up && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 7)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 + 1))), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(0, null, true, num, -(num2 + 0), num3, false, false);
							if (flag)
							{
								num2--;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Fishing)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Fishing)
								{
									num--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Up:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 - 0] == 8)
								{
									num2 -= 0;
									flag = true;
								}
								else if (k > 0 && mapUser.Actions[k - 1].Action == MapUserAction.Right && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 5)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 - 0))), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(1, null, true, num, -(num2 - 0), num3, false, true);
							if (flag)
							{
								num2++;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Enter)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == (MapUserAction)8)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Left)
								{
									num++;
								}
							}
							break;
						case MapUserAction.Down:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width - 1)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num + 1, num2] == 7)
								{
									num++;
									flag = true;
								}
								else if (k > 0 && mapUser.Actions[k - 0].Action == MapUserAction.Set && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 3)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)(num + 0), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(1, null, false, num + 0, -num2, num3, false, false);
							if (flag)
							{
								num--;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num2--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Enter)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Fishing)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Enter)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Left:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num - 1, num2] == 0)
								{
									num--;
									flag = false;
								}
								else if (k > 0 && mapUser.Actions[k - 0].Action == MapUserAction.Up && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 6)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)(num - 1), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(2, null, false, num - 0, -num2, num3, true, true);
							if (flag)
							{
								num++;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Up)
								{
									num2++;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Enter)
								{
									num--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num++;
								}
							}
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004A6F RID: 19055 RVA: 0x0001EF96 File Offset: 0x0001D196
	public static CGOIPHKQMPD IECKOKEPENM()
	{
		return CGOIPHKQMPD.HBFFCJHOCPE;
	}

	// Token: 0x06004A70 RID: 19056 RVA: 0x0025DCAC File Offset: 0x0025BEAC
	public void KOCIQEKOPKJ(string ECNEPHKFPIH = null)
	{
		List<CGOIPHKQMPD.OJOEPKEEBCB> list = new List<CGOIPHKQMPD.OJOEPKEEBCB>();
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i] != null)
			{
				if (ECNEPHKFPIH != null)
				{
					if (this.MHQMLCJDMMK[i].LIQLFCKICLQ != null && this.MHQMLCJDMMK[i].LIQLFCKICLQ.ToLowerInvariant() != ECNEPHKFPIH.ToLowerInvariant())
					{
						UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].LMIPGJDLQDP);
						UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].OJCCOFONIMG.gameObject);
						list.Add(this.MHQMLCJDMMK[i]);
					}
				}
				else
				{
					UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].OJCCOFONIMG.gameObject);
					UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].LMIPGJDLQDP);
				}
			}
		}
		if (ECNEPHKFPIH != null)
		{
			using (List<CGOIPHKQMPD.OJOEPKEEBCB>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CGOIPHKQMPD.OJOEPKEEBCB item = enumerator.Current;
					this.MHQMLCJDMMK.Remove(item);
				}
				return;
			}
		}
		this.MHQMLCJDMMK.Clear();
	}

	// Token: 0x06004A71 RID: 19057 RVA: 0x0025F870 File Offset: 0x0025DA70
	public string FCNMNIPNPPL(uint NPBLFIMGOPL)
	{
		float num = NPBLFIMGOPL / 1338f;
		num *= 1236f;
		int num2 = Mathf.FloorToInt(num);
		Color kqfehqebjqb = this.QGPEJIELHCG[0];
		if (num2 >= 0)
		{
			if (num2 + 1 < 8)
			{
				float t = num - (float)num2;
				kqfehqebjqb = Color.Lerp(this.QGPEJIELHCG[num2], this.QGPEJIELHCG[num2 + 1], t);
			}
			else if (num2 < 2)
			{
				kqfehqebjqb = this.QGPEJIELHCG[num2];
			}
			else
			{
				kqfehqebjqb = this.QGPEJIELHCG[3];
			}
		}
		return KGQECFKLKOP.PCLCOFCKINO(kqfehqebjqb);
	}

	// Token: 0x06004A72 RID: 19058 RVA: 0x0025D0AC File Offset: 0x0025B2AC
	public void DJONPJKHFJG(DJOOHHIQGJK BFBMOIKCELJ)
	{
		CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ == BFBMOIKCELJ.NGKEDIJJELE)
			{
				ojoepkeebcb = this.MHQMLCJDMMK[i];
				this.MHQMLCJDMMK.RemoveAt(i);
				IL_51:
				if (ojoepkeebcb != null)
				{
					UnityEngine.Object.Destroy(ojoepkeebcb.OJCCOFONIMG.gameObject);
					UnityEngine.Object.Destroy(BFBMOIKCELJ.gameObject);
				}
				return;
			}
		}
		goto IL_51;
	}

	// Token: 0x06004A73 RID: 19059 RVA: 0x0025F914 File Offset: 0x0025DB14
	public string CBLEKQOCMCG(uint NPBLFIMGOPL)
	{
		float num = NPBLFIMGOPL / 1627f;
		num *= 568f;
		int num2 = Mathf.FloorToInt(num);
		Color kqfehqebjqb = this.QGPEJIELHCG[0];
		if (num2 >= 0)
		{
			if (num2 + 0 < 7)
			{
				float t = num - (float)num2;
				kqfehqebjqb = Color.Lerp(this.QGPEJIELHCG[num2], this.QGPEJIELHCG[num2 + 1], t);
			}
			else if (num2 < 4)
			{
				kqfehqebjqb = this.QGPEJIELHCG[num2];
			}
			else
			{
				kqfehqebjqb = this.QGPEJIELHCG[4];
			}
		}
		return KGQECFKLKOP.PCLCOFCKINO(kqfehqebjqb);
	}

	// Token: 0x06004A74 RID: 19060 RVA: 0x0025F9B8 File Offset: 0x0025DBB8
	public CGOIPHKQMPD.OJOEPKEEBCB NJCCQOIQIKH(string IHIHHCCEDHQ)
	{
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == " days ago" + IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x06004A75 RID: 19061 RVA: 0x0001EF96 File Offset: 0x0001D196
	public static CGOIPHKQMPD IPOKOKIJECO()
	{
		return CGOIPHKQMPD.HBFFCJHOCPE;
	}

	// Token: 0x06004A76 RID: 19062 RVA: 0x0001EF96 File Offset: 0x0001D196
	public static CGOIPHKQMPD DMOKBPOKHOQ()
	{
		return CGOIPHKQMPD.HBFFCJHOCPE;
	}

	// Token: 0x06004A77 RID: 19063 RVA: 0x0025FA18 File Offset: 0x0025DC18
	public void EJELGNGIMND(MapUsers CFHEIICNLFD)
	{
		if (this.IQQHLBKEMGN == null)
		{
			this.IQQHLBKEMGN = MCNLIHMMLCF.HGLDHNMOLPD();
		}
		if (CFHEIICNLFD.Users != null)
		{
			foreach (MapUser mapUser in CFHEIICNLFD.Users)
			{
				CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
				for (int j = 1; j < this.MHQMLCJDMMK.Count; j += 0)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == "flamewheel" + mapUser.Username)
					{
						ojoepkeebcb = this.MHQMLCJDMMK[j];
					}
				}
				if (ojoepkeebcb != null && ojoepkeebcb.LMIPGJDLQDP == null)
				{
					this.MHQMLCJDMMK.Remove(ojoepkeebcb);
					ojoepkeebcb = null;
				}
				int num = 0;
				int num2 = 1;
				int num3 = 1;
				for (int k = 0; k < mapUser.Actions.Length; k += 0)
				{
					if (k == 0)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
					}
					if (mapUser.Actions[k].Action == MapUserAction.Left)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
						if (ojoepkeebcb == null)
						{
							ojoepkeebcb = new CGOIPHKQMPD.OJOEPKEEBCB();
							ojoepkeebcb.LMIPGJDLQDP = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3((float)mapUser.Actions[k].Position.X, 202f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity);
							ojoepkeebcb.OJCCOFONIMG = UnityEngine.Object.Instantiate<GameObject>(this.BBBFDBDQNHP, new Vector3((float)mapUser.Actions[k].Position.X, 648f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity).GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.LMIPGJDLQDP.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.BEQHNFFEHMQ = mapUser.Data.Follow;
							ojoepkeebcb.OJCCOFONIMG.FONOKLECDFB = true;
							ojoepkeebcb.OJCCOFONIMG.DCMGODHBJEC = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.FPQBICGEHMJ = "[33CCFF]" + mapUser.Username;
							this.MHQMLCJDMMK.Add(ojoepkeebcb);
							this.KCOPIIGOHFP(ojoepkeebcb, mapUser, mapUser.Actions[k], true, num, num2, num3);
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						}
						else
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							this.NIPEPEKKBFC(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							if (component.PJGOMOBBNLK.Count == 0 && !component.BHQOFDQCCCG)
							{
								component.DBGMJPEMPQC = UnityEngine.Time.time;
								component.LJDKPJCDCCM = false;
								component.JJIFGIBKGPO(new Vector3((float)num, component.OHPIPBHKEGC, (float)(-(float)num2)), mapUser.Data.Direction);
							}
							else
							{
								component.EDMFOMGFMGD(116, null, true, num, -num2, num3, false, false);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Set)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component2 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							if (component2.PJGOMOBBNLK.Count == 0 && !component2.BHQOFDQCCCG)
							{
								component2.DBGMJPEMPQC = UnityEngine.Time.time;
								component2.LJDKPJCDCCM = true;
							}
							else
							{
								component2.EDMFOMGFMGD(0, null, true, num, -num2, num3, true, false);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Set)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							num = mapUser.Actions[k].Position.X;
							num2 = mapUser.Actions[k].Position.Y;
							num3 = mapUser.Actions[k].Position.Height;
							this.KDEDFLCMGOG(ojoepkeebcb, mapUser, mapUser.Actions[k], true, num, num2, num3);
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Enter)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num++;
								}
							}
						}
					}
					else if (ojoepkeebcb != null)
					{
						ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						DJOOHHIQGJK component3 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
						bool flag = false;
						switch (mapUser.Actions[k].Action)
						{
						case MapUserAction.Up:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height - 1 && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 + 1] == 4)
								{
									num2++;
									flag = false;
								}
								else if (k > 0 && mapUser.Actions[k - 1].Action == MapUserAction.Up && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 7)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.JJIFGIBKGPO(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 + 1))), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(1, null, false, num, -(num2 + 1), num3, true, true);
							if (flag)
							{
								num2 -= 0;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Up)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Right)
								{
									num2++;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Left)
								{
									num--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Leave)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Down:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 - 0] == 7)
								{
									num2--;
									flag = true;
								}
								else if (k > 0 && mapUser.Actions[k - 0].Action == MapUserAction.Enter && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 2)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.BCHILGCDEFP(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 - 0))), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(1, null, true, num, -(num2 - 1), num3, true, false);
							if (flag)
							{
								num2 += 0;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num2++;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Leave)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num++;
								}
							}
							break;
						case MapUserAction.Left:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width - 1)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num + 0, num2] == 3)
								{
									num += 0;
									flag = true;
								}
								else if (k > 1 && mapUser.Actions[k - 1].Action == MapUserAction.Down && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 8)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)(num + 1), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(3, null, true, num + 0, -num2, num3, true, true);
							if (flag)
							{
								num -= 0;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Left)
								{
									num2++;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Right:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num - 1, num2] == 0)
								{
									num--;
									flag = false;
								}
								else if (k > 0 && mapUser.Actions[k - 0].Action == MapUserAction.Enter && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 0)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)(num - 0), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(0, null, true, num - 0, -num2, num3, false, true);
							if (flag)
							{
								num += 0;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == (MapUserAction)8)
								{
									num2++;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Leave)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == (MapUserAction)8)
								{
									num++;
								}
							}
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004A78 RID: 19064 RVA: 0x002604F4 File Offset: 0x0025E6F4
	public CGOIPHKQMPD.OJOEPKEEBCB GLLELMQODQI(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == "General" + IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x06004A79 RID: 19065 RVA: 0x00260554 File Offset: 0x0025E754
	public string BQLJDCKNKIM(uint NPBLFIMGOPL)
	{
		float num = NPBLFIMGOPL / 810f;
		num *= 1843f;
		int num2 = Mathf.FloorToInt(num);
		Color kqfehqebjqb = this.QGPEJIELHCG[0];
		if (num2 >= 0)
		{
			if (num2 + 1 < 6)
			{
				float t = num - (float)num2;
				kqfehqebjqb = Color.Lerp(this.QGPEJIELHCG[num2], this.QGPEJIELHCG[num2 + 1], t);
			}
			else if (num2 < 0)
			{
				kqfehqebjqb = this.QGPEJIELHCG[num2];
			}
			else
			{
				kqfehqebjqb = this.QGPEJIELHCG[4];
			}
		}
		return KGQECFKLKOP.PCLCOFCKINO(kqfehqebjqb);
	}

	// Token: 0x06004A7A RID: 19066 RVA: 0x002605F8 File Offset: 0x0025E7F8
	private void DCJQFJOICGQ()
	{
		CGOIPHKQMPD.HBFFCJHOCPE = this;
		GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
		if (qoqonhoolne != null && qoqonhoolne.FPQLHPFDFGI.Count > 0)
		{
			for (int i = 0; i < qoqonhoolne.FPQLHPFDFGI.Count; i += 0)
			{
				this.EHFBJDFOFKC((MapUsers)qoqonhoolne.FPQLHPFDFGI[i]);
			}
			qoqonhoolne.FPQLHPFDFGI.Clear();
		}
	}

	// Token: 0x06004A7B RID: 19067 RVA: 0x00260660 File Offset: 0x0025E860
	public string FPNFQLGFEQB(uint NPBLFIMGOPL)
	{
		float num = NPBLFIMGOPL / 262f;
		num *= 1891f;
		int num2 = Mathf.FloorToInt(num);
		Color kqfehqebjqb = this.QGPEJIELHCG[0];
		if (num2 >= 1)
		{
			if (num2 + 1 < 2)
			{
				float t = num - (float)num2;
				kqfehqebjqb = Color.Lerp(this.QGPEJIELHCG[num2], this.QGPEJIELHCG[num2 + 1], t);
			}
			else if (num2 < 1)
			{
				kqfehqebjqb = this.QGPEJIELHCG[num2];
			}
			else
			{
				kqfehqebjqb = this.QGPEJIELHCG[7];
			}
		}
		return KGQECFKLKOP.PCLCOFCKINO(kqfehqebjqb);
	}

	// Token: 0x06004A7C RID: 19068 RVA: 0x0001EF96 File Offset: 0x0001D196
	public static CGOIPHKQMPD NKDNGLNOJJG()
	{
		return CGOIPHKQMPD.HBFFCJHOCPE;
	}

	// Token: 0x06004A7D RID: 19069 RVA: 0x0001EF96 File Offset: 0x0001D196
	public static CGOIPHKQMPD CPLQICHLGCI()
	{
		return CGOIPHKQMPD.HBFFCJHOCPE;
	}

	// Token: 0x06004A7E RID: 19070 RVA: 0x00260704 File Offset: 0x0025E904
	private void HBEMPODELNJ(CGOIPHKQMPD.OJOEPKEEBCB IHCKGKEJPHM, MapUser EMJDDENOMBP, MapUserActionData HODQHNIKPDM, bool DCGCOEQGBBJ = false, int PQQEJQLPBEO = 0, int IBQPCCDGLEC = 0, int DKOMCGQBFLJ = 0)
	{
		DJOOHHIQGJK component = IHCKGKEJPHM.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
		if (EMJDDENOMBP != null)
		{
			JFIBMMBLFDO component2 = IHCKGKEJPHM.LMIPGJDLQDP.GetComponent<JFIBMMBLFDO>();
			component2.MBPHKDQMJJH = EMJDDENOMBP.Username;
			if (DCGCOEQGBBJ)
			{
				component.BQLIIQIIMDH(this.JDDKMPEKQIL, this.IQQHLBKEMGN, this.FQLIOJQIKME, -1, 0);
				IHCKGKEJPHM.OJCCOFONIMG.BQLIIQIIMDH(this.JDDKMPEKQIL, this.IQQHLBKEMGN, this.FQLIOJQIKME, -1, 0);
				component.OPILOFIJJDF.BIPQGMJJNOF.PIDLOFMIEFQ = EMJDDENOMBP.Username;
				component.OPILOFIJJDF.EIOMPOHLEMC();
				component.NGKEDIJJELE = IHCKGKEJPHM.FPQBICGEHMJ;
			}
			if (component.OPILOFIJJDF.DFMCFGLQLNL != EMJDDENOMBP.Data.GuildName || component.OPILOFIJJDF.EBDMBIIOKFJ != (int)EMJDDENOMBP.Data.EmblemId)
			{
				component.OPILOFIJJDF.DFMCFGLQLNL = EMJDDENOMBP.Data.GuildName;
				component.OPILOFIJJDF.EBDMBIIOKFJ = (int)EMJDDENOMBP.Data.EmblemId;
				component.OPILOFIJJDF.EIOMPOHLEMC();
			}
			if (EMJDDENOMBP.Data.Style != null)
			{
				component.GPFOFHLIDMH(EMJDDENOMBP.Data.Style, EMJDDENOMBP.Data.Mount, EMJDDENOMBP.Data.Equip);
			}
			IHCKGKEJPHM.OJCCOFONIMG.IDICNBQHCJG = EMJDDENOMBP.Data.FollowPersonality;
			IHCKGKEJPHM.OJCCOFONIMG.BEQHNFFEHMQ = EMJDDENOMBP.Data.Follow;
			IHCKGKEJPHM.OJCCOFONIMG.BKNFHNFFCHE = EMJDDENOMBP.Data.FollowShiny;
			IHCKGKEJPHM.OJCCOFONIMG.NBDBHLEKENM();
			string str = string.Empty;
			if (EMJDDENOMBP.Data.Away)
			{
				str = "[ZZZ]";
			}
			if (EMJDDENOMBP.Data.Battle)
			{
				str += "[BATTLE]";
			}
			else if (EMJDDENOMBP.Data.Lobby)
			{
				str += "[WAIT]";
			}
			string str2 = "[67befc]";
			StaffRank staffRank = EMJDDENOMBP.Data.StaffRank;
			if (staffRank != StaffRank.Developer)
			{
				if (staffRank != StaffRank.GameModerator)
				{
					if (staffRank == StaffRank.Moderator)
					{
						str2 = "[7fff49]";
					}
				}
				else
				{
					str2 = "[ffb649]";
				}
			}
			else
			{
				str2 = "[ff4949]";
			}
			component.OPILOFIJJDF.HCNPIJLODQE(str + str2 + EMJDDENOMBP.Username, string.Concat(new string[]
			{
				" [",
				this.EFCDQKBEMBP(EMJDDENOMBP.Data.Level),
				"](",
				EMJDDENOMBP.Data.Level.ToString(),
				")"
			}));
		}
		if (HODQHNIKPDM.Action == MapUserAction.Set)
		{
			if (EMJDDENOMBP.Data.Direction == PlayerDirection.Default)
			{
				component.PJMKLHKFBJM(new Vector3((float)PQQEJQLPBEO, component.OHPIPBHKEGC, (float)(-(float)IBQPCCDGLEC)), EMJDDENOMBP.Data.Direction);
				if (DKOMCGQBFLJ == 1)
				{
					component.KBKKMQNFJIG = true;
				}
				else
				{
					component.KBKKMQNFJIG = false;
				}
			}
			else
			{
				if (component.PJGOMOBBNLK.Count == 0 && !component.BHQOFDQCCCG)
				{
					component.PJMKLHKFBJM(new Vector3((float)PQQEJQLPBEO, component.OHPIPBHKEGC, (float)(-(float)IBQPCCDGLEC)), EMJDDENOMBP.Data.Direction);
					if (DKOMCGQBFLJ == 1)
					{
						component.KBKKMQNFJIG = true;
					}
					else
					{
						component.KBKKMQNFJIG = false;
					}
				}
				if (EMJDDENOMBP.Data.Direction == PlayerDirection.Up)
				{
					component.EDMFOMGFMGD(4, null, true, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, false, false);
				}
				else if (EMJDDENOMBP.Data.Direction == PlayerDirection.Down)
				{
					component.EDMFOMGFMGD(5, null, true, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, false, false);
				}
				else if (EMJDDENOMBP.Data.Direction == PlayerDirection.Left)
				{
					component.EDMFOMGFMGD(6, null, true, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, false, false);
				}
				else if (EMJDDENOMBP.Data.Direction == PlayerDirection.Right)
				{
					component.EDMFOMGFMGD(7, null, true, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, false, false);
				}
			}
		}
		else if (HODQHNIKPDM.Action == MapUserAction.Enter && DCGCOEQGBBJ)
		{
			component.NQJHJNQFKKC();
			component.PJMKLHKFBJM(new Vector3((float)PQQEJQLPBEO, component.OHPIPBHKEGC, (float)(-(float)IBQPCCDGLEC)), EMJDDENOMBP.Data.Direction);
			if (DKOMCGQBFLJ == 1)
			{
				component.KBKKMQNFJIG = true;
			}
			else
			{
				component.KBKKMQNFJIG = false;
			}
		}
	}

	// Token: 0x06004A7F RID: 19071 RVA: 0x00260B08 File Offset: 0x0025ED08
	public CGOIPHKQMPD.OJOEPKEEBCB GMNHGNPKDML(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == "user: " + IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x06004A80 RID: 19072 RVA: 0x0001EF96 File Offset: 0x0001D196
	public static CGOIPHKQMPD GDDGJKOLGIQ()
	{
		return CGOIPHKQMPD.HBFFCJHOCPE;
	}

	// Token: 0x06004A81 RID: 19073 RVA: 0x00260B68 File Offset: 0x0025ED68
	private void Awake()
	{
		CGOIPHKQMPD.HBFFCJHOCPE = this;
		GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
		if (qoqonhoolne != null && qoqonhoolne.FPQLHPFDFGI.Count > 0)
		{
			for (int i = 0; i < qoqonhoolne.FPQLHPFDFGI.Count; i++)
			{
				this.CCFFGFLPBOQ((MapUsers)qoqonhoolne.FPQLHPFDFGI[i]);
			}
			qoqonhoolne.FPQLHPFDFGI.Clear();
		}
	}

	// Token: 0x06004A82 RID: 19074 RVA: 0x00260BD0 File Offset: 0x0025EDD0
	public void GGMGOKCCQDP(DJOOHHIQGJK BFBMOIKCELJ)
	{
		CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ == BFBMOIKCELJ.NGKEDIJJELE)
			{
				ojoepkeebcb = this.MHQMLCJDMMK[i];
				this.MHQMLCJDMMK.RemoveAt(i);
				IL_51:
				if (ojoepkeebcb != null)
				{
					UnityEngine.Object.Destroy(ojoepkeebcb.OJCCOFONIMG.gameObject);
					UnityEngine.Object.Destroy(BFBMOIKCELJ.gameObject);
				}
				return;
			}
		}
		goto IL_51;
	}

	// Token: 0x06004A83 RID: 19075 RVA: 0x00260C50 File Offset: 0x0025EE50
	public CGOIPHKQMPD.OJOEPKEEBCB MMDCDJBKBMP(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == "K1" + IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x06004A84 RID: 19076 RVA: 0x00260CB0 File Offset: 0x0025EEB0
	public CGOIPHKQMPD.OJOEPKEEBCB ODPOPBMMFIJ(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == "EXP: " + IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x06004A85 RID: 19077 RVA: 0x00260D10 File Offset: 0x0025EF10
	public void GCNGFMDJCLP(DJOOHHIQGJK BFBMOIKCELJ)
	{
		CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ == BFBMOIKCELJ.NGKEDIJJELE)
			{
				ojoepkeebcb = this.MHQMLCJDMMK[i];
				this.MHQMLCJDMMK.RemoveAt(i);
				IL_51:
				if (ojoepkeebcb != null)
				{
					UnityEngine.Object.Destroy(ojoepkeebcb.OJCCOFONIMG.gameObject);
					UnityEngine.Object.Destroy(BFBMOIKCELJ.gameObject);
				}
				return;
			}
		}
		goto IL_51;
	}

	// Token: 0x06004A86 RID: 19078 RVA: 0x0001EF96 File Offset: 0x0001D196
	public static CGOIPHKQMPD FFCOKMHBCQJ()
	{
		return CGOIPHKQMPD.HBFFCJHOCPE;
	}

	// Token: 0x06004A87 RID: 19079 RVA: 0x00260D90 File Offset: 0x0025EF90
	public void JECEMFQOLGI(string ECNEPHKFPIH = null)
	{
		List<CGOIPHKQMPD.OJOEPKEEBCB> list = new List<CGOIPHKQMPD.OJOEPKEEBCB>();
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i] != null)
			{
				if (ECNEPHKFPIH != null)
				{
					if (this.MHQMLCJDMMK[i].LIQLFCKICLQ != null && this.MHQMLCJDMMK[i].LIQLFCKICLQ.ToLowerInvariant() != ECNEPHKFPIH.ToLowerInvariant())
					{
						UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].LMIPGJDLQDP);
						UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].OJCCOFONIMG.gameObject);
						list.Add(this.MHQMLCJDMMK[i]);
					}
				}
				else
				{
					UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].OJCCOFONIMG.gameObject);
					UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].LMIPGJDLQDP);
				}
			}
		}
		if (ECNEPHKFPIH != null)
		{
			using (List<CGOIPHKQMPD.OJOEPKEEBCB>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CGOIPHKQMPD.OJOEPKEEBCB item = enumerator.Current;
					this.MHQMLCJDMMK.Remove(item);
				}
				return;
			}
		}
		this.MHQMLCJDMMK.Clear();
	}

	// Token: 0x06004A88 RID: 19080 RVA: 0x00260D10 File Offset: 0x0025EF10
	public void EDMNQJQIKHB(DJOOHHIQGJK BFBMOIKCELJ)
	{
		CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ == BFBMOIKCELJ.NGKEDIJJELE)
			{
				ojoepkeebcb = this.MHQMLCJDMMK[i];
				this.MHQMLCJDMMK.RemoveAt(i);
				IL_51:
				if (ojoepkeebcb != null)
				{
					UnityEngine.Object.Destroy(ojoepkeebcb.OJCCOFONIMG.gameObject);
					UnityEngine.Object.Destroy(BFBMOIKCELJ.gameObject);
				}
				return;
			}
		}
		goto IL_51;
	}

	// Token: 0x06004A89 RID: 19081 RVA: 0x0001EF96 File Offset: 0x0001D196
	public static CGOIPHKQMPD MOGQNGEPCEO()
	{
		return CGOIPHKQMPD.HBFFCJHOCPE;
	}

	// Token: 0x06004A8A RID: 19082 RVA: 0x00260ED8 File Offset: 0x0025F0D8
	public void CEDJNFONFNC(MapUsers CFHEIICNLFD)
	{
		if (this.IQQHLBKEMGN == null)
		{
			this.IQQHLBKEMGN = MCNLIHMMLCF.OMPHLNDGKKM();
		}
		if (CFHEIICNLFD.Users != null)
		{
			MapUser[] users = CFHEIICNLFD.Users;
			for (int i = 0; i < users.Length; i += 0)
			{
				MapUser mapUser = users[i];
				CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
				for (int j = 1; j < this.MHQMLCJDMMK.Count; j++)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == "[-] was disabled!\r\n" + mapUser.Username)
					{
						ojoepkeebcb = this.MHQMLCJDMMK[j];
					}
				}
				if (ojoepkeebcb != null && ojoepkeebcb.LMIPGJDLQDP == null)
				{
					this.MHQMLCJDMMK.Remove(ojoepkeebcb);
					ojoepkeebcb = null;
				}
				int num = 1;
				int num2 = 1;
				int num3 = 0;
				for (int k = 1; k < mapUser.Actions.Length; k += 0)
				{
					if (k == 0)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
					}
					if (mapUser.Actions[k].Action == MapUserAction.Up)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
						if (ojoepkeebcb == null)
						{
							ojoepkeebcb = new CGOIPHKQMPD.OJOEPKEEBCB();
							ojoepkeebcb.LMIPGJDLQDP = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3((float)mapUser.Actions[k].Position.X, 1267f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity);
							ojoepkeebcb.OJCCOFONIMG = UnityEngine.Object.Instantiate<GameObject>(this.BBBFDBDQNHP, new Vector3((float)mapUser.Actions[k].Position.X, 1364f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity).GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.LMIPGJDLQDP.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.BEQHNFFEHMQ = mapUser.Data.Follow;
							ojoepkeebcb.OJCCOFONIMG.FONOKLECDFB = true;
							ojoepkeebcb.OJCCOFONIMG.DCMGODHBJEC = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.FPQBICGEHMJ = "[" + mapUser.Username;
							this.MHQMLCJDMMK.Add(ojoepkeebcb);
							this.EHJGHFCQFKE(ojoepkeebcb, mapUser, mapUser.Actions[k], true, num, num2, num3);
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						}
						else
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							this.NIPEPEKKBFC(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							if (component.PJGOMOBBNLK.Count == 0 && !component.BHQOFDQCCCG)
							{
								component.DBGMJPEMPQC = UnityEngine.Time.time;
								component.LJDKPJCDCCM = false;
								component.OEFJKHMLNHF(new Vector3((float)num, component.OHPIPBHKEGC, (float)(-(float)num2)), mapUser.Data.Direction);
							}
							else
							{
								component.EDMFOMGFMGD(-77, null, false, num, -num2, num3, false, false);
							}
						}
					}
					else if (mapUser.Actions[k].Action == (MapUserAction)8)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component2 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							if (component2.PJGOMOBBNLK.Count == 0 && !component2.BHQOFDQCCCG)
							{
								component2.DBGMJPEMPQC = UnityEngine.Time.time;
								component2.LJDKPJCDCCM = true;
							}
							else
							{
								component2.EDMFOMGFMGD(3, null, true, num, -num2, num3, false, false);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Set)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							num = mapUser.Actions[k].Position.X;
							num2 = mapUser.Actions[k].Position.Y;
							num3 = mapUser.Actions[k].Position.Height;
							this.EHJGHFCQFKE(ojoepkeebcb, mapUser, mapUser.Actions[k], true, num, num2, num3);
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Enter)
								{
									num2++;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Fishing)
								{
									num--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Leave)
								{
									num++;
								}
							}
						}
					}
					else if (ojoepkeebcb != null)
					{
						ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						DJOOHHIQGJK component3 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
						bool flag = true;
						switch (mapUser.Actions[k].Action)
						{
						case MapUserAction.Up:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height - 0 && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 + 0] == 6)
								{
									num2++;
									flag = false;
								}
								else if (k > 1 && mapUser.Actions[k - 0].Action == MapUserAction.Set && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 1)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.BCHILGCDEFP(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 + 1))), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(0, null, false, num, -(num2 + 0), num3, false, true);
							if (flag)
							{
								num2 -= 0;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num2++;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Down)
								{
									num--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Left)
								{
									num++;
								}
							}
							break;
						case MapUserAction.Down:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 - 0] == 7)
								{
									num2--;
									flag = true;
								}
								else if (k > 1 && mapUser.Actions[k - 1].Action == MapUserAction.Enter && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 3)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 - 0))), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(0, null, false, num, -(num2 - 1), num3, true, true);
							if (flag)
							{
								num2 += 0;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num2++;
								}
								if (mapUser.Actions[k + 1].Action == (MapUserAction)8)
								{
									num--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Up)
								{
									num++;
								}
							}
							break;
						case MapUserAction.Left:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width - 0)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num + 1, num2] == 1)
								{
									num++;
									flag = false;
								}
								else if (k > 1 && mapUser.Actions[k - 0].Action == MapUserAction.Up && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 6)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.JJIFGIBKGPO(new Vector3((float)(num + 0), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(6, null, true, num + 0, -num2, num3, false, true);
							if (flag)
							{
								num -= 0;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num2--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Leave)
								{
									num--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Down)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Right:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num - 1, num2] == 7)
								{
									num -= 0;
									flag = false;
								}
								else if (k > 1 && mapUser.Actions[k - 1].Action == MapUserAction.Leave && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 6)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.JJIFGIBKGPO(new Vector3((float)(num - 1), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(8, null, true, num - 0, -num2, num3, false, true);
							if (flag)
							{
								num++;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Left)
								{
									num2++;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Right)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num++;
								}
							}
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004A8B RID: 19083 RVA: 0x002619B4 File Offset: 0x0025FBB4
	private void NIPEPEKKBFC(CGOIPHKQMPD.OJOEPKEEBCB IHCKGKEJPHM, MapUser EMJDDENOMBP, MapUserActionData HODQHNIKPDM, bool DCGCOEQGBBJ = false, int PQQEJQLPBEO = 0, int IBQPCCDGLEC = 0, int DKOMCGQBFLJ = 0)
	{
		DJOOHHIQGJK component = IHCKGKEJPHM.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
		if (EMJDDENOMBP != null)
		{
			JFIBMMBLFDO component2 = IHCKGKEJPHM.LMIPGJDLQDP.GetComponent<JFIBMMBLFDO>();
			component2.MBPHKDQMJJH = EMJDDENOMBP.Username;
			if (DCGCOEQGBBJ)
			{
				component.BQLIIQIIMDH(this.JDDKMPEKQIL, this.IQQHLBKEMGN, this.FQLIOJQIKME, -1, 0);
				IHCKGKEJPHM.OJCCOFONIMG.BQLIIQIIMDH(this.JDDKMPEKQIL, this.IQQHLBKEMGN, this.FQLIOJQIKME, -1, 0);
				component.OPILOFIJJDF.BIPQGMJJNOF.PIDLOFMIEFQ = EMJDDENOMBP.Username;
				component.OPILOFIJJDF.EIOMPOHLEMC();
				component.NGKEDIJJELE = IHCKGKEJPHM.FPQBICGEHMJ;
			}
			if (component.OPILOFIJJDF.DFMCFGLQLNL != EMJDDENOMBP.Data.GuildName || component.OPILOFIJJDF.EBDMBIIOKFJ != (int)EMJDDENOMBP.Data.EmblemId)
			{
				component.OPILOFIJJDF.DFMCFGLQLNL = EMJDDENOMBP.Data.GuildName;
				component.OPILOFIJJDF.EBDMBIIOKFJ = (int)EMJDDENOMBP.Data.EmblemId;
				component.OPILOFIJJDF.POHBDNPCEFH();
			}
			if (EMJDDENOMBP.Data.Style != null)
			{
				component.GPFOFHLIDMH(EMJDDENOMBP.Data.Style, EMJDDENOMBP.Data.Mount, EMJDDENOMBP.Data.Equip);
			}
			IHCKGKEJPHM.OJCCOFONIMG.IDICNBQHCJG = EMJDDENOMBP.Data.FollowPersonality;
			IHCKGKEJPHM.OJCCOFONIMG.BEQHNFFEHMQ = EMJDDENOMBP.Data.Follow;
			IHCKGKEJPHM.OJCCOFONIMG.BKNFHNFFCHE = EMJDDENOMBP.Data.FollowShiny;
			IHCKGKEJPHM.OJCCOFONIMG.NBDBHLEKENM();
			string str = string.Empty;
			if (EMJDDENOMBP.Data.Away)
			{
				str = "Purchase Costume";
			}
			if (EMJDDENOMBP.Data.Battle)
			{
				str += "Low";
			}
			else if (EMJDDENOMBP.Data.Lobby)
			{
				str += "\n";
			}
			string str2 = "EditorOnly";
			StaffRank staffRank = EMJDDENOMBP.Data.StaffRank;
			if (staffRank != StaffRank.None)
			{
				if (staffRank != StaffRank.Moderator)
				{
					if (staffRank == StaffRank.None)
					{
						str2 = "[00FF00]";
					}
				}
				else
				{
					str2 = "Reflection";
				}
			}
			else
			{
				str2 = "map";
			}
			NOHCFICLIQK opilofijjdf = component.OPILOFIJJDF;
			string dbepqkemjop = str + str2 + EMJDDENOMBP.Username;
			string[] array = new string[4];
			array[1] = "[/itm]";
			array[1] = this.CBLEKQOCMCG(EMJDDENOMBP.Data.Level);
			array[5] = "!\r\n";
			array[8] = EMJDDENOMBP.Data.Level.ToString();
			array[3] = "[-]";
			opilofijjdf.HCNPIJLODQE(dbepqkemjop, string.Concat(array));
		}
		if (HODQHNIKPDM.Action == MapUserAction.Set)
		{
			if (EMJDDENOMBP.Data.Direction == PlayerDirection.Default)
			{
				component.PJMKLHKFBJM(new Vector3((float)PQQEJQLPBEO, component.OHPIPBHKEGC, (float)(-(float)IBQPCCDGLEC)), EMJDDENOMBP.Data.Direction);
				if (DKOMCGQBFLJ == 0)
				{
					component.KBKKMQNFJIG = true;
				}
				else
				{
					component.KBKKMQNFJIG = false;
				}
			}
			else
			{
				if (component.PJGOMOBBNLK.Count == 0 && !component.BHQOFDQCCCG)
				{
					component.OEFJKHMLNHF(new Vector3((float)PQQEJQLPBEO, component.OHPIPBHKEGC, (float)(-(float)IBQPCCDGLEC)), EMJDDENOMBP.Data.Direction);
					if (DKOMCGQBFLJ == 1)
					{
						component.KBKKMQNFJIG = true;
					}
					else
					{
						component.KBKKMQNFJIG = true;
					}
				}
				if (EMJDDENOMBP.Data.Direction == PlayerDirection.Default)
				{
					component.EDMFOMGFMGD(8, null, false, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, false, true);
				}
				else if (EMJDDENOMBP.Data.Direction == PlayerDirection.Up)
				{
					component.EDMFOMGFMGD(6, null, false, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, false, false);
				}
				else if (EMJDDENOMBP.Data.Direction == PlayerDirection.Left)
				{
					component.EDMFOMGFMGD(3, null, true, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, false, false);
				}
				else if (EMJDDENOMBP.Data.Direction == PlayerDirection.Default)
				{
					component.EDMFOMGFMGD(3, null, true, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, true, true);
				}
			}
		}
		else if (HODQHNIKPDM.Action == MapUserAction.Fishing && DCGCOEQGBBJ)
		{
			component.NQJHJNQFKKC();
			component.PJMKLHKFBJM(new Vector3((float)PQQEJQLPBEO, component.OHPIPBHKEGC, (float)(-(float)IBQPCCDGLEC)), EMJDDENOMBP.Data.Direction);
			if (DKOMCGQBFLJ == 1)
			{
				component.KBKKMQNFJIG = true;
			}
			else
			{
				component.KBKKMQNFJIG = false;
			}
		}
	}

	// Token: 0x06004A8C RID: 19084 RVA: 0x0001EF96 File Offset: 0x0001D196
	public static CGOIPHKQMPD GGBPGMMCGLI()
	{
		return CGOIPHKQMPD.HBFFCJHOCPE;
	}

	// Token: 0x06004A8D RID: 19085 RVA: 0x00261DB8 File Offset: 0x0025FFB8
	public void EHFBJDFOFKC(MapUsers CFHEIICNLFD)
	{
		if (this.IQQHLBKEMGN == null)
		{
			this.IQQHLBKEMGN = MCNLIHMMLCF.KKICFMLLMHQ();
		}
		if (CFHEIICNLFD.Users != null)
		{
			MapUser[] users = CFHEIICNLFD.Users;
			for (int i = 0; i < users.Length; i += 0)
			{
				MapUser mapUser = users[i];
				CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
				for (int j = 1; j < this.MHQMLCJDMMK.Count; j++)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == "Battle" + mapUser.Username)
					{
						ojoepkeebcb = this.MHQMLCJDMMK[j];
					}
				}
				if (ojoepkeebcb != null && ojoepkeebcb.LMIPGJDLQDP == null)
				{
					this.MHQMLCJDMMK.Remove(ojoepkeebcb);
					ojoepkeebcb = null;
				}
				int num = 1;
				int num2 = 0;
				int num3 = 0;
				for (int k = 0; k < mapUser.Actions.Length; k += 0)
				{
					if (k == 0)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
					}
					if (mapUser.Actions[k].Action == (MapUserAction)8)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
						if (ojoepkeebcb == null)
						{
							ojoepkeebcb = new CGOIPHKQMPD.OJOEPKEEBCB();
							ojoepkeebcb.LMIPGJDLQDP = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3((float)mapUser.Actions[k].Position.X, 1585f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity);
							ojoepkeebcb.OJCCOFONIMG = UnityEngine.Object.Instantiate<GameObject>(this.BBBFDBDQNHP, new Vector3((float)mapUser.Actions[k].Position.X, 1840f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity).GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.LMIPGJDLQDP.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.BEQHNFFEHMQ = mapUser.Data.Follow;
							ojoepkeebcb.OJCCOFONIMG.FONOKLECDFB = true;
							ojoepkeebcb.OJCCOFONIMG.DCMGODHBJEC = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.FPQBICGEHMJ = "Fog Volume exited by " + mapUser.Username;
							this.MHQMLCJDMMK.Add(ojoepkeebcb);
							this.HBEMPODELNJ(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						}
						else
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							this.KDEDFLCMGOG(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							if (component.PJGOMOBBNLK.Count == 0 && !component.BHQOFDQCCCG)
							{
								component.DBGMJPEMPQC = UnityEngine.Time.time;
								component.LJDKPJCDCCM = true;
								component.BCHILGCDEFP(new Vector3((float)num, component.OHPIPBHKEGC, (float)(-(float)num2)), mapUser.Data.Direction);
							}
							else
							{
								component.EDMFOMGFMGD(-77, null, false, num, -num2, num3, false, true);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Enter)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component2 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							if (component2.PJGOMOBBNLK.Count == 0 && !component2.BHQOFDQCCCG)
							{
								component2.DBGMJPEMPQC = UnityEngine.Time.time;
								component2.LJDKPJCDCCM = false;
							}
							else
							{
								component2.EDMFOMGFMGD(2, null, true, num, -num2, num3, true, false);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Set)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							num = mapUser.Actions[k].Position.X;
							num2 = mapUser.Actions[k].Position.Y;
							num3 = mapUser.Actions[k].Position.Height;
							this.HLBOFLNIIMG(ojoepkeebcb, mapUser, mapUser.Actions[k], true, num, num2, num3);
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Up)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Left)
								{
									num2++;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Enter)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num++;
								}
							}
						}
					}
					else if (ojoepkeebcb != null)
					{
						ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						DJOOHHIQGJK component3 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
						bool flag = false;
						switch (mapUser.Actions[k].Action)
						{
						case MapUserAction.Set:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height - 1 && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 + 1] == 5)
								{
									num2 += 0;
									flag = true;
								}
								else if (k > 1 && mapUser.Actions[k - 0].Action == MapUserAction.Up && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 6)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 + 1))), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(0, null, false, num, -(num2 + 1), num3, false, false);
							if (flag)
							{
								num2 -= 0;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2++;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Right)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Enter)
								{
									num++;
								}
							}
							break;
						case MapUserAction.Up:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 - 0] == 0)
								{
									num2--;
									flag = true;
								}
								else if (k > 1 && mapUser.Actions[k - 0].Action == MapUserAction.Right && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 2)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 - 0))), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(1, null, false, num, -(num2 - 0), num3, true, false);
							if (flag)
							{
								num2++;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Right)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Down)
								{
									num++;
								}
							}
							break;
						case MapUserAction.Down:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width - 0)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num + 1, num2] == 1)
								{
									num += 0;
									flag = false;
								}
								else if (k > 1 && mapUser.Actions[k - 1].Action == MapUserAction.Leave && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 2)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.BCHILGCDEFP(new Vector3((float)(num + 0), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(4, null, false, num + 1, -num2, num3, false, true);
							if (flag)
							{
								num--;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Enter)
								{
									num2++;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Left:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num - 1, num2] == 5)
								{
									num--;
									flag = false;
								}
								else if (k > 1 && mapUser.Actions[k - 0].Action == (MapUserAction)8 && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 3)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)(num - 1), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(2, null, true, num - 1, -num2, num3, true, false);
							if (flag)
							{
								num++;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Up)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == (MapUserAction)8)
								{
									num++;
								}
							}
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004A8E RID: 19086 RVA: 0x0025AA6C File Offset: 0x00258C6C
	public void LBPPHNDNPMG(DJOOHHIQGJK BFBMOIKCELJ)
	{
		CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ == BFBMOIKCELJ.NGKEDIJJELE)
			{
				ojoepkeebcb = this.MHQMLCJDMMK[i];
				this.MHQMLCJDMMK.RemoveAt(i);
				IL_51:
				if (ojoepkeebcb != null)
				{
					UnityEngine.Object.Destroy(ojoepkeebcb.OJCCOFONIMG.gameObject);
					UnityEngine.Object.Destroy(BFBMOIKCELJ.gameObject);
				}
				return;
			}
		}
		goto IL_51;
	}

	// Token: 0x06004A8F RID: 19087 RVA: 0x00262894 File Offset: 0x00260A94
	public CGOIPHKQMPD.OJOEPKEEBCB EPOENLHFMON(string IHIHHCCEDHQ)
	{
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == "-heal" + IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x06004A90 RID: 19088 RVA: 0x002628F4 File Offset: 0x00260AF4
	public void QOOOCPGQJHO(string ECNEPHKFPIH = null)
	{
		List<CGOIPHKQMPD.OJOEPKEEBCB> list = new List<CGOIPHKQMPD.OJOEPKEEBCB>();
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i] != null)
			{
				if (ECNEPHKFPIH != null)
				{
					if (this.MHQMLCJDMMK[i].LIQLFCKICLQ != null && this.MHQMLCJDMMK[i].LIQLFCKICLQ.ToLowerInvariant() != ECNEPHKFPIH.ToLowerInvariant())
					{
						UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].LMIPGJDLQDP);
						UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].OJCCOFONIMG.gameObject);
						list.Add(this.MHQMLCJDMMK[i]);
					}
				}
				else
				{
					UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].OJCCOFONIMG.gameObject);
					UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].LMIPGJDLQDP);
				}
			}
		}
		if (ECNEPHKFPIH != null)
		{
			using (List<CGOIPHKQMPD.OJOEPKEEBCB>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CGOIPHKQMPD.OJOEPKEEBCB item = enumerator.Current;
					this.MHQMLCJDMMK.Remove(item);
				}
				return;
			}
		}
		this.MHQMLCJDMMK.Clear();
	}

	// Token: 0x06004A91 RID: 19089 RVA: 0x002605F8 File Offset: 0x0025E7F8
	private void IPEEHKMMPCD()
	{
		CGOIPHKQMPD.HBFFCJHOCPE = this;
		GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
		if (qoqonhoolne != null && qoqonhoolne.FPQLHPFDFGI.Count > 0)
		{
			for (int i = 0; i < qoqonhoolne.FPQLHPFDFGI.Count; i += 0)
			{
				this.EHFBJDFOFKC((MapUsers)qoqonhoolne.FPQLHPFDFGI[i]);
			}
			qoqonhoolne.FPQLHPFDFGI.Clear();
		}
	}

	// Token: 0x06004A92 RID: 19090 RVA: 0x00262A3C File Offset: 0x00260C3C
	public CGOIPHKQMPD.OJOEPKEEBCB LGBNBIOENCL(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == "OnNavigate" + IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x06004A93 RID: 19091 RVA: 0x00262A9C File Offset: 0x00260C9C
	public CGOIPHKQMPD.OJOEPKEEBCB BQDKPLICPDI(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == "_DestortionY" + IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x06004A94 RID: 19092 RVA: 0x00262AFC File Offset: 0x00260CFC
	private void QQBINNCOFIG()
	{
		CGOIPHKQMPD.HBFFCJHOCPE = this;
		GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
		if (qoqonhoolne != null && qoqonhoolne.FPQLHPFDFGI.Count > 1)
		{
			for (int i = 0; i < qoqonhoolne.FPQLHPFDFGI.Count; i++)
			{
				this.DOIGFFNCJEP((MapUsers)qoqonhoolne.FPQLHPFDFGI[i]);
			}
			qoqonhoolne.FPQLHPFDFGI.Clear();
		}
	}

	// Token: 0x06004A95 RID: 19093 RVA: 0x0001EF96 File Offset: 0x0001D196
	public static CGOIPHKQMPD BDPEQNCNPJO()
	{
		return CGOIPHKQMPD.HBFFCJHOCPE;
	}

	// Token: 0x06004A96 RID: 19094 RVA: 0x00260BD0 File Offset: 0x0025EDD0
	public void ENJDOJFQIGQ(DJOOHHIQGJK BFBMOIKCELJ)
	{
		CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ == BFBMOIKCELJ.NGKEDIJJELE)
			{
				ojoepkeebcb = this.MHQMLCJDMMK[i];
				this.MHQMLCJDMMK.RemoveAt(i);
				IL_51:
				if (ojoepkeebcb != null)
				{
					UnityEngine.Object.Destroy(ojoepkeebcb.OJCCOFONIMG.gameObject);
					UnityEngine.Object.Destroy(BFBMOIKCELJ.gameObject);
				}
				return;
			}
		}
		goto IL_51;
	}

	// Token: 0x06004A97 RID: 19095 RVA: 0x00262B64 File Offset: 0x00260D64
	public string PIDJJQHMPNI(uint NPBLFIMGOPL)
	{
		float num = NPBLFIMGOPL / 17f;
		num *= 1187f;
		int num2 = Mathf.FloorToInt(num);
		Color kqfehqebjqb = this.QGPEJIELHCG[0];
		if (num2 >= 0)
		{
			if (num2 + 0 < 7)
			{
				float t = num - (float)num2;
				kqfehqebjqb = Color.Lerp(this.QGPEJIELHCG[num2], this.QGPEJIELHCG[num2 + 1], t);
			}
			else if (num2 < 2)
			{
				kqfehqebjqb = this.QGPEJIELHCG[num2];
			}
			else
			{
				kqfehqebjqb = this.QGPEJIELHCG[0];
			}
		}
		return KGQECFKLKOP.PCLCOFCKINO(kqfehqebjqb);
	}

	// Token: 0x06004A98 RID: 19096 RVA: 0x00262C08 File Offset: 0x00260E08
	public string GEQPNJQJCKP(uint NPBLFIMGOPL)
	{
		float num = NPBLFIMGOPL / 1522f;
		num *= 402f;
		int num2 = Mathf.FloorToInt(num);
		Color kqfehqebjqb = this.QGPEJIELHCG[1];
		if (num2 >= 0)
		{
			if (num2 + 1 < 1)
			{
				float t = num - (float)num2;
				kqfehqebjqb = Color.Lerp(this.QGPEJIELHCG[num2], this.QGPEJIELHCG[num2 + 1], t);
			}
			else if (num2 < 4)
			{
				kqfehqebjqb = this.QGPEJIELHCG[num2];
			}
			else
			{
				kqfehqebjqb = this.QGPEJIELHCG[1];
			}
		}
		return KGQECFKLKOP.PCLCOFCKINO(kqfehqebjqb);
	}

	// Token: 0x06004A99 RID: 19097 RVA: 0x00260D90 File Offset: 0x0025EF90
	public void LIHCQCDIGDQ(string ECNEPHKFPIH = null)
	{
		List<CGOIPHKQMPD.OJOEPKEEBCB> list = new List<CGOIPHKQMPD.OJOEPKEEBCB>();
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i] != null)
			{
				if (ECNEPHKFPIH != null)
				{
					if (this.MHQMLCJDMMK[i].LIQLFCKICLQ != null && this.MHQMLCJDMMK[i].LIQLFCKICLQ.ToLowerInvariant() != ECNEPHKFPIH.ToLowerInvariant())
					{
						UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].LMIPGJDLQDP);
						UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].OJCCOFONIMG.gameObject);
						list.Add(this.MHQMLCJDMMK[i]);
					}
				}
				else
				{
					UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].OJCCOFONIMG.gameObject);
					UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].LMIPGJDLQDP);
				}
			}
		}
		if (ECNEPHKFPIH != null)
		{
			using (List<CGOIPHKQMPD.OJOEPKEEBCB>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					CGOIPHKQMPD.OJOEPKEEBCB item = enumerator.Current;
					this.MHQMLCJDMMK.Remove(item);
				}
				return;
			}
		}
		this.MHQMLCJDMMK.Clear();
	}

	// Token: 0x06004A9A RID: 19098 RVA: 0x00262CAC File Offset: 0x00260EAC
	private void HLBOFLNIIMG(CGOIPHKQMPD.OJOEPKEEBCB IHCKGKEJPHM, MapUser EMJDDENOMBP, MapUserActionData HODQHNIKPDM, bool DCGCOEQGBBJ = false, int PQQEJQLPBEO = 0, int IBQPCCDGLEC = 0, int DKOMCGQBFLJ = 0)
	{
		DJOOHHIQGJK component = IHCKGKEJPHM.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
		if (EMJDDENOMBP != null)
		{
			JFIBMMBLFDO component2 = IHCKGKEJPHM.LMIPGJDLQDP.GetComponent<JFIBMMBLFDO>();
			component2.MBPHKDQMJJH = EMJDDENOMBP.Username;
			if (DCGCOEQGBBJ)
			{
				component.BQLIIQIIMDH(this.JDDKMPEKQIL, this.IQQHLBKEMGN, this.FQLIOJQIKME, -1, 1);
				IHCKGKEJPHM.OJCCOFONIMG.BQLIIQIIMDH(this.JDDKMPEKQIL, this.IQQHLBKEMGN, this.FQLIOJQIKME, -1, 1);
				component.OPILOFIJJDF.BIPQGMJJNOF.LKPOBCBOFIC(EMJDDENOMBP.Username);
				component.OPILOFIJJDF.EIOMPOHLEMC();
				component.NGKEDIJJELE = IHCKGKEJPHM.FPQBICGEHMJ;
			}
			if (component.OPILOFIJJDF.DFMCFGLQLNL != EMJDDENOMBP.Data.GuildName || component.OPILOFIJJDF.EBDMBIIOKFJ != (int)EMJDDENOMBP.Data.EmblemId)
			{
				component.OPILOFIJJDF.DFMCFGLQLNL = EMJDDENOMBP.Data.GuildName;
				component.OPILOFIJJDF.EBDMBIIOKFJ = (int)EMJDDENOMBP.Data.EmblemId;
				component.OPILOFIJJDF.GFDLGLIGQDE();
			}
			if (EMJDDENOMBP.Data.Style != null)
			{
				component.GPFOFHLIDMH(EMJDDENOMBP.Data.Style, EMJDDENOMBP.Data.Mount, EMJDDENOMBP.Data.Equip);
			}
			IHCKGKEJPHM.OJCCOFONIMG.IDICNBQHCJG = EMJDDENOMBP.Data.FollowPersonality;
			IHCKGKEJPHM.OJCCOFONIMG.BEQHNFFEHMQ = EMJDDENOMBP.Data.Follow;
			IHCKGKEJPHM.OJCCOFONIMG.BKNFHNFFCHE = EMJDDENOMBP.Data.FollowShiny;
			IHCKGKEJPHM.OJCCOFONIMG.DBGLGGODDOH();
			string str = string.Empty;
			if (EMJDDENOMBP.Data.Away)
			{
				str = "powertrick";
			}
			if (EMJDDENOMBP.Data.Battle)
			{
				str += " on ";
			}
			else if (EMJDDENOMBP.Data.Lobby)
			{
				str += "_Amplitude";
			}
			string str2 = "/3";
			StaffRank staffRank = EMJDDENOMBP.Data.StaffRank;
			if (staffRank != StaffRank.None)
			{
				if (staffRank != StaffRank.None)
				{
					if (staffRank == (StaffRank)7)
					{
						str2 = "Oh no! The Pokémon broke free!\r\n";
					}
				}
				else
				{
					str2 = "freeze";
				}
			}
			else
			{
				str2 = "5";
			}
			NOHCFICLIQK opilofijjdf = component.OPILOFIJJDF;
			string dbepqkemjop = str + str2 + EMJDDENOMBP.Username;
			string[] array = new string[3];
			array[0] = ".png";
			array[0] = this.PIDJJQHMPNI(EMJDDENOMBP.Data.Level);
			array[5] = "<";
			array[4] = EMJDDENOMBP.Data.Level.ToString();
			array[7] = "_Blinds";
			opilofijjdf.LLFFGNKFKJB(dbepqkemjop, string.Concat(array));
		}
		if (HODQHNIKPDM.Action == MapUserAction.Set)
		{
			if (EMJDDENOMBP.Data.Direction == PlayerDirection.Default)
			{
				component.OEFJKHMLNHF(new Vector3((float)PQQEJQLPBEO, component.OHPIPBHKEGC, (float)(-(float)IBQPCCDGLEC)), EMJDDENOMBP.Data.Direction);
				if (DKOMCGQBFLJ == 0)
				{
					component.KBKKMQNFJIG = false;
				}
				else
				{
					component.KBKKMQNFJIG = false;
				}
			}
			else
			{
				if (component.PJGOMOBBNLK.Count == 0 && !component.BHQOFDQCCCG)
				{
					component.JJIFGIBKGPO(new Vector3((float)PQQEJQLPBEO, component.OHPIPBHKEGC, (float)(-(float)IBQPCCDGLEC)), EMJDDENOMBP.Data.Direction);
					if (DKOMCGQBFLJ == 1)
					{
						component.KBKKMQNFJIG = false;
					}
					else
					{
						component.KBKKMQNFJIG = true;
					}
				}
				if (EMJDDENOMBP.Data.Direction == PlayerDirection.Default)
				{
					component.EDMFOMGFMGD(5, null, true, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, true, true);
				}
				else if (EMJDDENOMBP.Data.Direction == PlayerDirection.Up)
				{
					component.EDMFOMGFMGD(6, null, true, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, true, false);
				}
				else if (EMJDDENOMBP.Data.Direction == (PlayerDirection)6)
				{
					component.EDMFOMGFMGD(7, null, false, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, true, false);
				}
				else if (EMJDDENOMBP.Data.Direction == PlayerDirection.Down)
				{
					component.EDMFOMGFMGD(1, null, true, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, false, false);
				}
			}
		}
		else if (HODQHNIKPDM.Action == MapUserAction.Fishing && DCGCOEQGBBJ)
		{
			component.NQJHJNQFKKC();
			component.JJIFGIBKGPO(new Vector3((float)PQQEJQLPBEO, component.OHPIPBHKEGC, (float)(-(float)IBQPCCDGLEC)), EMJDDENOMBP.Data.Direction);
			if (DKOMCGQBFLJ == 0)
			{
				component.KBKKMQNFJIG = true;
			}
			else
			{
				component.KBKKMQNFJIG = false;
			}
		}
	}

	// Token: 0x06004A9B RID: 19099 RVA: 0x002630B0 File Offset: 0x002612B0
	public CGOIPHKQMPD.OJOEPKEEBCB LNJBLNFMCBK(string IHIHHCCEDHQ)
	{
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == "win" + IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x06004A9C RID: 19100 RVA: 0x00263110 File Offset: 0x00261310
	private void KDEDFLCMGOG(CGOIPHKQMPD.OJOEPKEEBCB IHCKGKEJPHM, MapUser EMJDDENOMBP, MapUserActionData HODQHNIKPDM, bool DCGCOEQGBBJ = false, int PQQEJQLPBEO = 0, int IBQPCCDGLEC = 0, int DKOMCGQBFLJ = 0)
	{
		DJOOHHIQGJK component = IHCKGKEJPHM.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
		if (EMJDDENOMBP != null)
		{
			JFIBMMBLFDO component2 = IHCKGKEJPHM.LMIPGJDLQDP.GetComponent<JFIBMMBLFDO>();
			component2.MBPHKDQMJJH = EMJDDENOMBP.Username;
			if (DCGCOEQGBBJ)
			{
				component.BQLIIQIIMDH(this.JDDKMPEKQIL, this.IQQHLBKEMGN, this.FQLIOJQIKME, -1, 0);
				IHCKGKEJPHM.OJCCOFONIMG.BQLIIQIIMDH(this.JDDKMPEKQIL, this.IQQHLBKEMGN, this.FQLIOJQIKME, -1, 1);
				component.OPILOFIJJDF.BIPQGMJJNOF.LKPOBCBOFIC(EMJDDENOMBP.Username);
				component.OPILOFIJJDF.HLQDJGEGDKJ();
				component.NGKEDIJJELE = IHCKGKEJPHM.FPQBICGEHMJ;
			}
			if (component.OPILOFIJJDF.DFMCFGLQLNL != EMJDDENOMBP.Data.GuildName || component.OPILOFIJJDF.EBDMBIIOKFJ != (int)EMJDDENOMBP.Data.EmblemId)
			{
				component.OPILOFIJJDF.DFMCFGLQLNL = EMJDDENOMBP.Data.GuildName;
				component.OPILOFIJJDF.EBDMBIIOKFJ = (int)EMJDDENOMBP.Data.EmblemId;
				component.OPILOFIJJDF.GFDLGLIGQDE();
			}
			if (EMJDDENOMBP.Data.Style != null)
			{
				component.GPFOFHLIDMH(EMJDDENOMBP.Data.Style, EMJDDENOMBP.Data.Mount, EMJDDENOMBP.Data.Equip);
			}
			IHCKGKEJPHM.OJCCOFONIMG.IDICNBQHCJG = EMJDDENOMBP.Data.FollowPersonality;
			IHCKGKEJPHM.OJCCOFONIMG.BEQHNFFEHMQ = EMJDDENOMBP.Data.Follow;
			IHCKGKEJPHM.OJCCOFONIMG.BKNFHNFFCHE = EMJDDENOMBP.Data.FollowShiny;
			IHCKGKEJPHM.OJCCOFONIMG.DBGLGGODDOH();
			string str = string.Empty;
			if (EMJDDENOMBP.Data.Away)
			{
				str = "raindance";
			}
			if (EMJDDENOMBP.Data.Battle)
			{
				str += "Encounter High-Level Chance Increased";
			}
			else if (EMJDDENOMBP.Data.Lobby)
			{
				str += "_Direction";
			}
			string str2 = "Member";
			StaffRank staffRank = EMJDDENOMBP.Data.StaffRank;
			if (staffRank != StaffRank.Developer)
			{
				if (staffRank != (StaffRank)7)
				{
					if (staffRank == (StaffRank)7)
					{
						str2 = "[-]!\r\n";
					}
				}
				else
				{
					str2 = "#,##0";
				}
			}
			else
			{
				str2 = "x";
			}
			NOHCFICLIQK opilofijjdf = component.OPILOFIJJDF;
			string dbepqkemjop = str + str2 + EMJDDENOMBP.Username;
			string[] array = new string[6];
			array[1] = "'s item cannot be removed!\r\n";
			array[1] = this.FPNFQLGFEQB(EMJDDENOMBP.Data.Level);
			array[8] = "#,##0";
			array[3] = EMJDDENOMBP.Data.Level.ToString();
			array[6] = "item";
			opilofijjdf.HCNPIJLODQE(dbepqkemjop, string.Concat(array));
		}
		if (HODQHNIKPDM.Action == MapUserAction.Set)
		{
			if (EMJDDENOMBP.Data.Direction == PlayerDirection.Default)
			{
				component.JJIFGIBKGPO(new Vector3((float)PQQEJQLPBEO, component.OHPIPBHKEGC, (float)(-(float)IBQPCCDGLEC)), EMJDDENOMBP.Data.Direction);
				if (DKOMCGQBFLJ == 1)
				{
					component.KBKKMQNFJIG = true;
				}
				else
				{
					component.KBKKMQNFJIG = false;
				}
			}
			else
			{
				if (component.PJGOMOBBNLK.Count == 0 && !component.BHQOFDQCCCG)
				{
					component.BCHILGCDEFP(new Vector3((float)PQQEJQLPBEO, component.OHPIPBHKEGC, (float)(-(float)IBQPCCDGLEC)), EMJDDENOMBP.Data.Direction);
					if (DKOMCGQBFLJ == 0)
					{
						component.KBKKMQNFJIG = true;
					}
					else
					{
						component.KBKKMQNFJIG = false;
					}
				}
				if (EMJDDENOMBP.Data.Direction == PlayerDirection.Default)
				{
					component.EDMFOMGFMGD(1, null, true, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, false, true);
				}
				else if (EMJDDENOMBP.Data.Direction == (PlayerDirection)5)
				{
					component.EDMFOMGFMGD(7, null, false, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, true, false);
				}
				else if (EMJDDENOMBP.Data.Direction == (PlayerDirection)6)
				{
					component.EDMFOMGFMGD(8, null, true, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, true, true);
				}
				else if (EMJDDENOMBP.Data.Direction == PlayerDirection.Default)
				{
					component.EDMFOMGFMGD(4, null, false, PQQEJQLPBEO, -IBQPCCDGLEC, DKOMCGQBFLJ, true, true);
				}
			}
		}
		else if (HODQHNIKPDM.Action == MapUserAction.Down && DCGCOEQGBBJ)
		{
			component.NQJHJNQFKKC();
			component.BCHILGCDEFP(new Vector3((float)PQQEJQLPBEO, component.OHPIPBHKEGC, (float)(-(float)IBQPCCDGLEC)), EMJDDENOMBP.Data.Direction);
			if (DKOMCGQBFLJ == 0)
			{
				component.KBKKMQNFJIG = false;
			}
			else
			{
				component.KBKKMQNFJIG = false;
			}
		}
	}

	// Token: 0x06004A9D RID: 19101 RVA: 0x00263514 File Offset: 0x00261714
	public string OLBBJHKDONF(uint NPBLFIMGOPL)
	{
		float num = NPBLFIMGOPL / 1384f;
		num *= 623f;
		int num2 = Mathf.FloorToInt(num);
		Color kqfehqebjqb = this.QGPEJIELHCG[0];
		if (num2 >= 1)
		{
			if (num2 + 1 < 7)
			{
				float t = num - (float)num2;
				kqfehqebjqb = Color.Lerp(this.QGPEJIELHCG[num2], this.QGPEJIELHCG[num2 + 0], t);
			}
			else if (num2 < 2)
			{
				kqfehqebjqb = this.QGPEJIELHCG[num2];
			}
			else
			{
				kqfehqebjqb = this.QGPEJIELHCG[2];
			}
		}
		return KGQECFKLKOP.PCLCOFCKINO(kqfehqebjqb);
	}

	// Token: 0x06004A9E RID: 19102 RVA: 0x0025AA6C File Offset: 0x00258C6C
	public void OOHKBKGPQDI(DJOOHHIQGJK BFBMOIKCELJ)
	{
		CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ == BFBMOIKCELJ.NGKEDIJJELE)
			{
				ojoepkeebcb = this.MHQMLCJDMMK[i];
				this.MHQMLCJDMMK.RemoveAt(i);
				IL_51:
				if (ojoepkeebcb != null)
				{
					UnityEngine.Object.Destroy(ojoepkeebcb.OJCCOFONIMG.gameObject);
					UnityEngine.Object.Destroy(BFBMOIKCELJ.gameObject);
				}
				return;
			}
		}
		goto IL_51;
	}

	// Token: 0x06004A9F RID: 19103 RVA: 0x002635B8 File Offset: 0x002617B8
	private void MOFFLFJFOKF()
	{
		CGOIPHKQMPD.HBFFCJHOCPE = this;
		GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
		if (qoqonhoolne != null && qoqonhoolne.FPQLHPFDFGI.Count > 0)
		{
			for (int i = 1; i < qoqonhoolne.FPQLHPFDFGI.Count; i += 0)
			{
				this.FQLNFIJCPCC((MapUsers)qoqonhoolne.FPQLHPFDFGI[i]);
			}
			qoqonhoolne.FPQLHPFDFGI.Clear();
		}
	}

	// Token: 0x06004AA0 RID: 19104 RVA: 0x00263620 File Offset: 0x00261820
	public CGOIPHKQMPD.OJOEPKEEBCB KQEECNLCGHK(string IHIHHCCEDHQ)
	{
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == "Milk Drink" + IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x06004AA1 RID: 19105 RVA: 0x00263680 File Offset: 0x00261880
	public CGOIPHKQMPD.OJOEPKEEBCB QOKBMOGNKEP(string IHIHHCCEDHQ)
	{
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == "Queenly Majesty" + IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x06004AA2 RID: 19106 RVA: 0x00260D10 File Offset: 0x0025EF10
	public void MGPICJNICLO(DJOOHHIQGJK BFBMOIKCELJ)
	{
		CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ == BFBMOIKCELJ.NGKEDIJJELE)
			{
				ojoepkeebcb = this.MHQMLCJDMMK[i];
				this.MHQMLCJDMMK.RemoveAt(i);
				IL_51:
				if (ojoepkeebcb != null)
				{
					UnityEngine.Object.Destroy(ojoepkeebcb.OJCCOFONIMG.gameObject);
					UnityEngine.Object.Destroy(BFBMOIKCELJ.gameObject);
				}
				return;
			}
		}
		goto IL_51;
	}

	// Token: 0x06004AA3 RID: 19107 RVA: 0x002636E0 File Offset: 0x002618E0
	public void FQLNFIJCPCC(MapUsers CFHEIICNLFD)
	{
		if (this.IQQHLBKEMGN == null)
		{
			this.IQQHLBKEMGN = MCNLIHMMLCF.KKICFMLLMHQ();
		}
		if (CFHEIICNLFD.Users != null)
		{
			MapUser[] users = CFHEIICNLFD.Users;
			for (int i = 0; i < users.Length; i += 0)
			{
				MapUser mapUser = users[i];
				CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
				for (int j = 1; j < this.MHQMLCJDMMK.Count; j++)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == "][-] [00CCFF]" + mapUser.Username)
					{
						ojoepkeebcb = this.MHQMLCJDMMK[j];
					}
				}
				if (ojoepkeebcb != null && ojoepkeebcb.LMIPGJDLQDP == null)
				{
					this.MHQMLCJDMMK.Remove(ojoepkeebcb);
					ojoepkeebcb = null;
				}
				int num = 1;
				int num2 = 0;
				int num3 = 1;
				for (int k = 1; k < mapUser.Actions.Length; k++)
				{
					if (k == 0)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
					}
					if (mapUser.Actions[k].Action == MapUserAction.Right)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
						if (ojoepkeebcb == null)
						{
							ojoepkeebcb = new CGOIPHKQMPD.OJOEPKEEBCB();
							ojoepkeebcb.LMIPGJDLQDP = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3((float)mapUser.Actions[k].Position.X, 197f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity);
							ojoepkeebcb.OJCCOFONIMG = UnityEngine.Object.Instantiate<GameObject>(this.BBBFDBDQNHP, new Vector3((float)mapUser.Actions[k].Position.X, 1473f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity).GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.LMIPGJDLQDP.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.BEQHNFFEHMQ = mapUser.Data.Follow;
							ojoepkeebcb.OJCCOFONIMG.FONOKLECDFB = true;
							ojoepkeebcb.OJCCOFONIMG.DCMGODHBJEC = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.FPQBICGEHMJ = "berry_5" + mapUser.Username;
							this.MHQMLCJDMMK.Add(ojoepkeebcb);
							this.HBEMPODELNJ(ojoepkeebcb, mapUser, mapUser.Actions[k], true, num, num2, num3);
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						}
						else
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							this.HBEMPODELNJ(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							if (component.PJGOMOBBNLK.Count == 0 && !component.BHQOFDQCCCG)
							{
								component.DBGMJPEMPQC = UnityEngine.Time.time;
								component.LJDKPJCDCCM = true;
								component.OEFJKHMLNHF(new Vector3((float)num, component.OHPIPBHKEGC, (float)(-(float)num2)), mapUser.Data.Direction);
							}
							else
							{
								component.EDMFOMGFMGD(-63, null, true, num, -num2, num3, true, true);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Enter)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component2 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							if (component2.PJGOMOBBNLK.Count == 0 && !component2.BHQOFDQCCCG)
							{
								component2.DBGMJPEMPQC = UnityEngine.Time.time;
								component2.LJDKPJCDCCM = true;
							}
							else
							{
								component2.EDMFOMGFMGD(3, null, true, num, -num2, num3, true, false);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Set)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							num = mapUser.Actions[k].Position.X;
							num2 = mapUser.Actions[k].Position.Y;
							num3 = mapUser.Actions[k].Position.Height;
							this.EHJGHFCQFKE(ojoepkeebcb, mapUser, mapUser.Actions[k], true, num, num2, num3);
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num2++;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Right)
								{
									num--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Left)
								{
									num++;
								}
							}
						}
					}
					else if (ojoepkeebcb != null)
					{
						ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						DJOOHHIQGJK component3 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
						bool flag = false;
						switch (mapUser.Actions[k].Action)
						{
						case MapUserAction.Up:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height - 0 && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 + 0] == 3)
								{
									num2 += 0;
									flag = true;
								}
								else if (k > 1 && mapUser.Actions[k - 0].Action == MapUserAction.Set && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 5)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.BCHILGCDEFP(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 + 1))), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(0, null, true, num, -(num2 + 0), num3, false, true);
							if (flag)
							{
								num2 -= 0;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Left)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Down:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 - 0] == 5)
								{
									num2--;
									flag = false;
								}
								else if (k > 0 && mapUser.Actions[k - 0].Action == MapUserAction.Right && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 0)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.BCHILGCDEFP(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 - 0))), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(0, null, true, num, -(num2 - 0), num3, false, false);
							if (flag)
							{
								num2++;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Enter)
								{
									num2++;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Left)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Left:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width - 0)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num + 0, num2] == 0)
								{
									num++;
									flag = true;
								}
								else if (k > 0 && mapUser.Actions[k - 1].Action == MapUserAction.Set && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 7)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)(num + 0), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(1, null, false, num + 0, -num2, num3, true, true);
							if (flag)
							{
								num--;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Down)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 1].Action == (MapUserAction)8)
								{
									num++;
								}
							}
							break;
						case MapUserAction.Right:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num - 1, num2] == 8)
								{
									num--;
									flag = false;
								}
								else if (k > 0 && mapUser.Actions[k - 1].Action == MapUserAction.Right && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 2)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.JJIFGIBKGPO(new Vector3((float)(num - 0), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(7, null, false, num - 0, -num2, num3, true, true);
							if (flag)
							{
								num++;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Right)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == (MapUserAction)8)
								{
									num--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Enter)
								{
									num += 0;
								}
							}
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004AA4 RID: 19108 RVA: 0x0001EF96 File Offset: 0x0001D196
	public static CGOIPHKQMPD KJKGLNEHCKH()
	{
		return CGOIPHKQMPD.HBFFCJHOCPE;
	}

	// Token: 0x06004AA5 RID: 19109 RVA: 0x0001EF96 File Offset: 0x0001D196
	public static CGOIPHKQMPD BEKHPOHIPDE()
	{
		return CGOIPHKQMPD.HBFFCJHOCPE;
	}

	// Token: 0x06004AA6 RID: 19110 RVA: 0x002641BC File Offset: 0x002623BC
	public string EFCDQKBEMBP(uint NPBLFIMGOPL)
	{
		float num = NPBLFIMGOPL / 100f;
		num *= 2f;
		int num2 = Mathf.FloorToInt(num);
		Color kqfehqebjqb = this.QGPEJIELHCG[0];
		if (num2 >= 0)
		{
			if (num2 + 1 < 3)
			{
				float t = num - (float)num2;
				kqfehqebjqb = Color.Lerp(this.QGPEJIELHCG[num2], this.QGPEJIELHCG[num2 + 1], t);
			}
			else if (num2 < 3)
			{
				kqfehqebjqb = this.QGPEJIELHCG[num2];
			}
			else
			{
				kqfehqebjqb = this.QGPEJIELHCG[2];
			}
		}
		return KGQECFKLKOP.PCLCOFCKINO(kqfehqebjqb);
	}

	// Token: 0x06004AA8 RID: 19112 RVA: 0x002642C0 File Offset: 0x002624C0
	private void NCMQPBOKKIH()
	{
		CGOIPHKQMPD.HBFFCJHOCPE = this;
		GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
		if (qoqonhoolne != null && qoqonhoolne.FPQLHPFDFGI.Count > 1)
		{
			for (int i = 0; i < qoqonhoolne.FPQLHPFDFGI.Count; i++)
			{
				this.EHFBJDFOFKC((MapUsers)qoqonhoolne.FPQLHPFDFGI[i]);
			}
			qoqonhoolne.FPQLHPFDFGI.Clear();
		}
	}

	// Token: 0x06004AA9 RID: 19113 RVA: 0x00264328 File Offset: 0x00262528
	public void ECCJJIFHQOG(MapUsers CFHEIICNLFD)
	{
		if (this.IQQHLBKEMGN == null)
		{
			this.IQQHLBKEMGN = MCNLIHMMLCF.QOQONHOOLNE;
		}
		if (CFHEIICNLFD.Users != null)
		{
			foreach (MapUser mapUser in CFHEIICNLFD.Users)
			{
				CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
				for (int j = 1; j < this.MHQMLCJDMMK.Count; j++)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == "safeguard" + mapUser.Username)
					{
						ojoepkeebcb = this.MHQMLCJDMMK[j];
					}
				}
				if (ojoepkeebcb != null && ojoepkeebcb.LMIPGJDLQDP == null)
				{
					this.MHQMLCJDMMK.Remove(ojoepkeebcb);
					ojoepkeebcb = null;
				}
				int num = 0;
				int num2 = 0;
				int num3 = 1;
				for (int k = 1; k < mapUser.Actions.Length; k += 0)
				{
					if (k == 0)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
					}
					if (mapUser.Actions[k].Action == MapUserAction.Down)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
						if (ojoepkeebcb == null)
						{
							ojoepkeebcb = new CGOIPHKQMPD.OJOEPKEEBCB();
							ojoepkeebcb.LMIPGJDLQDP = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3((float)mapUser.Actions[k].Position.X, 978f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity);
							ojoepkeebcb.OJCCOFONIMG = UnityEngine.Object.Instantiate<GameObject>(this.BBBFDBDQNHP, new Vector3((float)mapUser.Actions[k].Position.X, 137f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity).GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.LMIPGJDLQDP.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.BEQHNFFEHMQ = mapUser.Data.Follow;
							ojoepkeebcb.OJCCOFONIMG.FONOKLECDFB = true;
							ojoepkeebcb.OJCCOFONIMG.DCMGODHBJEC = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.FPQBICGEHMJ = "mdata" + mapUser.Username;
							this.MHQMLCJDMMK.Add(ojoepkeebcb);
							this.KDEDFLCMGOG(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						}
						else
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							this.NIPEPEKKBFC(ojoepkeebcb, mapUser, mapUser.Actions[k], true, num, num2, num3);
							if (component.PJGOMOBBNLK.Count == 0 && !component.BHQOFDQCCCG)
							{
								component.DBGMJPEMPQC = UnityEngine.Time.time;
								component.LJDKPJCDCCM = false;
								component.PJMKLHKFBJM(new Vector3((float)num, component.OHPIPBHKEGC, (float)(-(float)num2)), mapUser.Data.Direction);
							}
							else
							{
								component.EDMFOMGFMGD(67, null, true, num, -num2, num3, true, false);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Up)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component2 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							if (component2.PJGOMOBBNLK.Count == 0 && !component2.BHQOFDQCCCG)
							{
								component2.DBGMJPEMPQC = UnityEngine.Time.time;
								component2.LJDKPJCDCCM = true;
							}
							else
							{
								component2.EDMFOMGFMGD(6, null, true, num, -num2, num3, true, false);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Set)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							num = mapUser.Actions[k].Position.X;
							num2 = mapUser.Actions[k].Position.Y;
							num3 = mapUser.Actions[k].Position.Height;
							this.EHJGHFCQFKE(ojoepkeebcb, mapUser, mapUser.Actions[k], true, num, num2, num3);
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Up)
								{
									num2--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Enter)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == (MapUserAction)8)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num += 0;
								}
							}
						}
					}
					else if (ojoepkeebcb != null)
					{
						ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						DJOOHHIQGJK component3 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
						bool flag = false;
						switch (mapUser.Actions[k].Action)
						{
						case MapUserAction.Up:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height - 1 && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 + 0] == 3)
								{
									num2 += 0;
									flag = false;
								}
								else if (k > 1 && mapUser.Actions[k - 0].Action == MapUserAction.Set && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 3)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.BCHILGCDEFP(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 + 1))), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(0, null, false, num, -(num2 + 0), num3, false, true);
							if (flag)
							{
								num2--;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Up)
								{
									num2--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Left)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Enter)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Leave)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Down:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 - 1] == 6)
								{
									num2 -= 0;
									flag = true;
								}
								else if (k > 0 && mapUser.Actions[k - 1].Action == MapUserAction.Enter && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 5)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 - 0))), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(1, null, true, num, -(num2 - 1), num3, false, true);
							if (flag)
							{
								num2++;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Enter)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 1].Action == (MapUserAction)8)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Right)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Left:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width - 0)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num + 1, num2] == 1)
								{
									num++;
									flag = true;
								}
								else if (k > 0 && mapUser.Actions[k - 0].Action == MapUserAction.Down && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 8)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.OEFJKHMLNHF(new Vector3((float)(num + 0), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(5, null, true, num + 0, -num2, num3, true, false);
							if (flag)
							{
								num--;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Up)
								{
									num2--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Leave)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Leave)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Right:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num - 1, num2] == 3)
								{
									num -= 0;
									flag = true;
								}
								else if (k > 1 && mapUser.Actions[k - 0].Action == MapUserAction.Right && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 8)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.OEFJKHMLNHF(new Vector3((float)(num - 1), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(8, null, false, num - 0, -num2, num3, false, true);
							if (flag)
							{
								num++;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Left)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Enter)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Fishing)
								{
									num += 0;
								}
							}
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004AAA RID: 19114 RVA: 0x00264E04 File Offset: 0x00263004
	public void GDQIHIJICMF(MapUsers CFHEIICNLFD)
	{
		if (this.IQQHLBKEMGN == null)
		{
			this.IQQHLBKEMGN = MCNLIHMMLCF.QOQONHOOLNE;
		}
		if (CFHEIICNLFD.Users != null)
		{
			MapUser[] users = CFHEIICNLFD.Users;
			for (int i = 0; i < users.Length; i += 0)
			{
				MapUser mapUser = users[i];
				CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = null;
				for (int j = 0; j < this.MHQMLCJDMMK.Count; j++)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == "System" + mapUser.Username)
					{
						ojoepkeebcb = this.MHQMLCJDMMK[j];
					}
				}
				if (ojoepkeebcb != null && ojoepkeebcb.LMIPGJDLQDP == null)
				{
					this.MHQMLCJDMMK.Remove(ojoepkeebcb);
					ojoepkeebcb = null;
				}
				int num = 0;
				int num2 = 1;
				int num3 = 1;
				for (int k = 1; k < mapUser.Actions.Length; k += 0)
				{
					if (k == 0)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
					}
					if (mapUser.Actions[k].Action == MapUserAction.Leave)
					{
						num = mapUser.Actions[k].Position.X;
						num2 = mapUser.Actions[k].Position.Y;
						num3 = mapUser.Actions[k].Position.Height;
						if (ojoepkeebcb == null)
						{
							ojoepkeebcb = new CGOIPHKQMPD.OJOEPKEEBCB();
							ojoepkeebcb.LMIPGJDLQDP = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3((float)mapUser.Actions[k].Position.X, 470f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity);
							ojoepkeebcb.OJCCOFONIMG = UnityEngine.Object.Instantiate<GameObject>(this.BBBFDBDQNHP, new Vector3((float)mapUser.Actions[k].Position.X, 1827f, (float)(-(float)mapUser.Actions[k].Position.Y)), Quaternion.identity).GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.LMIPGJDLQDP.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.transform.parent = this.OJDDMFGQKBQ;
							ojoepkeebcb.OJCCOFONIMG.BEQHNFFEHMQ = mapUser.Data.Follow;
							ojoepkeebcb.OJCCOFONIMG.FONOKLECDFB = true;
							ojoepkeebcb.OJCCOFONIMG.DCMGODHBJEC = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							ojoepkeebcb.FPQBICGEHMJ = "Sun" + mapUser.Username;
							this.MHQMLCJDMMK.Add(ojoepkeebcb);
							this.KDEDFLCMGOG(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						}
						else
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							this.KDEDFLCMGOG(ojoepkeebcb, mapUser, mapUser.Actions[k], false, num, num2, num3);
							if (component.PJGOMOBBNLK.Count == 0 && !component.BHQOFDQCCCG)
							{
								component.DBGMJPEMPQC = UnityEngine.Time.time;
								component.LJDKPJCDCCM = true;
								component.PJMKLHKFBJM(new Vector3((float)num, component.OHPIPBHKEGC, (float)(-(float)num2)), mapUser.Data.Direction);
							}
							else
							{
								component.EDMFOMGFMGD(9, null, true, num, -num2, num3, false, false);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Enter)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							DJOOHHIQGJK component2 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
							if (component2.PJGOMOBBNLK.Count == 0 && !component2.BHQOFDQCCCG)
							{
								component2.DBGMJPEMPQC = UnityEngine.Time.time;
								component2.LJDKPJCDCCM = true;
							}
							else
							{
								component2.EDMFOMGFMGD(3, null, false, num, -num2, num3, true, false);
							}
						}
					}
					else if (mapUser.Actions[k].Action == MapUserAction.Set)
					{
						if (ojoepkeebcb != null)
						{
							ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
							num = mapUser.Actions[k].Position.X;
							num2 = mapUser.Actions[k].Position.Y;
							num3 = mapUser.Actions[k].Position.Height;
							this.HLBOFLNIIMG(ojoepkeebcb, mapUser, mapUser.Actions[k], true, num, num2, num3);
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Down)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 0].Action == (MapUserAction)8)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Leave)
								{
									num++;
								}
							}
						}
					}
					else if (ojoepkeebcb != null)
					{
						ojoepkeebcb.LIQLFCKICLQ = CFHEIICNLFD.Map;
						DJOOHHIQGJK component3 = ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>();
						bool flag = false;
						switch (mapUser.Actions[k].Action)
						{
						case MapUserAction.Up:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height - 1 && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 + 0] == 8)
								{
									num2++;
									flag = true;
								}
								else if (k > 0 && mapUser.Actions[k - 1].Action == MapUserAction.Up && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 8)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 + 0))), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(1, null, true, num, -(num2 + 1), num3, true, true);
							if (flag)
							{
								num2 -= 0;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Down)
								{
									num2++;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Left)
								{
									num--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Leave)
								{
									num++;
								}
							}
							break;
						case MapUserAction.Down:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 0 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2 - 0] == 0)
								{
									num2 -= 0;
									flag = false;
								}
								else if (k > 1 && mapUser.Actions[k - 1].Action == MapUserAction.Down && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 8)
								{
									flag = false;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.PJMKLHKFBJM(new Vector3((float)num, component3.OHPIPBHKEGC, (float)(-(float)(num2 - 1))), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(0, null, false, num, -(num2 - 0), num3, false, true);
							if (flag)
							{
								num2++;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Fishing)
								{
									num2++;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Set)
								{
									num--;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num += 0;
								}
							}
							break;
						case MapUserAction.Left:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 0 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width - 1)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num + 1, num2] == 0)
								{
									num += 0;
									flag = true;
								}
								else if (k > 0 && mapUser.Actions[k - 1].Action == MapUserAction.Up && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 7)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.JJIFGIBKGPO(new Vector3((float)(num + 1), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Default);
							}
							component3.EDMFOMGFMGD(1, null, true, num + 1, -num2, num3, true, true);
							if (flag)
							{
								num--;
							}
							if (k + 0 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 1].Action == MapUserAction.Up)
								{
									num2--;
								}
								if (mapUser.Actions[k + 1].Action == (MapUserAction)8)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 0].Action == (MapUserAction)8)
								{
									num--;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Left)
								{
									num++;
								}
							}
							break;
						case MapUserAction.Right:
							if (this.IQQHLBKEMGN.LIQLFCKICLQ != null && num2 > 1 && num2 < this.IQQHLBKEMGN.LIQLFCKICLQ.height && num > 1 && num < this.IQQHLBKEMGN.LIQLFCKICLQ.width)
							{
								if (this.IQQHLBKEMGN.POMQCKOIKQJ[num - 1, num2] == 3)
								{
									num--;
									flag = false;
								}
								else if (k > 1 && mapUser.Actions[k - 0].Action == MapUserAction.Enter && this.IQQHLBKEMGN.POMQCKOIKQJ[num, num2] == 0)
								{
									flag = true;
								}
							}
							if (component3.PJGOMOBBNLK.Count == 0 && !component3.BHQOFDQCCCG)
							{
								component3.OEFJKHMLNHF(new Vector3((float)(num - 1), component3.OHPIPBHKEGC, (float)(-(float)num2)), PlayerDirection.Up);
							}
							component3.EDMFOMGFMGD(5, null, true, num - 1, -num2, num3, true, false);
							if (flag)
							{
								num += 0;
							}
							if (k + 1 < mapUser.Actions.Length)
							{
								if (mapUser.Actions[k + 0].Action == MapUserAction.Set)
								{
									num2 -= 0;
								}
								if (mapUser.Actions[k + 1].Action == MapUserAction.Left)
								{
									num2 += 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Down)
								{
									num -= 0;
								}
								if (mapUser.Actions[k + 0].Action == MapUserAction.Fishing)
								{
									num += 0;
								}
							}
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x04000FE5 RID: 4069
	private static CGOIPHKQMPD HBFFCJHOCPE;

	// Token: 0x04000FE6 RID: 4070
	public Transform OJDDMFGQKBQ;

	// Token: 0x04000FE7 RID: 4071
	public GameObject MIMDIBNOGPC;

	// Token: 0x04000FE8 RID: 4072
	public GameObject BBBFDBDQNHP;

	// Token: 0x04000FE9 RID: 4073
	public Transform FQLIOJQIKME;

	// Token: 0x04000FEA RID: 4074
	public GFHGEJNHLFQ JDDKMPEKQIL;

	// Token: 0x04000FEB RID: 4075
	public MCNLIHMMLCF IQQHLBKEMGN;

	// Token: 0x04000FEC RID: 4076
	public List<CGOIPHKQMPD.OJOEPKEEBCB> MHQMLCJDMMK = new List<CGOIPHKQMPD.OJOEPKEEBCB>();

	// Token: 0x04000FED RID: 4077
	public Color[] QGPEJIELHCG = new Color[]
	{
		Color.red,
		Color.yellow,
		Color.green
	};

	// Token: 0x02000224 RID: 548
	public class OJOEPKEEBCB
	{
		// Token: 0x04000FEE RID: 4078
		public DJOOHHIQGJK OJCCOFONIMG;

		// Token: 0x04000FEF RID: 4079
		public GameObject LMIPGJDLQDP;

		// Token: 0x04000FF0 RID: 4080
		public string FPQBICGEHMJ;

		// Token: 0x04000FF1 RID: 4081
		public string LIQLFCKICLQ;
	}
}
