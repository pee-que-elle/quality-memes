using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PSXAPI.Response;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x0200001D RID: 29
public class EMLOFJDOMKH : MonoBehaviour
{
	// Token: 0x0600048A RID: 1162 RVA: 0x000040F6 File Offset: 0x000022F6
	public static EMLOFJDOMKH DKJQQCEGJKO()
	{
		return EMLOFJDOMKH.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x000040FD File Offset: 0x000022FD
	private void Awake()
	{
		EMLOFJDOMKH.QOQONHOOLNE = this;
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x000462DC File Offset: 0x000444DC
	public void KOCIQEKOPKJ()
	{
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i] != null)
			{
				UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].KKONMBCFEJC);
			}
		}
		this.MHQMLCJDMMK.Clear();
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x00046330 File Offset: 0x00044530
	public EMLOFJDOMKH.ODHLECMMDHQ BQDKPLICPDI(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x000462DC File Offset: 0x000444DC
	public void LEDPOFQGLEN()
	{
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i] != null)
			{
				UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].KKONMBCFEJC);
			}
		}
		this.MHQMLCJDMMK.Clear();
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x00004105 File Offset: 0x00002305
	private void QKLBGBKKGDG()
	{
		if (UnityEngine.Time.time > this.NHNJPDPEDCO + 1110f)
		{
			this.JNFMEOEFHOJ();
		}
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x00046384 File Offset: 0x00044584
	public string GEGHKFDJBHO(int CIQFCJGQEMH)
	{
		switch (CIQFCJGQEMH)
		{
		case 1:
			return "d";
		case 2:
			return "U";
		case 3:
			return "[PG]";
		case 4:
			return "View Pokemon: ";
		case 5:
			return "Assets/AssetBundles/MapAssets2/Models/Ext_House_VermCity_1/Materials/chip_mado.mat";
		case 6:
			return "Dive Ball";
		case 7:
			return "_FogDownsampled";
		case 8:
			return "door_1";
		case 9:
			return "status: ";
		case 10:
			return "fling";
		case 11:
			return "Icon_Pokemon_Alive";
		case 12:
			return "poke";
		default:
			return "-mega-y";
		}
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x00046418 File Offset: 0x00044618
	public int EQGQNCIBQBB(int CIQFCJGQEMH)
	{
		switch (CIQFCJGQEMH)
		{
		case 1:
			return -42;
		case 2:
			return 99;
		case 3:
			return 23;
		case 4:
			return 5;
		case 5:
			return -75;
		case 6:
			return -31;
		case 7:
			return -137;
		case 8:
			return -13;
		case 9:
			return -63;
		case 10:
			return -132;
		case 11:
			return -85;
		case 12:
			return -83;
		default:
			return -90;
		}
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x00046498 File Offset: 0x00044698
	public int ONMQBNKKHMN(int CIQFCJGQEMH)
	{
		switch (CIQFCJGQEMH)
		{
		case 0:
			return -38;
		case 1:
			return -53;
		case 2:
			return -68;
		case 3:
			return -9;
		case 4:
			return -127;
		case 5:
			return -9;
		case 6:
			return 61;
		case 7:
			return -174;
		case 8:
			return -24;
		case 9:
			return 72;
		case 10:
			return -113;
		case 11:
			return -51;
		default:
			return -39;
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x060004C0 RID: 1216 RVA: 0x000040F6 File Offset: 0x000022F6
	// (set) Token: 0x06000493 RID: 1171 RVA: 0x00004120 File Offset: 0x00002320
	public static EMLOFJDOMKH QOQONHOOLNE { get; private set; }

	// Token: 0x06000494 RID: 1172 RVA: 0x00004128 File Offset: 0x00002328
	public void EGQGGGLMEBK(EMLOFJDOMKH.ODHLECMMDHQ IHCKGKEJPHM)
	{
		this.MHQMLCJDMMK.Remove(IHCKGKEJPHM);
		if (IHCKGKEJPHM != null)
		{
			UnityEngine.Object.DestroyImmediate(IHCKGKEJPHM.KKONMBCFEJC);
			IHCKGKEJPHM = null;
		}
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x00004128 File Offset: 0x00002328
	public void PLJLPJJIICG(EMLOFJDOMKH.ODHLECMMDHQ IHCKGKEJPHM)
	{
		this.MHQMLCJDMMK.Remove(IHCKGKEJPHM);
		if (IHCKGKEJPHM != null)
		{
			UnityEngine.Object.DestroyImmediate(IHCKGKEJPHM.KKONMBCFEJC);
			IHCKGKEJPHM = null;
		}
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x00046518 File Offset: 0x00044718
	public void BGFCIOCHDDQ()
	{
		EMLOFJDOMKH.IBMCDELFDMI ibmcdelfdmi = new EMLOFJDOMKH.IBMCDELFDMI();
		this.NHNJPDPEDCO = UnityEngine.Time.time;
		ibmcdelfdmi.FOQHHHDJKFG = GGQKBGDGNJN.QOQONHOOLNE.HNEQLQQOMKC.transform.position;
		this.MHQMLCJDMMK.Sort(new Comparison<EMLOFJDOMKH.ODHLECMMDHQ>(ibmcdelfdmi.EDQHHFGDFHK));
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (i < CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO.GMDLOGMNDCJ)
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.KQCKQEPPFJL(false);
			}
			else if (i < -119)
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.NKDPHGCGJIL();
			}
			else
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.EGLBJNMBKQB(false);
			}
		}
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x000465DC File Offset: 0x000447DC
	public void NEPJNPCHQON()
	{
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i] != null)
			{
				UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].KKONMBCFEJC);
			}
		}
		this.MHQMLCJDMMK.Clear();
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x00046630 File Offset: 0x00044830
	public void DQKBOQBOBOM(string HHNBICLDQKI)
	{
		EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ == HHNBICLDQKI)
			{
				odhlecmmdhq = this.MHQMLCJDMMK[i];
				this.MHQMLCJDMMK.RemoveAt(i);
				IL_4C:
				if (odhlecmmdhq != null)
				{
					UnityEngine.Object.DestroyImmediate(odhlecmmdhq.KKONMBCFEJC);
				}
				return;
			}
		}
		goto IL_4C;
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x0004669C File Offset: 0x0004489C
	public void QEONHDCQDIH(FlyUsers CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Users != null)
		{
			FlyUser[] users = CFHEIICNLFD.Users;
			for (int i = 1; i < users.Length; i += 0)
			{
				FlyUser flyUser = users[i];
				EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
				for (int j = 0; j < this.MHQMLCJDMMK.Count; j++)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == flyUser.Username)
					{
						odhlecmmdhq = this.MHQMLCJDMMK[j];
					}
				}
				if (odhlecmmdhq != null && odhlecmmdhq.KKONMBCFEJC == null)
				{
					this.MHQMLCJDMMK.Remove(odhlecmmdhq);
					odhlecmmdhq = null;
				}
				for (int k = 1; k < flyUser.Actions.Length; k += 0)
				{
					switch (flyUser.Actions[k].Action)
					{
					case FlyUserAction.Set:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.QCPFKBQODCL(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Move:
						if (odhlecmmdhq != null && flyUser.Actions[k].Position != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.PJMKLHKFBJM(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
						}
						break;
					case FlyUserAction.Enter:
						if (odhlecmmdhq == null)
						{
							odhlecmmdhq = new EMLOFJDOMKH.ODHLECMMDHQ();
							odhlecmmdhq.KKONMBCFEJC = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW));
							odhlecmmdhq.KKONMBCFEJC.transform.parent = this.MFOFGGHOMEO.transform;
							odhlecmmdhq.FPQBICGEHMJ = flyUser.Username;
							odhlecmmdhq.NFOBFEGCJPB = odhlecmmdhq.KKONMBCFEJC.GetComponent<QDLMGFQHBJQ>();
							odhlecmmdhq.NFOBFEGCJPB.IFNICCLBLOO(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
							odhlecmmdhq.NFOBFEGCJPB.DDIOCHNQJPH(flyUser.Data, flyUser.Username);
							this.MHQMLCJDMMK.Add(odhlecmmdhq);
						}
						else
						{
							odhlecmmdhq.NFOBFEGCJPB.BCHILGCDEFP(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), true);
							odhlecmmdhq.NFOBFEGCJPB.PGBEPJNLDLO(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Leave:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.HDCHLOLKEGL(false);
						}
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x00046ACC File Offset: 0x00044CCC
	public void KNKDPIKHCDO()
	{
		EMLOFJDOMKH.IBMCDELFDMI ibmcdelfdmi = new EMLOFJDOMKH.IBMCDELFDMI();
		this.NHNJPDPEDCO = UnityEngine.Time.time;
		ibmcdelfdmi.FOQHHHDJKFG = GGQKBGDGNJN.QOQONHOOLNE.HNEQLQQOMKC.transform.position;
		this.MHQMLCJDMMK.Sort(new Comparison<EMLOFJDOMKH.ODHLECMMDHQ>(ibmcdelfdmi.QOLDPJNMBBM));
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (i < CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO.GMDLOGMNDCJ)
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.MFONIPHOFGF(true);
			}
			else if (i < 100)
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.JEGNBLJFIEE();
			}
			else
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.Hide(true);
			}
		}
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x00004128 File Offset: 0x00002328
	public void HLGMGIQOCKE(EMLOFJDOMKH.ODHLECMMDHQ IHCKGKEJPHM)
	{
		this.MHQMLCJDMMK.Remove(IHCKGKEJPHM);
		if (IHCKGKEJPHM != null)
		{
			UnityEngine.Object.DestroyImmediate(IHCKGKEJPHM.KKONMBCFEJC);
			IHCKGKEJPHM = null;
		}
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x00046B90 File Offset: 0x00044D90
	public int NDQBBBFNBEE(int CIQFCJGQEMH)
	{
		switch (CIQFCJGQEMH)
		{
		case 0:
			return 12;
		case 1:
			return -114;
		case 2:
			return 93;
		case 3:
			return -26;
		case 4:
			return 10;
		case 5:
			return 181;
		case 6:
			return 114;
		case 7:
			return -20;
		case 8:
			return -117;
		case 9:
			return -78;
		case 10:
			return 103;
		case 11:
			return -68;
		default:
			return -37;
		}
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x00046C10 File Offset: 0x00044E10
	public void NGOLHNMLCLN(string HHNBICLDQKI)
	{
		EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ == HHNBICLDQKI)
			{
				odhlecmmdhq = this.MHQMLCJDMMK[i];
				this.MHQMLCJDMMK.RemoveAt(i);
				IL_4C:
				if (odhlecmmdhq != null)
				{
					UnityEngine.Object.DestroyImmediate(odhlecmmdhq.KKONMBCFEJC);
				}
				return;
			}
		}
		goto IL_4C;
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x00046630 File Offset: 0x00044830
	public void OBBCBBDFFIO(string HHNBICLDQKI)
	{
		EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ == HHNBICLDQKI)
			{
				odhlecmmdhq = this.MHQMLCJDMMK[i];
				this.MHQMLCJDMMK.RemoveAt(i);
				IL_4C:
				if (odhlecmmdhq != null)
				{
					UnityEngine.Object.DestroyImmediate(odhlecmmdhq.KKONMBCFEJC);
				}
				return;
			}
		}
		goto IL_4C;
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x00004128 File Offset: 0x00002328
	public void JDCKNOLMNNL(EMLOFJDOMKH.ODHLECMMDHQ IHCKGKEJPHM)
	{
		this.MHQMLCJDMMK.Remove(IHCKGKEJPHM);
		if (IHCKGKEJPHM != null)
		{
			UnityEngine.Object.DestroyImmediate(IHCKGKEJPHM.KKONMBCFEJC);
			IHCKGKEJPHM = null;
		}
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x00046C7C File Offset: 0x00044E7C
	public void GOFKQQJLBLK(FlyUsers CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Users != null)
		{
			foreach (FlyUser flyUser in CFHEIICNLFD.Users)
			{
				EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
				for (int j = 0; j < this.MHQMLCJDMMK.Count; j++)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == flyUser.Username)
					{
						odhlecmmdhq = this.MHQMLCJDMMK[j];
					}
				}
				if (odhlecmmdhq != null && odhlecmmdhq.KKONMBCFEJC == null)
				{
					this.MHQMLCJDMMK.Remove(odhlecmmdhq);
					odhlecmmdhq = null;
				}
				for (int k = 0; k < flyUser.Actions.Length; k++)
				{
					switch (flyUser.Actions[k].Action)
					{
					case FlyUserAction.Set:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.EQEHGQHOOKL(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Move:
						if (odhlecmmdhq != null && flyUser.Actions[k].Position != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.PJMKLHKFBJM(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), true);
						}
						break;
					case FlyUserAction.Enter:
						if (odhlecmmdhq == null)
						{
							odhlecmmdhq = new EMLOFJDOMKH.ODHLECMMDHQ();
							odhlecmmdhq.KKONMBCFEJC = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW));
							odhlecmmdhq.KKONMBCFEJC.transform.parent = this.MFOFGGHOMEO.transform;
							odhlecmmdhq.FPQBICGEHMJ = flyUser.Username;
							odhlecmmdhq.NFOBFEGCJPB = odhlecmmdhq.KKONMBCFEJC.GetComponent<QDLMGFQHBJQ>();
							odhlecmmdhq.NFOBFEGCJPB.PJMKLHKFBJM(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
							odhlecmmdhq.NFOBFEGCJPB.EQEHGQHOOKL(flyUser.Data, flyUser.Username);
							this.MHQMLCJDMMK.Add(odhlecmmdhq);
						}
						else
						{
							odhlecmmdhq.NFOBFEGCJPB.PJMKLHKFBJM(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
							odhlecmmdhq.NFOBFEGCJPB.EQEHGQHOOKL(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Leave:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.Hide(false);
						}
						break;
					}
				}
			}
		}
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x000470AC File Offset: 0x000452AC
	public int DHFOQCGKBLG(int CIQFCJGQEMH)
	{
		switch (CIQFCJGQEMH)
		{
		case 1:
			return -17;
		case 2:
			return -2;
		case 3:
			return 95;
		case 4:
			return 114;
		case 5:
			return 22;
		case 6:
			return -133;
		case 7:
			return -5;
		case 8:
			return -12;
		case 9:
			return -187;
		case 10:
			return 81;
		case 11:
			return 71;
		case 12:
			return -78;
		default:
			return -24;
		}
	}

	// Token: 0x060004A2 RID: 1186 RVA: 0x0004712C File Offset: 0x0004532C
	public int MDOCIEOINBL(int CIQFCJGQEMH)
	{
		switch (CIQFCJGQEMH)
		{
		case 0:
			return -17;
		case 1:
			return 51;
		case 2:
			return 10;
		case 3:
			return -92;
		case 4:
			return -92;
		case 5:
			return 67;
		case 6:
			return 140;
		case 7:
			return 86;
		case 8:
			return -126;
		case 9:
			return 164;
		case 10:
			return 115;
		case 11:
			return 14;
		default:
			return -88;
		}
	}

	// Token: 0x060004A3 RID: 1187 RVA: 0x000040F6 File Offset: 0x000022F6
	public static EMLOFJDOMKH DPJQQGKEIIF()
	{
		return EMLOFJDOMKH.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x00004120 File Offset: 0x00002320
	private static void MPMLGKJONPK(EMLOFJDOMKH BGBMIEJJQKC)
	{
		EMLOFJDOMKH.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x000471AC File Offset: 0x000453AC
	public string JDNHLMCDGOM(int CIQFCJGQEMH)
	{
		switch (CIQFCJGQEMH)
		{
		case 0:
			return "F3";
		case 1:
			return "W";
		case 2:
			return "spectralthief";
		case 3:
			return "Password Change";
		case 4:
			return "[PG]";
		case 5:
			return " Lvl:";
		case 6:
			return "aegislash";
		case 7:
			return "Assets/AssetBundles/MapAssets2/Models/Unova/com_chip_mado1_mat.mat";
		case 8:
			return "%";
		case 9:
			return "Data/moves";
		case 10:
			return "pressure";
		case 11:
			return "0";
		default:
			return "The Pokémon's intensely focused, and that protects the Pokémon from flinching.";
		}
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x00047240 File Offset: 0x00045440
	public EMLOFJDOMKH.ODHLECMMDHQ NBGQQFGDCEJ(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x00046330 File Offset: 0x00044530
	public EMLOFJDOMKH.ODHLECMMDHQ BMHDIMMDNML(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x000040F6 File Offset: 0x000022F6
	public static EMLOFJDOMKH DGCQMNHFQNH()
	{
		return EMLOFJDOMKH.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x00004148 File Offset: 0x00002348
	private void OHNCEMNBBPF()
	{
		EMLOFJDOMKH.MPMLGKJONPK(this);
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x00047294 File Offset: 0x00045494
	public void GHLIFJCQKGL(FlyUsers CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Users != null)
		{
			FlyUser[] users = CFHEIICNLFD.Users;
			for (int i = 1; i < users.Length; i += 0)
			{
				FlyUser flyUser = users[i];
				EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
				for (int j = 1; j < this.MHQMLCJDMMK.Count; j++)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == flyUser.Username)
					{
						odhlecmmdhq = this.MHQMLCJDMMK[j];
					}
				}
				if (odhlecmmdhq != null && odhlecmmdhq.KKONMBCFEJC == null)
				{
					this.MHQMLCJDMMK.Remove(odhlecmmdhq);
					odhlecmmdhq = null;
				}
				for (int k = 1; k < flyUser.Actions.Length; k += 0)
				{
					switch (flyUser.Actions[k].Action)
					{
					case FlyUserAction.Set:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.QCPFKBQODCL(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Move:
						if (odhlecmmdhq != null && flyUser.Actions[k].Position != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.PJMKLHKFBJM(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
						}
						break;
					case FlyUserAction.Enter:
						if (odhlecmmdhq == null)
						{
							odhlecmmdhq = new EMLOFJDOMKH.ODHLECMMDHQ();
							odhlecmmdhq.KKONMBCFEJC = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW));
							odhlecmmdhq.KKONMBCFEJC.transform.parent = this.MFOFGGHOMEO.transform;
							odhlecmmdhq.FPQBICGEHMJ = flyUser.Username;
							odhlecmmdhq.NFOBFEGCJPB = odhlecmmdhq.KKONMBCFEJC.GetComponent<QDLMGFQHBJQ>();
							odhlecmmdhq.NFOBFEGCJPB.MHDLPKHHHNN(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), true);
							odhlecmmdhq.NFOBFEGCJPB.QCPFKBQODCL(flyUser.Data, flyUser.Username);
							this.MHQMLCJDMMK.Add(odhlecmmdhq);
						}
						else
						{
							odhlecmmdhq.NFOBFEGCJPB.KMDEDOLPPLF(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
							odhlecmmdhq.NFOBFEGCJPB.COPCNGCMQDF(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Leave:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.Hide(false);
						}
						break;
					}
				}
			}
		}
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x00004150 File Offset: 0x00002350
	private void JBJBPIBCBQO()
	{
		if (UnityEngine.Time.time > this.NHNJPDPEDCO + 1725f)
		{
			this.BCCJHMGFJGJ();
		}
	}

	// Token: 0x060004AC RID: 1196 RVA: 0x000462DC File Offset: 0x000444DC
	public void BGHLNKKJOGI()
	{
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i] != null)
			{
				UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].KKONMBCFEJC);
			}
		}
		this.MHQMLCJDMMK.Clear();
	}

	// Token: 0x060004AD RID: 1197 RVA: 0x0000416B File Offset: 0x0000236B
	private void HHIBFNMNEBJ()
	{
		if (UnityEngine.Time.time > this.NHNJPDPEDCO + 70f)
		{
			this.BGFCIOCHDDQ();
		}
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x000476C4 File Offset: 0x000458C4
	public void BCCJHMGFJGJ()
	{
		EMLOFJDOMKH.IBMCDELFDMI ibmcdelfdmi = new EMLOFJDOMKH.IBMCDELFDMI();
		this.NHNJPDPEDCO = UnityEngine.Time.time;
		ibmcdelfdmi.FOQHHHDJKFG = GGQKBGDGNJN.QOQONHOOLNE.HNEQLQQOMKC.transform.position;
		this.MHQMLCJDMMK.Sort(new Comparison<EMLOFJDOMKH.ODHLECMMDHQ>(ibmcdelfdmi.EDQHHFGDFHK));
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (i < CNCJKLNHQBH.MOGQNGEPCEO().KOCBHNQNOJO.GMDLOGMNDCJ)
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.OPHENCLMQHG(false);
			}
			else if (i < 12)
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.NKDPHGCGJIL();
			}
			else
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.EFDILDHBMOK(true);
			}
		}
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x00047788 File Offset: 0x00045988
	public int HNDLNMDNJOI(int CIQFCJGQEMH)
	{
		switch (CIQFCJGQEMH)
		{
		case 1:
			return 16;
		case 2:
			return 17;
		case 3:
			return 21;
		case 4:
			return 22;
		case 5:
			return 41;
		case 6:
			return 198;
		case 7:
			return 142;
		case 8:
			return 384;
		case 9:
			return 151;
		case 10:
			return 145;
		case 11:
			return 83;
		case 12:
			return 792;
		default:
			return 16;
		}
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x000040F6 File Offset: 0x000022F6
	public static EMLOFJDOMKH HGEKKNEPOHK()
	{
		return EMLOFJDOMKH.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x00047808 File Offset: 0x00045A08
	public EMLOFJDOMKH.ODHLECMMDHQ MCBPNKQEEHB(string IHIHHCCEDHQ)
	{
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x00046330 File Offset: 0x00044530
	public EMLOFJDOMKH.ODHLECMMDHQ PONQNQJFIEQ(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x0004785C File Offset: 0x00045A5C
	public string COHGNMFDCJC(int CIQFCJGQEMH)
	{
		switch (CIQFCJGQEMH)
		{
		case 1:
			return "Pidgey";
		case 2:
			return "Pidgeoto";
		case 3:
			return "Spearow";
		case 4:
			return "Fearow";
		case 5:
			return "Zubat";
		case 6:
			return "Murkrow";
		case 7:
			return "Aerodactyl";
		case 8:
			return "MegaRayquaza";
		case 9:
			return "Mew";
		case 10:
			return "Zapdos";
		case 11:
			return "Farfetchd";
		case 12:
			return "Lunala";
		default:
			return "Pidgey";
		}
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x00046C10 File Offset: 0x00044E10
	public void NHLOJNJGMKF(string HHNBICLDQKI)
	{
		EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ == HHNBICLDQKI)
			{
				odhlecmmdhq = this.MHQMLCJDMMK[i];
				this.MHQMLCJDMMK.RemoveAt(i);
				IL_4C:
				if (odhlecmmdhq != null)
				{
					UnityEngine.Object.DestroyImmediate(odhlecmmdhq.KKONMBCFEJC);
				}
				return;
			}
		}
		goto IL_4C;
	}

	// Token: 0x060004B5 RID: 1205 RVA: 0x000040F6 File Offset: 0x000022F6
	public static EMLOFJDOMKH GPMJDKJFHMH()
	{
		return EMLOFJDOMKH.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x060004B6 RID: 1206 RVA: 0x000478F0 File Offset: 0x00045AF0
	public void BEDLDPDHIOE()
	{
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i] != null)
			{
				UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].KKONMBCFEJC);
			}
		}
		this.MHQMLCJDMMK.Clear();
	}

	// Token: 0x060004B7 RID: 1207 RVA: 0x00047944 File Offset: 0x00045B44
	public void JNFMEOEFHOJ()
	{
		EMLOFJDOMKH.IBMCDELFDMI ibmcdelfdmi = new EMLOFJDOMKH.IBMCDELFDMI();
		this.NHNJPDPEDCO = UnityEngine.Time.time;
		ibmcdelfdmi.FOQHHHDJKFG = GGQKBGDGNJN.QOQONHOOLNE.HNEQLQQOMKC.transform.position;
		this.MHQMLCJDMMK.Sort(new Comparison<EMLOFJDOMKH.ODHLECMMDHQ>(ibmcdelfdmi.LGBHQGHDLCB));
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (i < CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO.GMDLOGMNDCJ)
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.LJPLPQLGBHQ(true);
			}
			else if (i < 37)
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.JEGNBLJFIEE();
			}
			else
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.QQFMGLFQQML(true);
			}
		}
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x00047A08 File Offset: 0x00045C08
	public void IIGNQFQIMPB()
	{
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i] != null)
			{
				UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].KKONMBCFEJC);
			}
		}
		this.MHQMLCJDMMK.Clear();
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x000040F6 File Offset: 0x000022F6
	public static EMLOFJDOMKH MMFDGHKCCJF()
	{
		return EMLOFJDOMKH.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x060004BA RID: 1210 RVA: 0x000040F6 File Offset: 0x000022F6
	public static EMLOFJDOMKH BJLGEDCPENQ()
	{
		return EMLOFJDOMKH.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x060004BB RID: 1211 RVA: 0x00047A5C File Offset: 0x00045C5C
	public void MKMFLHPIOEH()
	{
		EMLOFJDOMKH.IBMCDELFDMI ibmcdelfdmi = new EMLOFJDOMKH.IBMCDELFDMI();
		this.NHNJPDPEDCO = UnityEngine.Time.time;
		ibmcdelfdmi.FOQHHHDJKFG = GGQKBGDGNJN.QOQONHOOLNE.HNEQLQQOMKC.transform.position;
		this.MHQMLCJDMMK.Sort(new Comparison<EMLOFJDOMKH.ODHLECMMDHQ>(ibmcdelfdmi.PLBIJPINCJQ));
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (i < CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO.GMDLOGMNDCJ)
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.KQCKQEPPFJL(false);
			}
			else if (i < -4)
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.JEGNBLJFIEE();
			}
			else
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.EFDILDHBMOK(true);
			}
		}
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x00047B20 File Offset: 0x00045D20
	public string OCOINJKQHMC(int CIQFCJGQEMH)
	{
		switch (CIQFCJGQEMH)
		{
		case 1:
			return "Primordial Sea";
		case 2:
			return "-weather";
		case 3:
			return "You do not have enough Pokédollars to purchase these items.";
		case 4:
			return " is confused!\r\n";
		case 5:
			return "replace";
		case 6:
			return "Mega Launcher";
		case 7:
			return "[FF8F00]";
		case 8:
			return ")";
		case 9:
			return "Unable to locate any locations for ";
		case 10:
			return "m_TangentMode";
		case 11:
			return "Left";
		case 12:
			return "|0|";
		default:
			return "_MainTex";
		}
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x00047BB4 File Offset: 0x00045DB4
	public string BHQGGPIJBIE(int CIQFCJGQEMH)
	{
		switch (CIQFCJGQEMH)
		{
		case 0:
			return "_AllowBackwardsRays";
		case 1:
			return "Water";
		case 2:
			return "CombinersArgsAlphaSrc0";
		case 3:
			return "-sethp";
		case 4:
			return " is loafing around!\r\n";
		case 5:
			return "17";
		case 6:
			return "Slot Machine";
		case 7:
			return "Mold Breaker";
		case 8:
			return "_";
		case 9:
			return "insomnia";
		case 10:
			return "' on ";
		case 11:
			return " switched its Attack and Defense!\r\n";
		default:
			return "!\r\n";
		}
	}

	// Token: 0x060004BF RID: 1215 RVA: 0x00047C48 File Offset: 0x00045E48
	public void JNPQFPHJIQE()
	{
		EMLOFJDOMKH.IBMCDELFDMI ibmcdelfdmi = new EMLOFJDOMKH.IBMCDELFDMI();
		this.NHNJPDPEDCO = UnityEngine.Time.time;
		ibmcdelfdmi.FOQHHHDJKFG = GGQKBGDGNJN.QOQONHOOLNE.HNEQLQQOMKC.transform.position;
		this.MHQMLCJDMMK.Sort(new Comparison<EMLOFJDOMKH.ODHLECMMDHQ>(ibmcdelfdmi.IMMKOPFGNKC));
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (i < CNCJKLNHQBH.MOGQNGEPCEO().KOCBHNQNOJO.GMDLOGMNDCJ)
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.MFONIPHOFGF(false);
			}
			else if (i < 81)
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.NKDPHGCGJIL();
			}
			else
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.Hide(true);
			}
		}
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x000462DC File Offset: 0x000444DC
	public void FOGOOHQEDHE()
	{
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i] != null)
			{
				UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].KKONMBCFEJC);
			}
		}
		this.MHQMLCJDMMK.Clear();
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x00046330 File Offset: 0x00044530
	public EMLOFJDOMKH.ODHLECMMDHQ GMNHGNPKDML(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x000040F6 File Offset: 0x000022F6
	public static EMLOFJDOMKH BDPEQNCNPJO()
	{
		return EMLOFJDOMKH.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x00047D0C File Offset: 0x00045F0C
	public string PQEHJMPCOBM(int CIQFCJGQEMH)
	{
		switch (CIQFCJGQEMH)
		{
		case 1:
			return "\nNight";
		case 2:
			return "TradeColliders";
		case 3:
			return "<|>";
		case 4:
			return "_ChannelMixerRed";
		case 5:
			return "_Dissolve";
		case 6:
			return "heartswap";
		case 7:
			return "_DestortionShiftY";
		case 8:
			return "Hi-Score: ";
		case 9:
			return "raindance";
		case 10:
			return "Fearow";
		case 11:
			return "Player/Hats/";
		case 12:
			return "Sky";
		default:
			return "/goto ";
		}
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x00004120 File Offset: 0x00002320
	private static void HFCCMJEGOHJ(EMLOFJDOMKH BGBMIEJJQKC)
	{
		EMLOFJDOMKH.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x00047DA0 File Offset: 0x00045FA0
	public void JIGNCBKLQQO()
	{
		EMLOFJDOMKH.IBMCDELFDMI ibmcdelfdmi = new EMLOFJDOMKH.IBMCDELFDMI();
		this.NHNJPDPEDCO = UnityEngine.Time.time;
		ibmcdelfdmi.FOQHHHDJKFG = GGQKBGDGNJN.QOQONHOOLNE.HNEQLQQOMKC.transform.position;
		this.MHQMLCJDMMK.Sort(new Comparison<EMLOFJDOMKH.ODHLECMMDHQ>(ibmcdelfdmi.QOLDPJNMBBM));
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (i < CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO.GMDLOGMNDCJ)
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.KQCKQEPPFJL(true);
			}
			else if (i < 86)
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.DKCGOGOKKEK();
			}
			else
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.EFDILDHBMOK(false);
			}
		}
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x00047E64 File Offset: 0x00046064
	public void FBEKELQKKHO()
	{
		EMLOFJDOMKH.IBMCDELFDMI ibmcdelfdmi = new EMLOFJDOMKH.IBMCDELFDMI();
		this.NHNJPDPEDCO = UnityEngine.Time.time;
		ibmcdelfdmi.FOQHHHDJKFG = GGQKBGDGNJN.QOQONHOOLNE.HNEQLQQOMKC.transform.position;
		this.MHQMLCJDMMK.Sort(new Comparison<EMLOFJDOMKH.ODHLECMMDHQ>(ibmcdelfdmi.OCGHFEHKILC));
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (i < CNCJKLNHQBH.BJLGEDCPENQ().KOCBHNQNOJO.GMDLOGMNDCJ)
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.OPHENCLMQHG(false);
			}
			else if (i < 95)
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.DKCGOGOKKEK();
			}
			else
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.POFOEMPKIQE(true);
			}
		}
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x00047808 File Offset: 0x00045A08
	public EMLOFJDOMKH.ODHLECMMDHQ MMDCDJBKBMP(string IHIHHCCEDHQ)
	{
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x00004128 File Offset: 0x00002328
	public void LKDKKJCEQIF(EMLOFJDOMKH.ODHLECMMDHQ IHCKGKEJPHM)
	{
		this.MHQMLCJDMMK.Remove(IHCKGKEJPHM);
		if (IHCKGKEJPHM != null)
		{
			UnityEngine.Object.DestroyImmediate(IHCKGKEJPHM.KKONMBCFEJC);
			IHCKGKEJPHM = null;
		}
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x00004199 File Offset: 0x00002399
	private void COGJQEEGCFB()
	{
		EMLOFJDOMKH.HFCCMJEGOHJ(this);
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x000041A1 File Offset: 0x000023A1
	private void NNPPKOGDNOM()
	{
		EMLOFJDOMKH.QHCIGKBBJQO(this);
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x00047F28 File Offset: 0x00046128
	public void KDDIPKHNDPP(FlyUsers CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Users != null)
		{
			foreach (FlyUser flyUser in CFHEIICNLFD.Users)
			{
				EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
				for (int j = 0; j < this.MHQMLCJDMMK.Count; j++)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == flyUser.Username)
					{
						odhlecmmdhq = this.MHQMLCJDMMK[j];
					}
				}
				if (odhlecmmdhq != null && odhlecmmdhq.KKONMBCFEJC == null)
				{
					this.MHQMLCJDMMK.Remove(odhlecmmdhq);
					odhlecmmdhq = null;
				}
				for (int k = 1; k < flyUser.Actions.Length; k++)
				{
					switch (flyUser.Actions[k].Action)
					{
					case FlyUserAction.Set:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.DDIOCHNQJPH(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Move:
						if (odhlecmmdhq != null && flyUser.Actions[k].Position != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.MHDLPKHHHNN(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), true);
						}
						break;
					case FlyUserAction.Enter:
						if (odhlecmmdhq == null)
						{
							odhlecmmdhq = new EMLOFJDOMKH.ODHLECMMDHQ();
							odhlecmmdhq.KKONMBCFEJC = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW));
							odhlecmmdhq.KKONMBCFEJC.transform.parent = this.MFOFGGHOMEO.transform;
							odhlecmmdhq.FPQBICGEHMJ = flyUser.Username;
							odhlecmmdhq.NFOBFEGCJPB = odhlecmmdhq.KKONMBCFEJC.GetComponent<QDLMGFQHBJQ>();
							odhlecmmdhq.NFOBFEGCJPB.OMNHFENGIDG(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
							odhlecmmdhq.NFOBFEGCJPB.QCPFKBQODCL(flyUser.Data, flyUser.Username);
							this.MHQMLCJDMMK.Add(odhlecmmdhq);
						}
						else
						{
							odhlecmmdhq.NFOBFEGCJPB.OMNHFENGIDG(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
							odhlecmmdhq.NFOBFEGCJPB.QCPFKBQODCL(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Leave:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.PFQNKLLLBBP(false);
						}
						break;
					}
				}
			}
		}
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x00047A08 File Offset: 0x00045C08
	public void JHCBNOQBGKB()
	{
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i] != null)
			{
				UnityEngine.Object.Destroy(this.MHQMLCJDMMK[i].KKONMBCFEJC);
			}
		}
		this.MHQMLCJDMMK.Clear();
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x00048358 File Offset: 0x00046558
	public int LIOGKJNHMLG(int CIQFCJGQEMH)
	{
		switch (CIQFCJGQEMH)
		{
		case 0:
			return -96;
		case 1:
			return -26;
		case 2:
			return 34;
		case 3:
			return -6;
		case 4:
			return -39;
		case 5:
			return 87;
		case 6:
			return -199;
		case 7:
			return 147;
		case 8:
			return -195;
		case 9:
			return 43;
		case 10:
			return -20;
		case 11:
			return -11;
		default:
			return 77;
		}
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x000483D8 File Offset: 0x000465D8
	public int GGEGPBPBLCN(int CIQFCJGQEMH)
	{
		switch (CIQFCJGQEMH)
		{
		case 0:
			return 79;
		case 1:
			return 50;
		case 2:
			return -78;
		case 3:
			return -54;
		case 4:
			return -5;
		case 5:
			return 102;
		case 6:
			return 74;
		case 7:
			return -139;
		case 8:
			return 190;
		case 9:
			return 151;
		case 10:
			return 89;
		case 11:
			return 161;
		default:
			return -123;
		}
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x00048458 File Offset: 0x00046658
	public void GIGIKIGGBCD(string HHNBICLDQKI)
	{
		EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ == HHNBICLDQKI)
			{
				odhlecmmdhq = this.MHQMLCJDMMK[i];
				this.MHQMLCJDMMK.RemoveAt(i);
				IL_4C:
				if (odhlecmmdhq != null)
				{
					UnityEngine.Object.DestroyImmediate(odhlecmmdhq.KKONMBCFEJC);
				}
				return;
			}
		}
		goto IL_4C;
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x000484C4 File Offset: 0x000466C4
	public void NHIBDDJLGIO(string HHNBICLDQKI)
	{
		EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ == HHNBICLDQKI)
			{
				odhlecmmdhq = this.MHQMLCJDMMK[i];
				this.MHQMLCJDMMK.RemoveAt(i);
				IL_4C:
				if (odhlecmmdhq != null)
				{
					UnityEngine.Object.DestroyImmediate(odhlecmmdhq.KKONMBCFEJC);
				}
				return;
			}
		}
		goto IL_4C;
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x00048530 File Offset: 0x00046730
	public void IHODGLLDGOH(FlyUsers CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Users != null)
		{
			FlyUser[] users = CFHEIICNLFD.Users;
			for (int i = 1; i < users.Length; i++)
			{
				FlyUser flyUser = users[i];
				EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
				for (int j = 1; j < this.MHQMLCJDMMK.Count; j++)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == flyUser.Username)
					{
						odhlecmmdhq = this.MHQMLCJDMMK[j];
					}
				}
				if (odhlecmmdhq != null && odhlecmmdhq.KKONMBCFEJC == null)
				{
					this.MHQMLCJDMMK.Remove(odhlecmmdhq);
					odhlecmmdhq = null;
				}
				for (int k = 0; k < flyUser.Actions.Length; k++)
				{
					switch (flyUser.Actions[k].Action)
					{
					case FlyUserAction.Set:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.EQEHGQHOOKL(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Move:
						if (odhlecmmdhq != null && flyUser.Actions[k].Position != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.EODNODBGOIK(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
						}
						break;
					case FlyUserAction.Enter:
						if (odhlecmmdhq == null)
						{
							odhlecmmdhq = new EMLOFJDOMKH.ODHLECMMDHQ();
							odhlecmmdhq.KKONMBCFEJC = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW));
							odhlecmmdhq.KKONMBCFEJC.transform.parent = this.MFOFGGHOMEO.transform;
							odhlecmmdhq.FPQBICGEHMJ = flyUser.Username;
							odhlecmmdhq.NFOBFEGCJPB = odhlecmmdhq.KKONMBCFEJC.GetComponent<QDLMGFQHBJQ>();
							odhlecmmdhq.NFOBFEGCJPB.OMNHFENGIDG(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
							odhlecmmdhq.NFOBFEGCJPB.QCPFKBQODCL(flyUser.Data, flyUser.Username);
							this.MHQMLCJDMMK.Add(odhlecmmdhq);
						}
						else
						{
							odhlecmmdhq.NFOBFEGCJPB.KMDEDOLPPLF(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
							odhlecmmdhq.NFOBFEGCJPB.DDIOCHNQJPH(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Leave:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.FDDBHCGOJLP(false);
						}
						break;
					}
				}
			}
		}
	}

	// Token: 0x060004D3 RID: 1235 RVA: 0x000040F6 File Offset: 0x000022F6
	public static EMLOFJDOMKH HGLDHNMOLPD()
	{
		return EMLOFJDOMKH.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x00004128 File Offset: 0x00002328
	public void BBBPHLPCIDO(EMLOFJDOMKH.ODHLECMMDHQ IHCKGKEJPHM)
	{
		this.MHQMLCJDMMK.Remove(IHCKGKEJPHM);
		if (IHCKGKEJPHM != null)
		{
			UnityEngine.Object.DestroyImmediate(IHCKGKEJPHM.KKONMBCFEJC);
			IHCKGKEJPHM = null;
		}
	}

	// Token: 0x060004D5 RID: 1237 RVA: 0x00048960 File Offset: 0x00046B60
	public void GGDNPKFCOFP(FlyUsers CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Users != null)
		{
			FlyUser[] users = CFHEIICNLFD.Users;
			for (int i = 1; i < users.Length; i += 0)
			{
				FlyUser flyUser = users[i];
				EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
				for (int j = 0; j < this.MHQMLCJDMMK.Count; j++)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == flyUser.Username)
					{
						odhlecmmdhq = this.MHQMLCJDMMK[j];
					}
				}
				if (odhlecmmdhq != null && odhlecmmdhq.KKONMBCFEJC == null)
				{
					this.MHQMLCJDMMK.Remove(odhlecmmdhq);
					odhlecmmdhq = null;
				}
				for (int k = 0; k < flyUser.Actions.Length; k++)
				{
					switch (flyUser.Actions[k].Action)
					{
					case FlyUserAction.Set:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.LEFDQKGBBQQ(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Move:
						if (odhlecmmdhq != null && flyUser.Actions[k].Position != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.PJMKLHKFBJM(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
						}
						break;
					case FlyUserAction.Enter:
						if (odhlecmmdhq == null)
						{
							odhlecmmdhq = new EMLOFJDOMKH.ODHLECMMDHQ();
							odhlecmmdhq.KKONMBCFEJC = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW));
							odhlecmmdhq.KKONMBCFEJC.transform.parent = this.MFOFGGHOMEO.transform;
							odhlecmmdhq.FPQBICGEHMJ = flyUser.Username;
							odhlecmmdhq.NFOBFEGCJPB = odhlecmmdhq.KKONMBCFEJC.GetComponent<QDLMGFQHBJQ>();
							odhlecmmdhq.NFOBFEGCJPB.KMDEDOLPPLF(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), true);
							odhlecmmdhq.NFOBFEGCJPB.EQEHGQHOOKL(flyUser.Data, flyUser.Username);
							this.MHQMLCJDMMK.Add(odhlecmmdhq);
						}
						else
						{
							odhlecmmdhq.NFOBFEGCJPB.KMDEDOLPPLF(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
							odhlecmmdhq.NFOBFEGCJPB.COPCNGCMQDF(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Leave:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.PFQNKLLLBBP(true);
						}
						break;
					}
				}
			}
		}
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x00046630 File Offset: 0x00044830
	public void LQPMQHHPMFB(string HHNBICLDQKI)
	{
		EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ == HHNBICLDQKI)
			{
				odhlecmmdhq = this.MHQMLCJDMMK[i];
				this.MHQMLCJDMMK.RemoveAt(i);
				IL_4C:
				if (odhlecmmdhq != null)
				{
					UnityEngine.Object.DestroyImmediate(odhlecmmdhq.KKONMBCFEJC);
				}
				return;
			}
		}
		goto IL_4C;
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x00046C10 File Offset: 0x00044E10
	public void EDMNQJQIKHB(string HHNBICLDQKI)
	{
		EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ == HHNBICLDQKI)
			{
				odhlecmmdhq = this.MHQMLCJDMMK[i];
				this.MHQMLCJDMMK.RemoveAt(i);
				IL_4C:
				if (odhlecmmdhq != null)
				{
					UnityEngine.Object.DestroyImmediate(odhlecmmdhq.KKONMBCFEJC);
				}
				return;
			}
		}
		goto IL_4C;
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x00048D90 File Offset: 0x00046F90
	public void EGQFGEIIMQC()
	{
		EMLOFJDOMKH.IBMCDELFDMI ibmcdelfdmi = new EMLOFJDOMKH.IBMCDELFDMI();
		this.NHNJPDPEDCO = UnityEngine.Time.time;
		ibmcdelfdmi.FOQHHHDJKFG = GGQKBGDGNJN.QOQONHOOLNE.HNEQLQQOMKC.transform.position;
		this.MHQMLCJDMMK.Sort(new Comparison<EMLOFJDOMKH.ODHLECMMDHQ>(ibmcdelfdmi.PCNBJBKOCJH));
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (i < CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO.GMDLOGMNDCJ)
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.MFONIPHOFGF(false);
			}
			else if (i < -32)
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.JEGNBLJFIEE();
			}
			else
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.HDCHLOLKEGL(true);
			}
		}
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x000041A9 File Offset: 0x000023A9
	private void KCBFHOIENIQ()
	{
		if (UnityEngine.Time.time > this.NHNJPDPEDCO + 1414f)
		{
			this.JNPQFPHJIQE();
		}
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x000040FD File Offset: 0x000022FD
	private void NJPBKPKNDLD()
	{
		EMLOFJDOMKH.QOQONHOOLNE = this;
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x000041C4 File Offset: 0x000023C4
	private void EQIMMIBMQGP()
	{
		if (UnityEngine.Time.time > this.NHNJPDPEDCO + 1432f)
		{
			this.KNKDPIKHCDO();
		}
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x00048E54 File Offset: 0x00047054
	public EMLOFJDOMKH.ODHLECMMDHQ MDPKPBDDNIH(string IHIHHCCEDHQ)
	{
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x00047808 File Offset: 0x00045A08
	public EMLOFJDOMKH.ODHLECMMDHQ FNMHMCQMLED(string IHIHHCCEDHQ)
	{
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x00048EA8 File Offset: 0x000470A8
	public void DIKCHMPMNJP(FlyUsers CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Users != null)
		{
			FlyUser[] users = CFHEIICNLFD.Users;
			for (int i = 1; i < users.Length; i += 0)
			{
				FlyUser flyUser = users[i];
				EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
				for (int j = 1; j < this.MHQMLCJDMMK.Count; j++)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == flyUser.Username)
					{
						odhlecmmdhq = this.MHQMLCJDMMK[j];
					}
				}
				if (odhlecmmdhq != null && odhlecmmdhq.KKONMBCFEJC == null)
				{
					this.MHQMLCJDMMK.Remove(odhlecmmdhq);
					odhlecmmdhq = null;
				}
				for (int k = 1; k < flyUser.Actions.Length; k++)
				{
					switch (flyUser.Actions[k].Action)
					{
					case FlyUserAction.Set:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.OGIIJNDQEBK(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Move:
						if (odhlecmmdhq != null && flyUser.Actions[k].Position != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.BCHILGCDEFP(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
						}
						break;
					case FlyUserAction.Enter:
						if (odhlecmmdhq == null)
						{
							odhlecmmdhq = new EMLOFJDOMKH.ODHLECMMDHQ();
							odhlecmmdhq.KKONMBCFEJC = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW));
							odhlecmmdhq.KKONMBCFEJC.transform.parent = this.MFOFGGHOMEO.transform;
							odhlecmmdhq.FPQBICGEHMJ = flyUser.Username;
							odhlecmmdhq.NFOBFEGCJPB = odhlecmmdhq.KKONMBCFEJC.GetComponent<QDLMGFQHBJQ>();
							odhlecmmdhq.NFOBFEGCJPB.BCHILGCDEFP(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
							odhlecmmdhq.NFOBFEGCJPB.QCPFKBQODCL(flyUser.Data, flyUser.Username);
							this.MHQMLCJDMMK.Add(odhlecmmdhq);
						}
						else
						{
							odhlecmmdhq.NFOBFEGCJPB.IFNICCLBLOO(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
							odhlecmmdhq.NFOBFEGCJPB.LEFDQKGBBQQ(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Leave:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.LECIOLIFGEN(false);
						}
						break;
					}
				}
			}
		}
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x000492D8 File Offset: 0x000474D8
	public int FKHCHGDNENN(int CIQFCJGQEMH)
	{
		switch (CIQFCJGQEMH)
		{
		case 1:
			return -91;
		case 2:
			return -33;
		case 3:
			return -14;
		case 4:
			return -105;
		case 5:
			return 101;
		case 6:
			return -88;
		case 7:
			return 133;
		case 8:
			return 150;
		case 9:
			return -99;
		case 10:
			return 98;
		case 11:
			return -28;
		case 12:
			return 65;
		default:
			return 67;
		}
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x00048458 File Offset: 0x00046658
	public void LBPPHNDNPMG(string HHNBICLDQKI)
	{
		EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ == HHNBICLDQKI)
			{
				odhlecmmdhq = this.MHQMLCJDMMK[i];
				this.MHQMLCJDMMK.RemoveAt(i);
				IL_4C:
				if (odhlecmmdhq != null)
				{
					UnityEngine.Object.DestroyImmediate(odhlecmmdhq.KKONMBCFEJC);
				}
				return;
			}
		}
		goto IL_4C;
	}

	// Token: 0x060004E1 RID: 1249 RVA: 0x000040F6 File Offset: 0x000022F6
	public static EMLOFJDOMKH CLPQIKCDHPP()
	{
		return EMLOFJDOMKH.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x000040F6 File Offset: 0x000022F6
	public static EMLOFJDOMKH ODJQHLJCFGH()
	{
		return EMLOFJDOMKH.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x00004120 File Offset: 0x00002320
	private static void QHCIGKBBJQO(EMLOFJDOMKH BGBMIEJJQKC)
	{
		EMLOFJDOMKH.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x00049358 File Offset: 0x00047558
	public void HODKOOOFPQF(FlyUsers CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Users != null)
		{
			foreach (FlyUser flyUser in CFHEIICNLFD.Users)
			{
				EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
				for (int j = 0; j < this.MHQMLCJDMMK.Count; j++)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == flyUser.Username)
					{
						odhlecmmdhq = this.MHQMLCJDMMK[j];
					}
				}
				if (odhlecmmdhq != null && odhlecmmdhq.KKONMBCFEJC == null)
				{
					this.MHQMLCJDMMK.Remove(odhlecmmdhq);
					odhlecmmdhq = null;
				}
				for (int k = 0; k < flyUser.Actions.Length; k += 0)
				{
					switch (flyUser.Actions[k].Action)
					{
					case FlyUserAction.Set:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.PGBEPJNLDLO(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Move:
						if (odhlecmmdhq != null && flyUser.Actions[k].Position != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.KMDEDOLPPLF(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
						}
						break;
					case FlyUserAction.Enter:
						if (odhlecmmdhq == null)
						{
							odhlecmmdhq = new EMLOFJDOMKH.ODHLECMMDHQ();
							odhlecmmdhq.KKONMBCFEJC = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW));
							odhlecmmdhq.KKONMBCFEJC.transform.parent = this.MFOFGGHOMEO.transform;
							odhlecmmdhq.FPQBICGEHMJ = flyUser.Username;
							odhlecmmdhq.NFOBFEGCJPB = odhlecmmdhq.KKONMBCFEJC.GetComponent<QDLMGFQHBJQ>();
							odhlecmmdhq.NFOBFEGCJPB.OMNHFENGIDG(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
							odhlecmmdhq.NFOBFEGCJPB.OGIIJNDQEBK(flyUser.Data, flyUser.Username);
							this.MHQMLCJDMMK.Add(odhlecmmdhq);
						}
						else
						{
							odhlecmmdhq.NFOBFEGCJPB.PJMKLHKFBJM(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
							odhlecmmdhq.NFOBFEGCJPB.DDIOCHNQJPH(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Leave:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.GHGOHOBBDEF(true);
						}
						break;
					}
				}
			}
		}
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x00004128 File Offset: 0x00002328
	public void QJENQBFKIHG(EMLOFJDOMKH.ODHLECMMDHQ IHCKGKEJPHM)
	{
		this.MHQMLCJDMMK.Remove(IHCKGKEJPHM);
		if (IHCKGKEJPHM != null)
		{
			UnityEngine.Object.DestroyImmediate(IHCKGKEJPHM.KKONMBCFEJC);
			IHCKGKEJPHM = null;
		}
	}

	// Token: 0x060004E6 RID: 1254 RVA: 0x000041DF File Offset: 0x000023DF
	private void Update()
	{
		if (UnityEngine.Time.time > this.NHNJPDPEDCO + 0.05f)
		{
			this.KNKDPIKHCDO();
		}
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x00049788 File Offset: 0x00047988
	public void IHGDOQBBQJK(FlyUsers CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Users != null)
		{
			FlyUser[] users = CFHEIICNLFD.Users;
			for (int i = 0; i < users.Length; i += 0)
			{
				FlyUser flyUser = users[i];
				EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
				for (int j = 1; j < this.MHQMLCJDMMK.Count; j++)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == flyUser.Username)
					{
						odhlecmmdhq = this.MHQMLCJDMMK[j];
					}
				}
				if (odhlecmmdhq != null && odhlecmmdhq.KKONMBCFEJC == null)
				{
					this.MHQMLCJDMMK.Remove(odhlecmmdhq);
					odhlecmmdhq = null;
				}
				for (int k = 0; k < flyUser.Actions.Length; k++)
				{
					switch (flyUser.Actions[k].Action)
					{
					case FlyUserAction.Set:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.OGIIJNDQEBK(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Move:
						if (odhlecmmdhq != null && flyUser.Actions[k].Position != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.MHDLPKHHHNN(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
						}
						break;
					case FlyUserAction.Enter:
						if (odhlecmmdhq == null)
						{
							odhlecmmdhq = new EMLOFJDOMKH.ODHLECMMDHQ();
							odhlecmmdhq.KKONMBCFEJC = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW));
							odhlecmmdhq.KKONMBCFEJC.transform.parent = this.MFOFGGHOMEO.transform;
							odhlecmmdhq.FPQBICGEHMJ = flyUser.Username;
							odhlecmmdhq.NFOBFEGCJPB = odhlecmmdhq.KKONMBCFEJC.GetComponent<QDLMGFQHBJQ>();
							odhlecmmdhq.NFOBFEGCJPB.IFNICCLBLOO(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
							odhlecmmdhq.NFOBFEGCJPB.DDIOCHNQJPH(flyUser.Data, flyUser.Username);
							this.MHQMLCJDMMK.Add(odhlecmmdhq);
						}
						else
						{
							odhlecmmdhq.NFOBFEGCJPB.MHDLPKHHHNN(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
							odhlecmmdhq.NFOBFEGCJPB.LEFDQKGBBQQ(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Leave:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.HDCHLOLKEGL(false);
						}
						break;
					}
				}
			}
		}
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x00049BB8 File Offset: 0x00047DB8
	public void HKJIEGMPKCJ()
	{
		EMLOFJDOMKH.IBMCDELFDMI ibmcdelfdmi = new EMLOFJDOMKH.IBMCDELFDMI();
		this.NHNJPDPEDCO = UnityEngine.Time.time;
		ibmcdelfdmi.FOQHHHDJKFG = GGQKBGDGNJN.QOQONHOOLNE.HNEQLQQOMKC.transform.position;
		this.MHQMLCJDMMK.Sort(new Comparison<EMLOFJDOMKH.ODHLECMMDHQ>(ibmcdelfdmi.IMMKOPFGNKC));
		for (int i = 1; i < this.MHQMLCJDMMK.Count; i++)
		{
			if (i < CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO.GMDLOGMNDCJ)
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.FBHNDOJQHLB(true);
			}
			else if (i < 119)
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.JEGNBLJFIEE();
			}
			else
			{
				this.MHQMLCJDMMK[i].NFOBFEGCJPB.HDCHLOLKEGL(true);
			}
		}
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x00049C7C File Offset: 0x00047E7C
	public void LBMCFIIQLJO(FlyUsers CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Users != null)
		{
			foreach (FlyUser flyUser in CFHEIICNLFD.Users)
			{
				EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
				for (int j = 0; j < this.MHQMLCJDMMK.Count; j++)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == flyUser.Username)
					{
						odhlecmmdhq = this.MHQMLCJDMMK[j];
					}
				}
				if (odhlecmmdhq != null && odhlecmmdhq.KKONMBCFEJC == null)
				{
					this.MHQMLCJDMMK.Remove(odhlecmmdhq);
					odhlecmmdhq = null;
				}
				for (int k = 1; k < flyUser.Actions.Length; k += 0)
				{
					switch (flyUser.Actions[k].Action)
					{
					case FlyUserAction.Set:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.EQEHGQHOOKL(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Move:
						if (odhlecmmdhq != null && flyUser.Actions[k].Position != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.KMDEDOLPPLF(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
						}
						break;
					case FlyUserAction.Enter:
						if (odhlecmmdhq == null)
						{
							odhlecmmdhq = new EMLOFJDOMKH.ODHLECMMDHQ();
							odhlecmmdhq.KKONMBCFEJC = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW));
							odhlecmmdhq.KKONMBCFEJC.transform.parent = this.MFOFGGHOMEO.transform;
							odhlecmmdhq.FPQBICGEHMJ = flyUser.Username;
							odhlecmmdhq.NFOBFEGCJPB = odhlecmmdhq.KKONMBCFEJC.GetComponent<QDLMGFQHBJQ>();
							odhlecmmdhq.NFOBFEGCJPB.EODNODBGOIK(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
							odhlecmmdhq.NFOBFEGCJPB.PGBEPJNLDLO(flyUser.Data, flyUser.Username);
							this.MHQMLCJDMMK.Add(odhlecmmdhq);
						}
						else
						{
							odhlecmmdhq.NFOBFEGCJPB.MHDLPKHHHNN(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), true);
							odhlecmmdhq.NFOBFEGCJPB.EQEHGQHOOKL(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Leave:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.EGLBJNMBKQB(false);
						}
						break;
					}
				}
			}
		}
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x000041FA File Offset: 0x000023FA
	private void PNHPFOHOGMC()
	{
		if (UnityEngine.Time.time > this.NHNJPDPEDCO + 306f)
		{
			this.JNFMEOEFHOJ();
		}
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x000040F6 File Offset: 0x000022F6
	public static EMLOFJDOMKH BCQGHQGLLPF()
	{
		return EMLOFJDOMKH.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x00047240 File Offset: 0x00045440
	public EMLOFJDOMKH.ODHLECMMDHQ KEHEGEHPGFM(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.MHQMLCJDMMK.Count; i += 0)
		{
			if (this.MHQMLCJDMMK[i].FPQBICGEHMJ.ToLowerInvariant() == IHIHHCCEDHQ.ToLowerInvariant())
			{
				return this.MHQMLCJDMMK[i];
			}
		}
		return null;
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x0004A0AC File Offset: 0x000482AC
	public void KKNKGFQNCIF(FlyUsers CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Users != null)
		{
			FlyUser[] users = CFHEIICNLFD.Users;
			for (int i = 1; i < users.Length; i += 0)
			{
				FlyUser flyUser = users[i];
				EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
				for (int j = 1; j < this.MHQMLCJDMMK.Count; j += 0)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == flyUser.Username)
					{
						odhlecmmdhq = this.MHQMLCJDMMK[j];
					}
				}
				if (odhlecmmdhq != null && odhlecmmdhq.KKONMBCFEJC == null)
				{
					this.MHQMLCJDMMK.Remove(odhlecmmdhq);
					odhlecmmdhq = null;
				}
				for (int k = 1; k < flyUser.Actions.Length; k++)
				{
					switch (flyUser.Actions[k].Action)
					{
					case FlyUserAction.Set:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.DDIOCHNQJPH(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Move:
						if (odhlecmmdhq != null && flyUser.Actions[k].Position != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.EODNODBGOIK(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), true);
						}
						break;
					case FlyUserAction.Enter:
						if (odhlecmmdhq == null)
						{
							odhlecmmdhq = new EMLOFJDOMKH.ODHLECMMDHQ();
							odhlecmmdhq.KKONMBCFEJC = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW));
							odhlecmmdhq.KKONMBCFEJC.transform.parent = this.MFOFGGHOMEO.transform;
							odhlecmmdhq.FPQBICGEHMJ = flyUser.Username;
							odhlecmmdhq.NFOBFEGCJPB = odhlecmmdhq.KKONMBCFEJC.GetComponent<QDLMGFQHBJQ>();
							odhlecmmdhq.NFOBFEGCJPB.PJMKLHKFBJM(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), true);
							odhlecmmdhq.NFOBFEGCJPB.DDIOCHNQJPH(flyUser.Data, flyUser.Username);
							this.MHQMLCJDMMK.Add(odhlecmmdhq);
						}
						else
						{
							odhlecmmdhq.NFOBFEGCJPB.EODNODBGOIK(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), true);
							odhlecmmdhq.NFOBFEGCJPB.EQEHGQHOOKL(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Leave:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.FDDBHCGOJLP(true);
						}
						break;
					}
				}
			}
		}
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x0004A4DC File Offset: 0x000486DC
	public void MOONIJGOECJ(FlyUsers CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Users != null)
		{
			FlyUser[] users = CFHEIICNLFD.Users;
			for (int i = 1; i < users.Length; i++)
			{
				FlyUser flyUser = users[i];
				EMLOFJDOMKH.ODHLECMMDHQ odhlecmmdhq = null;
				for (int j = 0; j < this.MHQMLCJDMMK.Count; j += 0)
				{
					if (this.MHQMLCJDMMK[j].FPQBICGEHMJ == flyUser.Username)
					{
						odhlecmmdhq = this.MHQMLCJDMMK[j];
					}
				}
				if (odhlecmmdhq != null && odhlecmmdhq.KKONMBCFEJC == null)
				{
					this.MHQMLCJDMMK.Remove(odhlecmmdhq);
					odhlecmmdhq = null;
				}
				for (int k = 1; k < flyUser.Actions.Length; k++)
				{
					switch (flyUser.Actions[k].Action)
					{
					case FlyUserAction.Set:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.OGIIJNDQEBK(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Move:
						if (odhlecmmdhq != null && flyUser.Actions[k].Position != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.KMDEDOLPPLF(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
						}
						break;
					case FlyUserAction.Enter:
						if (odhlecmmdhq == null)
						{
							odhlecmmdhq = new EMLOFJDOMKH.ODHLECMMDHQ();
							odhlecmmdhq.KKONMBCFEJC = UnityEngine.Object.Instantiate<GameObject>(this.MIMDIBNOGPC, new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW));
							odhlecmmdhq.KKONMBCFEJC.transform.parent = this.MFOFGGHOMEO.transform;
							odhlecmmdhq.FPQBICGEHMJ = flyUser.Username;
							odhlecmmdhq.NFOBFEGCJPB = odhlecmmdhq.KKONMBCFEJC.GetComponent<QDLMGFQHBJQ>();
							odhlecmmdhq.NFOBFEGCJPB.KMDEDOLPPLF(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), false);
							odhlecmmdhq.NFOBFEGCJPB.DDIOCHNQJPH(flyUser.Data, flyUser.Username);
							this.MHQMLCJDMMK.Add(odhlecmmdhq);
						}
						else
						{
							odhlecmmdhq.NFOBFEGCJPB.OMNHFENGIDG(new Vector3(flyUser.Actions[k].Position.PosX, flyUser.Actions[k].Position.PosY, flyUser.Actions[k].Position.PosZ), new Quaternion(flyUser.Actions[k].Position.RotX, flyUser.Actions[k].Position.RotY, flyUser.Actions[k].Position.RotZ, flyUser.Actions[k].Position.RotW), true);
							odhlecmmdhq.NFOBFEGCJPB.COPCNGCMQDF(flyUser.Data, flyUser.Username);
						}
						break;
					case FlyUserAction.Leave:
						if (odhlecmmdhq != null)
						{
							odhlecmmdhq.NFOBFEGCJPB.LECIOLIFGEN(true);
						}
						break;
					}
				}
			}
		}
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x0004A90C File Offset: 0x00048B0C
	public int NNFOGNDNIML(int CIQFCJGQEMH)
	{
		switch (CIQFCJGQEMH)
		{
		case 0:
			return -92;
		case 1:
			return -64;
		case 2:
			return 111;
		case 3:
			return 93;
		case 4:
			return -52;
		case 5:
			return -112;
		case 6:
			return -190;
		case 7:
			return -110;
		case 8:
			return 37;
		case 9:
			return -168;
		case 10:
			return 76;
		case 11:
			return 176;
		default:
			return 70;
		}
	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x00004128 File Offset: 0x00002328
	public void EDMNQJQIKHB(EMLOFJDOMKH.ODHLECMMDHQ IHCKGKEJPHM)
	{
		this.MHQMLCJDMMK.Remove(IHCKGKEJPHM);
		if (IHCKGKEJPHM != null)
		{
			UnityEngine.Object.DestroyImmediate(IHCKGKEJPHM.KKONMBCFEJC);
			IHCKGKEJPHM = null;
		}
	}

	// Token: 0x0400009B RID: 155
	public GameObject MIMDIBNOGPC;

	// Token: 0x0400009C RID: 156
	public GameObject MFOFGGHOMEO;

	// Token: 0x0400009E RID: 158
	public List<EMLOFJDOMKH.ODHLECMMDHQ> MHQMLCJDMMK = new List<EMLOFJDOMKH.ODHLECMMDHQ>();

	// Token: 0x0400009F RID: 159
	private float NHNJPDPEDCO;

	// Token: 0x0200001E RID: 30
	public class ODHLECMMDHQ
	{
		// Token: 0x040000A0 RID: 160
		public GameObject KKONMBCFEJC;

		// Token: 0x040000A1 RID: 161
		public QDLMGFQHBJQ NFOBFEGCJPB;

		// Token: 0x040000A2 RID: 162
		public string FPQBICGEHMJ;
	}

	// Token: 0x0200001F RID: 31
	[CompilerGenerated]
	private sealed class IBMCDELFDMI
	{
		// Token: 0x060004F2 RID: 1266 RVA: 0x0004A98C File Offset: 0x00048B8C
		internal int MEQDCJHMEMH(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 1 : -1;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0004A98C File Offset: 0x00048B8C
		internal int BFPJJOJJGNN(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 1 : -1;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0004A98C File Offset: 0x00048B8C
		internal int MHBEIFOJMIB(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 1 : -1;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0004A9E8 File Offset: 0x00048BE8
		internal int EDJEKKGCKBE(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 0 : -1;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0004A9E8 File Offset: 0x00048BE8
		internal int PGKMMLBJHBM(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 0 : -1;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0004A98C File Offset: 0x00048B8C
		internal int IMMKOPFGNKC(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 1 : -1;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0004A9E8 File Offset: 0x00048BE8
		internal int INEPPGOENCF(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 0 : -1;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0004A98C File Offset: 0x00048B8C
		internal int PCNBJBKOCJH(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 1 : -1;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0004A98C File Offset: 0x00048B8C
		internal int QOLDPJNMBBM(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 1 : -1;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0004A98C File Offset: 0x00048B8C
		internal int EDQHHFGDFHK(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 1 : -1;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0004A98C File Offset: 0x00048B8C
		internal int NFJMLDQOBBM(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 1 : -1;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0004A98C File Offset: 0x00048B8C
		internal int ONCBOEQMGGP(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 1 : -1;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0004A9E8 File Offset: 0x00048BE8
		internal int PKCMHIKBGED(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 0 : -1;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0004A9E8 File Offset: 0x00048BE8
		internal int EJCEEPECCBC(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 0 : -1;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0004A98C File Offset: 0x00048B8C
		internal int DOBMMCQHNPC(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 1 : -1;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0004A9E8 File Offset: 0x00048BE8
		internal int LGBHQGHDLCB(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 0 : -1;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0004A98C File Offset: 0x00048B8C
		internal int CIQBIFONFKJ(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 1 : -1;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0004A98C File Offset: 0x00048B8C
		internal int PLBIJPINCJQ(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 1 : -1;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0004A98C File Offset: 0x00048B8C
		internal int PDKEEIPKOFK(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 1 : -1;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0004A98C File Offset: 0x00048B8C
		internal int PCJPNNBPOEC(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 1 : -1;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0004A98C File Offset: 0x00048B8C
		internal int OCOJGKBGQFG(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 1 : -1;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0004A98C File Offset: 0x00048B8C
		internal int OCGHFEHKILC(EMLOFJDOMKH.ODHLECMMDHQ DGKOIGOLHDM, EMLOFJDOMKH.ODHLECMMDHQ DDLQKFDFMCJ)
		{
			return ((DGKOIGOLHDM.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude >= (DDLQKFDFMCJ.NFOBFEGCJPB.transform.position - this.FOQHHHDJKFG).sqrMagnitude) ? 1 : -1;
		}

		// Token: 0x040000A3 RID: 163
		internal Vector3 FOQHHHDJKFG;
	}
}
