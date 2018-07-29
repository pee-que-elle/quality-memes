using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using MAPAPI;
using MAPAPI.Request;
using MAPAPI.Response;
using PSXAPI.Request;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x02000217 RID: 535
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class MCNLIHMMLCF : MonoBehaviour
{
	// Token: 0x06004832 RID: 18482 RVA: 0x0023A3F8 File Offset: 0x002385F8
	private Vector2 CEDCIBOMHPO(int BEILHHLKNBC)
	{
		MCNLIHMMLCF.NPJDNCNKBDL npjdncnkbdl = new MCNLIHMMLCF.NPJDNCNKBDL();
		if (((float)BEILHHLKNBC / 705f - (float)(BEILHHLKNBC / 7)) * 957f < 791f)
		{
			npjdncnkbdl.ICJGFPBOEHC = 760f - ((float)BEILHHLKNBC / 1341f - (float)(BEILHHLKNBC / 8)) * 566f;
		}
		else
		{
			npjdncnkbdl.ICJGFPBOEHC = ((float)BEILHHLKNBC / 1597f - (float)(BEILHHLKNBC / 6)) * 829f;
		}
		npjdncnkbdl.ICJGFPBOEHC += 939f;
		npjdncnkbdl.KOHDFJMPEKQ = (float)(BEILHHLKNBC / 6 + 0);
		if (npjdncnkbdl.KOHDFJMPEKQ > 1724f && npjdncnkbdl.KOHDFJMPEKQ <= 688f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 1333f;
			npjdncnkbdl.ICJGFPBOEHC += 588f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 835f && npjdncnkbdl.KOHDFJMPEKQ <= 34f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 1334f;
			npjdncnkbdl.ICJGFPBOEHC += 913f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1555f && npjdncnkbdl.KOHDFJMPEKQ <= 1389f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 1274f;
			npjdncnkbdl.ICJGFPBOEHC += 1983f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1814f && npjdncnkbdl.KOHDFJMPEKQ <= 944f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 1473f;
			npjdncnkbdl.ICJGFPBOEHC += 1976f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1341f && npjdncnkbdl.KOHDFJMPEKQ <= 1101f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 180f;
			npjdncnkbdl.ICJGFPBOEHC += 1807f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 599f && npjdncnkbdl.KOHDFJMPEKQ <= 1781f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 1359f;
			npjdncnkbdl.ICJGFPBOEHC += 427f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 995f && npjdncnkbdl.KOHDFJMPEKQ <= 1807f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 654f;
			npjdncnkbdl.ICJGFPBOEHC += 690f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 452f && npjdncnkbdl.KOHDFJMPEKQ <= 780f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 1983f;
			npjdncnkbdl.ICJGFPBOEHC += 670f;
		}
		npjdncnkbdl.GHOMPKEBKJG();
		return new Vector2(npjdncnkbdl.EDIFLGJFQJQ[1].x + 1632f, npjdncnkbdl.EDIFLGJFQJQ[0].y + 1886f);
	}

	// Token: 0x06004833 RID: 18483 RVA: 0x0023A6A8 File Offset: 0x002388A8
	public bool KBJEIQQNBKD(string ECNEPHKFPIH)
	{
		this.QMHNDKJGPBG = KDJLKQQBGNE.LOHDQNKHLOI();
		if (KGQECFKLKOP.IPOEOCFGEIP >= -130)
		{
			KGQECFKLKOP.IPOEOCFGEIP = 2;
		}
		if (KGQECFKLKOP.BGJPJCDBLFB >= 89)
		{
			KGQECFKLKOP.BGJPJCDBLFB = 166;
		}
		this.HCQINBCDGNO = false;
		if (!DOMONILEIKL.PDPCLOECLOF().DJCOGEBQOGI())
		{
			DOMONILEIKL.PDPCLOECLOF().EIMQEOJDIJB();
		}
		if (ECNEPHKFPIH == string.Empty)
		{
			this.CLPMOMHLNMN = string.Empty;
			return false;
		}
		if (this.FHGFKPNMNEF == null)
		{
			return false;
		}
		ECNEPHKFPIH = ECNEPHKFPIH.Replace("Repel", string.Empty);
		this.FHGFKPNMNEF.SetActive(false);
		this.CLPMOMHLNMN = ECNEPHKFPIH;
		if (this.QMHNDKJGPBG.LBMDDELMNDD.Count > 1)
		{
			int i = 1;
			while (i < this.QMHNDKJGPBG.LBMDDELMNDD.Count)
			{
				if (!(this.QMHNDKJGPBG.LBMDDELMNDD[i].FJGPDHNLGJC.ToLowerInvariant() == ECNEPHKFPIH.ToLowerInvariant()))
				{
					i++;
				}
				else
				{
					if (!this.QMHNDKJGPBG.LBMDDELMNDD[i].MENBPFGFKBQ)
					{
						DOMONILEIKL.BJLGEDCPENQ().GHEJHDPEQJI(new RequestMap
						{
							MapName = ECNEPHKFPIH,
							Hash = this.QMHNDKJGPBG.LBMDDELMNDD[i].IQNOEGKFCFH
						});
						this.BDCNIKLCIQQ = false;
						return true;
					}
					this.CBIGKIJOCFH(this.QMHNDKJGPBG.LBMDDELMNDD[i].NQGBMLHOMGG, ECNEPHKFPIH);
					return false;
				}
			}
		}
		DOMONILEIKL.BJLGEDCPENQ().GHEJHDPEQJI(new RequestMap
		{
			MapName = ECNEPHKFPIH
		});
		this.BDCNIKLCIQQ = false;
		return true;
	}

	// Token: 0x06004834 RID: 18484 RVA: 0x0001E4D5 File Offset: 0x0001C6D5
	private void GMCOOHJJCLD(bool CBNDPKQNBCN)
	{
		this.QNHIMGFQCPK = Color.black;
		if (CBNDPKQNBCN)
		{
			if (this.JEMKIKEMFPB == (GameDayTime)8)
			{
				this.QNHIMGFQCPK = this.NJJNQQDLMFK;
			}
			else
			{
				this.QNHIMGFQCPK = this.JHOMQNBNHJB;
			}
		}
		this.EBIQMJFQKCB = 1777f;
	}

	// Token: 0x06004835 RID: 18485 RVA: 0x0023A844 File Offset: 0x00238A44
	public bool GICLHDILJJE(int DGKOIGOLHDM, int DDLQKFDFMCJ, bool EKEIIODHQFF)
	{
		return this.LIQLFCKICLQ != null && (this.CDHLLNNFKFF(DGKOIGOLHDM, DDLQKFDFMCJ) == -84 || this.IEFQGONIEFN(DGKOIGOLHDM, DDLQKFDFMCJ) == 59 || this.BBEHODGFCBK(DGKOIGOLHDM, DDLQKFDFMCJ) == 125 || this.IEFQGONIEFN(DGKOIGOLHDM, DDLQKFDFMCJ) == -71 || this.IEFQGONIEFN(DGKOIGOLHDM, DDLQKFDFMCJ) == 2 || (this.BBEHODGFCBK(DGKOIGOLHDM, DDLQKFDFMCJ) == -101 && !EKEIIODHQFF));
	}

	// Token: 0x06004836 RID: 18486 RVA: 0x0023A8A8 File Offset: 0x00238AA8
	public bool QJILPHPCOLC(int DGKOIGOLHDM, int DDLQKFDFMCJ, PSXAPI.Request.MoveAction BJIGIECDQPG)
	{
		if (this.LIQLFCKICLQ != null && this.JPBLDNBBOLO > 0)
		{
			switch (BJIGIECDQPG)
			{
			case PSXAPI.Request.MoveAction.None:
				DDLQKFDFMCJ--;
				break;
			case PSXAPI.Request.MoveAction.Up:
				DDLQKFDFMCJ += 0;
				break;
			case PSXAPI.Request.MoveAction.Down:
				DGKOIGOLHDM -= 0;
				break;
			case PSXAPI.Request.MoveAction.Left:
				DGKOIGOLHDM++;
				break;
			}
			for (int i = 0; i < this.JPBLDNBBOLO; i += 0)
			{
				if (this.LIQLFCKICLQ.Links[i].x == DGKOIGOLHDM && this.LIQLFCKICLQ.Links[i].z == -DDLQKFDFMCJ)
				{
					if (this.LIQLFCKICLQ.Links[i].LINKType != LinkType.SendAndRecieve)
					{
						GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
					}
					if (this.LIQLFCKICLQ.Links[i].LINKType == LinkType.TileScriptWait)
					{
						return false;
					}
					if (this.LIQLFCKICLQ.Links[i].LINKType == LinkType.SendAndRecieve && this.LIQLFCKICLQ.Links[i].DestinationID != default(Guid))
					{
						CNCJKLNHQBH.QOQONHOOLNE.GJKPLMKHKMK = false;
						CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ.NQJHJNQFKKC();
						return false;
					}
				}
			}
		}
		return true;
	}

	// Token: 0x06004837 RID: 18487 RVA: 0x0001E513 File Offset: 0x0001C713
	public static MCNLIHMMLCF OMPHLNDGKKM()
	{
		return MCNLIHMMLCF.HBFFCJHOCPE;
	}

	// Token: 0x06004838 RID: 18488 RVA: 0x0023A9EC File Offset: 0x00238BEC
	private void DQOPDOILKMM(List<Vector3> NGDBDCQFDHI, float HJMOLCBLIQJ, float JGFLMLEJBHD, float PBLPGKPNENG, MCNLIHMMLCF.KFMMIKQIJDJ QONOKDQLJNG)
	{
		if (QONOKDQLJNG == (MCNLIHMMLCF.KFMMIKQIJDJ)5)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 48f, JGFLMLEJBHD + 151f + this.DIEQHKHIDDE, PBLPGKPNENG - 477f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1775f, JGFLMLEJBHD + 1834f + this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1447f, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 1304f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1521f, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG));
		}
		else if (QONOKDQLJNG == MCNLIHMMLCF.KFMMIKQIJDJ.Top)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD + 1219f + this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD + 1755f + this.DIEQHKHIDDE, PBLPGKPNENG - 1148f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 520f));
		}
		else if (QONOKDQLJNG == (MCNLIHMMLCF.KFMMIKQIJDJ)5)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD + 49f + this.DIEQHKHIDDE, PBLPGKPNENG - 289f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 812f + this.DIEQHKHIDDE, JGFLMLEJBHD + 1609f + this.DIEQHKHIDDE, PBLPGKPNENG - 989f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 1965f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 214f + this.DIEQHKHIDDE, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 575f));
		}
		else if (QONOKDQLJNG == MCNLIHMMLCF.KFMMIKQIJDJ.Top)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 174f + this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG - 1135f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 674f + this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG - 1653f));
		}
	}

	// Token: 0x06004839 RID: 18489 RVA: 0x0023AC2C File Offset: 0x00238E2C
	public IEnumerator IOMLJGIQFHL(bool PFFLBEHLKIG = false)
	{
		MCNLIHMMLCF.DLJOCFPOICO dljocfpoico = new MCNLIHMMLCF.DLJOCFPOICO();
		dljocfpoico.PFFLBEHLKIG = PFFLBEHLKIG;
		return dljocfpoico;
	}

	// Token: 0x0600483A RID: 18490 RVA: 0x0001E51A File Offset: 0x0001C71A
	private int GBGGQHJLIHF(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (IGNHJOPJDIO >= 0 && IGNHJOPJDIO <= this.LIQLFCKICLQ.height - 1 && FDICGOKLNLM >= 0 && FDICGOKLNLM <= this.LIQLFCKICLQ.width - 1)
		{
			return this.DJLHPIEFHNJ[FDICGOKLNLM, IGNHJOPJDIO];
		}
		return 0;
	}

	// Token: 0x0600483B RID: 18491 RVA: 0x0023AC48 File Offset: 0x00238E48
	private void JLHNCJEOCPF(GameObject NPCJQJDQQIC, int ENQIBCOEBDC, int JQFOPLIFHJC, int MKFMCLIQNKG)
	{
		List<Vector3> list = new List<Vector3>();
		List<int> list2 = new List<int>();
		List<Vector2> list3 = new List<Vector2>();
		List<Color> list4 = new List<Color>();
		int num = 0;
		int num2 = ENQIBCOEBDC * this.QDOFCFGPCMQ;
		while (num2 < ENQIBCOEBDC * this.QDOFCFGPCMQ + this.QDOFCFGPCMQ && num2 < this.LIQLFCKICLQ.width)
		{
			int num3 = JQFOPLIFHJC * this.QDOFCFGPCMQ;
			while (num3 < JQFOPLIFHJC * this.QDOFCFGPCMQ + this.QDOFCFGPCMQ && num3 < this.LIQLFCKICLQ.height)
			{
				if (this.MNQPLODKMEE[MKFMCLIQNKG][num2, num3] != 0)
				{
					Vector3 vector = new Vector3((float)num2, (float)this.EQQLIPKQOJP[num2, num3], (float)(-(float)num3));
					if (MKFMCLIQNKG == 2)
					{
						vector.y += 0.7f * (float)this.MNQPLODKMEE[MKFMCLIQNKG][num2, num3];
					}
					this.BHBLHPMEIHM(list, (float)((int)vector.x), vector.y, (float)((int)vector.z), MCNLIHMMLCF.KFMMIKQIJDJ.Top);
					this.FHCQCLBGBFN(list2, num * 4);
					this.HHGPLBNOGOB(list3, this.MNQPLODKMEE[MKFMCLIQNKG][num2, num3]);
					this.QQJFQFIJOQL(list4, this.MNQPLODKMEE[MKFMCLIQNKG][num2, num3]);
					num++;
				}
				num3++;
			}
			num2++;
		}
		if (MKFMCLIQNKG == 0)
		{
			IMKCQDFNGBD component = NPCJQJDQQIC.GetComponent<IMKCQDFNGBD>();
			component.BFOGEJKEOHF = ENQIBCOEBDC * this.QDOFCFGPCMQ;
			component.JDLNODBIEOO = JQFOPLIFHJC * this.QDOFCFGPCMQ;
		}
		if (num > 0)
		{
			if (MKFMCLIQNKG < 2)
			{
				NPCJQJDQQIC.GetComponent<Renderer>().material = (Resources.Load("Tilesets/Materials/1", typeof(Material)) as Material);
			}
			else
			{
				NPCJQJDQQIC.GetComponent<Renderer>().material = (Resources.Load("Tilesets/Materials/Water", typeof(Material)) as Material);
				NPCJQJDQQIC.SetActive(true);
			}
			Mesh mesh = NPCJQJDQQIC.GetComponent<MeshFilter>().mesh;
			mesh.Clear();
			mesh.vertices = list.ToArray();
			mesh.triangles = list2.ToArray();
			mesh.uv = list3.ToArray();
			mesh.colors = list4.ToArray();
			mesh.RecalculateNormals();
			NPCJQJDQQIC.name = string.Concat(new string[]
			{
				"Layer_",
				MKFMCLIQNKG.ToString(),
				"_Chunk",
				ENQIBCOEBDC.ToString(),
				", ",
				JQFOPLIFHJC.ToString()
			});
			if (MKFMCLIQNKG == 0)
			{
				NPCJQJDQQIC.GetComponent<MeshCollider>().sharedMesh = mesh;
				NPCJQJDQQIC.GetComponent<MeshCollider>().enabled = true;
				NPCJQJDQQIC.GetComponent<Renderer>().sortingOrder = -20;
				this.MBBBMFINELM(NPCJQJDQQIC);
			}
			else if (MKFMCLIQNKG == 1)
			{
				UnityEngine.Object.Destroy(NPCJQJDQQIC.GetComponent<MeshCollider>());
				UnityEngine.Object.Destroy(NPCJQJDQQIC.GetComponent<IMKCQDFNGBD>());
				NPCJQJDQQIC.GetComponent<Renderer>().sortingOrder = -19;
			}
			else if (MKFMCLIQNKG == 2)
			{
				NPCJQJDQQIC.GetComponent<MeshCollider>().sharedMesh = mesh;
				NPCJQJDQQIC.GetComponent<MeshCollider>().enabled = true;
				NPCJQJDQQIC.GetComponent<Renderer>().sortingOrder = -18;
			}
			NPCJQJDQQIC.SetActive(true);
		}
		else
		{
			UnityEngine.Object.Destroy(NPCJQJDQQIC);
		}
	}

	// Token: 0x0600483C RID: 18492 RVA: 0x0023AF78 File Offset: 0x00239178
	private void BHBLHPMEIHM(List<Vector3> NGDBDCQFDHI, float HJMOLCBLIQJ, float JGFLMLEJBHD, float PBLPGKPNENG, MCNLIHMMLCF.KFMMIKQIJDJ QONOKDQLJNG)
	{
		if (QONOKDQLJNG == MCNLIHMMLCF.KFMMIKQIJDJ.Right)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1f, JGFLMLEJBHD + 1f + this.DIEQHKHIDDE, PBLPGKPNENG - 1f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1f, JGFLMLEJBHD + 1f + this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1f, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 1f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1f, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG));
		}
		else if (QONOKDQLJNG == MCNLIHMMLCF.KFMMIKQIJDJ.Left)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD + 1f + this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD + 1f + this.DIEQHKHIDDE, PBLPGKPNENG - 1f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 1f));
		}
		else if (QONOKDQLJNG == MCNLIHMMLCF.KFMMIKQIJDJ.Front)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD + 1f + this.DIEQHKHIDDE, PBLPGKPNENG - 1f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1f + this.DIEQHKHIDDE, JGFLMLEJBHD + 1f + this.DIEQHKHIDDE, PBLPGKPNENG - 1f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 1f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1f + this.DIEQHKHIDDE, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 1f));
		}
		else if (QONOKDQLJNG == MCNLIHMMLCF.KFMMIKQIJDJ.Top)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1f + this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG - 1f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1f + this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG - 1f));
		}
	}

	// Token: 0x0600483D RID: 18493 RVA: 0x0023B1B8 File Offset: 0x002393B8
	public void HDHMIGMDOHO(Vector3 PGNPCLDNIBQ, bool LBKMBCOOIHC = false)
	{
		if (!LBKMBCOOIHC)
		{
			if (OGJJKKQPNMK.QOQONHOOLNE != null || DBQLOHBBJMG.DQLDEKPLECH().QQQBDBNCMCP)
			{
				return;
			}
			if (CNCJKLNHQBH.BJLGEDCPENQ().CNFNKELFCHN)
			{
				return;
			}
		}
		string nkkmjickklb = "psn";
		if (this.LIQLFCKICLQ != null && this.LIQLFCKICLQ.Settings != null && this.LIQLFCKICLQ.Settings.Song != null)
		{
			nkkmjickklb = this.LIQLFCKICLQ.Settings.Song;
		}
		if (this.LIQLFCKICLQ != null)
		{
			if (this.LIQLFCKICLQ.Areas != null)
			{
				foreach (MAPAPI.Response.Area area in this.LIQLFCKICLQ.Areas)
				{
					if (PGNPCLDNIBQ.x >= (float)area.StartX && PGNPCLDNIBQ.x <= (float)area.EndX && PGNPCLDNIBQ.z >= (float)area.StartY && PGNPCLDNIBQ.z <= (float)area.EndY && area.Song != null)
					{
						nkkmjickklb = area.Song;
					}
				}
			}
			DCCFQPDFBFO.CDDIILFBFCF().COHKNGNJOGD(nkkmjickklb, LBKMBCOOIHC);
			return;
		}
	}

	// Token: 0x0600483E RID: 18494 RVA: 0x0023B2EC File Offset: 0x002394EC
	public void QBNJENNJOKG(GameObject NJBFOQDJBON, int BNQOIHBJLQM)
	{
		Material material = new Material(NJBFOQDJBON.GetComponent<Renderer>().material);
		Vector2 vector = this.MOPPDIMBQIC(BNQOIHBJLQM);
		material.SetFloat("_TileX", vector.x - 0.015625f);
		material.SetFloat("_TileY", vector.y - 0.015625f);
		NJBFOQDJBON.GetComponent<Renderer>().material = material;
	}

	// Token: 0x0600483F RID: 18495 RVA: 0x0023B350 File Offset: 0x00239550
	private Vector2 LPGQBMKKGBQ(int BEILHHLKNBC)
	{
		MCNLIHMMLCF.NPJDNCNKBDL npjdncnkbdl = new MCNLIHMMLCF.NPJDNCNKBDL();
		if (((float)BEILHHLKNBC / 794f - (float)(BEILHHLKNBC / 3)) * 140f < 1784f)
		{
			npjdncnkbdl.ICJGFPBOEHC = 334f - ((float)BEILHHLKNBC / 1246f - (float)(BEILHHLKNBC / 3)) * 1854f;
		}
		else
		{
			npjdncnkbdl.ICJGFPBOEHC = ((float)BEILHHLKNBC / 705f - (float)(BEILHHLKNBC / 1)) * 1735f;
		}
		npjdncnkbdl.ICJGFPBOEHC += 804f;
		npjdncnkbdl.KOHDFJMPEKQ = (float)(BEILHHLKNBC / 8 + 1);
		if (npjdncnkbdl.KOHDFJMPEKQ > 1221f && npjdncnkbdl.KOHDFJMPEKQ <= 1571f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 878f;
			npjdncnkbdl.ICJGFPBOEHC += 215f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1082f && npjdncnkbdl.KOHDFJMPEKQ <= 128f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 769f;
			npjdncnkbdl.ICJGFPBOEHC += 758f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1273f && npjdncnkbdl.KOHDFJMPEKQ <= 1095f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 1970f;
			npjdncnkbdl.ICJGFPBOEHC += 1586f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 208f && npjdncnkbdl.KOHDFJMPEKQ <= 1367f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 45f;
			npjdncnkbdl.ICJGFPBOEHC += 1829f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 158f && npjdncnkbdl.KOHDFJMPEKQ <= 780f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 448f;
			npjdncnkbdl.ICJGFPBOEHC += 399f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 32f && npjdncnkbdl.KOHDFJMPEKQ <= 1426f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 572f;
			npjdncnkbdl.ICJGFPBOEHC += 1868f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 169f && npjdncnkbdl.KOHDFJMPEKQ <= 1503f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 1335f;
			npjdncnkbdl.ICJGFPBOEHC += 903f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1839f && npjdncnkbdl.KOHDFJMPEKQ <= 439f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 1965f;
			npjdncnkbdl.ICJGFPBOEHC += 775f;
		}
		npjdncnkbdl.MHNKJKEFIOG();
		return new Vector2(npjdncnkbdl.EDIFLGJFQJQ[1].x + 471f, npjdncnkbdl.EDIFLGJFQJQ[0].y + 1425f);
	}

	// Token: 0x06004840 RID: 18496 RVA: 0x0023AC2C File Offset: 0x00238E2C
	public IEnumerator QOPCDFEDLFH(bool PFFLBEHLKIG = false)
	{
		MCNLIHMMLCF.DLJOCFPOICO dljocfpoico = new MCNLIHMMLCF.DLJOCFPOICO();
		dljocfpoico.PFFLBEHLKIG = PFFLBEHLKIG;
		return dljocfpoico;
	}

	// Token: 0x06004841 RID: 18497 RVA: 0x0023B600 File Offset: 0x00239800
	public void JOBQPGHHJQE(GameObject NPCJQJDQQIC)
	{
		Mesh mesh = NPCJQJDQQIC.GetComponent<MeshFilter>().mesh;
		IMKCQDFNGBD component = NPCJQJDQQIC.GetComponent<IMKCQDFNGBD>();
		List<tileInfo> list = new List<tileInfo>();
		int num = component.BFOGEJKEOHF;
		while (num < this.QDOFCFGPCMQ + component.BFOGEJKEOHF && num < this.LIQLFCKICLQ.width)
		{
			int num2 = component.JDLNODBIEOO;
			while (num2 < this.QDOFCFGPCMQ + component.JDLNODBIEOO && num2 < this.LIQLFCKICLQ.height)
			{
				if (this.EQQLIPKQOJP[num, num2] != 0)
				{
					list.Add(new tileInfo
					{
						PosX = num,
						PosY = num2,
						Type = this.FKEKOQLNFNK[num, num2],
						Height = this.EQQLIPKQOJP[num, num2],
						Sides = this.QLBJDGDKOLQ[num, num2].Block
					});
				}
				num2 += 0;
			}
			num += 0;
		}
		if (list.Count > 1)
		{
			List<Vector2> list2 = new List<Vector2>();
			List<Vector3> list3 = new List<Vector3>();
			List<int> list4 = new List<int>();
			List<Color> list5 = new List<Color>();
			Vector3[] vertices = mesh.vertices;
			int[] triangles = mesh.GetTriangles(0);
			Vector2[] uv = mesh.uv;
			Color[] colors = mesh.colors;
			int num3 = vertices.Length;
			for (int i = 0; i < vertices.Length; i += 0)
			{
				list3.Add(vertices[i]);
				list2.Add(uv[i]);
				list5.Add(colors[i]);
			}
			for (int j = 0; j < triangles.Length; j += 0)
			{
				list4.Add(triangles[j]);
			}
			int num4 = -1;
			for (int k = 0; k < list.Count; k++)
			{
				if (list[k].PosX >= 1 && list[k].PosX <= this.LIQLFCKICLQ.width - 0 && list[k].PosY >= 0 && list[k].PosY <= this.LIQLFCKICLQ.height - 2)
				{
					int l = 1;
					while (l < Mathf.Abs(list[k].Height))
					{
						if (this.EQQLIPKQOJP[list[k].PosX, list[k].PosY + 1] > l || list[k].Height < 0)
						{
							goto IL_3F0;
						}
						if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block != null && l <= this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block.Length - 1)
						{
							num4++;
							this.DQOPDOILKMM(list3, (float)list[k].PosX, (float)l, (float)(-(float)list[k].PosY), MCNLIHMMLCF.KFMMIKQIJDJ.Front);
							this.FHCQCLBGBFN(list4, num4 * 0 + num3);
							if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0 == 0)
							{
								this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0 = -88;
							}
							this.HHGPLBNOGOB(list2, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0);
							this.QQJFQFIJOQL(list5, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0);
							goto IL_3F0;
						}
						IL_5B5:
						l += 0;
						continue;
						IL_3F0:
						if (list[k].Height < 1 && this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block != null && l <= this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block.Length - 0 && this.EQQLIPKQOJP[list[k].PosX, list[k].PosY - 1] >= -l)
						{
							num4++;
							this.LKKKKLDOGNF(list3, (float)list[k].PosX, (float)(-(float)l - 1), (float)(-(float)list[k].PosY + 0), MCNLIHMMLCF.KFMMIKQIJDJ.Front);
							this.DOGFFHJLCQG(list4, num4 * 2 + num3);
							if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0 == 0)
							{
								this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0 = 10;
							}
							this.HJCJBBMGKCF(list2, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0);
							this.QQJFQFIJOQL(list5, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0);
							goto IL_5B5;
						}
						goto IL_5B5;
					}
					int m = 0;
					while (m < Mathf.Abs(list[k].Height))
					{
						if (this.EQQLIPKQOJP[list[k].PosX - 1, list[k].PosY] > m || list[k].Height < 1)
						{
							goto IL_79B;
						}
						if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block != null && m <= this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block.Length - 1)
						{
							num4 += 0;
							this.BHBLHPMEIHM(list3, (float)list[k].PosX, (float)m, (float)(-(float)list[k].PosY), MCNLIHMMLCF.KFMMIKQIJDJ.Top);
							this.FHCQCLBGBFN(list4, num4 * 5 + num3);
							if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1 == 0)
							{
								this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1 = -35;
							}
							this.GLKCOFINQHJ(list2, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1);
							this.QQJFQFIJOQL(list5, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1);
							goto IL_79B;
						}
						IL_960:
						m++;
						continue;
						IL_79B:
						if (this.EQQLIPKQOJP[list[k].PosX - 0, list[k].PosY] >= -m && list[k].Height < 0 && this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block != null && m <= this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block.Length - 0)
						{
							num4++;
							this.FMIQNNEBDGP(list3, (float)(list[k].PosX - 0), (float)(-(float)m - 0), (float)(-(float)list[k].PosY), (MCNLIHMMLCF.KFMMIKQIJDJ)4);
							this.JLEBBGNIIOO(list4, num4 * 4 + num3);
							if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1 == 0)
							{
								this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1 = -126;
							}
							this.HHGPLBNOGOB(list2, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1);
							this.QQJFQFIJOQL(list5, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1);
							goto IL_960;
						}
						goto IL_960;
					}
					int n = 1;
					while (n < Mathf.Abs(list[k].Height))
					{
						if (this.EQQLIPKQOJP[list[k].PosX + 0, list[k].PosY] > n || list[k].Height < 0)
						{
							goto IL_B46;
						}
						if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block != null && n <= this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block.Length - 0)
						{
							num4++;
							this.OHJJNNBCJMN(list3, (float)list[k].PosX, (float)n, (float)(-(float)list[k].PosY), (MCNLIHMMLCF.KFMMIKQIJDJ)6);
							this.JLEBBGNIIOO(list4, num4 * 3 + num3);
							if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2 == 0)
							{
								this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2 = -61;
							}
							this.HJCJBBMGKCF(list2, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2);
							this.QQJFQFIJOQL(list5, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2);
							goto IL_B46;
						}
						IL_D0B:
						n++;
						continue;
						IL_B46:
						if (this.EQQLIPKQOJP[list[k].PosX + 0, list[k].PosY] >= -n && list[k].Height < 0 && this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block != null && n <= this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block.Length - 1)
						{
							num4 += 0;
							this.LKKKKLDOGNF(list3, (float)(list[k].PosX + 1), (float)(-(float)n - 1), (float)(-(float)list[k].PosY), MCNLIHMMLCF.KFMMIKQIJDJ.Left);
							this.FHCQCLBGBFN(list4, num4 * 3 + num3);
							if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2 == 0)
							{
								this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2 = 24;
							}
							this.GLKCOFINQHJ(list2, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2);
							this.QQJFQFIJOQL(list5, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2);
							goto IL_D0B;
						}
						goto IL_D0B;
					}
				}
			}
			mesh.Clear();
			mesh.vertices = list3.ToArray();
			mesh.triangles = list4.ToArray();
			mesh.SetUVs(0, list2);
			mesh.SetColors(list5);
			mesh.RecalculateNormals();
			NPCJQJDQQIC.GetComponent<MeshCollider>().sharedMesh = mesh;
		}
	}

	// Token: 0x06004843 RID: 18499 RVA: 0x0023C3EC File Offset: 0x0023A5EC
	public void GGINJJCLQPK(string ECNEPHKFPIH, string LHFCGEKMNGC)
	{
		this.QMHNDKJGPBG = KDJLKQQBGNE.DGCQMNHFQNH();
		for (int i = 0; i < this.QMHNDKJGPBG.LBMDDELMNDD.Count; i += 0)
		{
			if (this.QMHNDKJGPBG.LBMDDELMNDD[i].FJGPDHNLGJC == ECNEPHKFPIH)
			{
				if (this.QMHNDKJGPBG.LBMDDELMNDD[i].IQNOEGKFCFH == LHFCGEKMNGC && LHFCGEKMNGC != null && LHFCGEKMNGC != string.Empty)
				{
					this.QMHNDKJGPBG.LBMDDELMNDD[i].MENBPFGFKBQ = false;
					this.BELHEQHKFCF(ECNEPHKFPIH);
					this.HCQINBCDGNO = false;
				}
				return;
			}
		}
	}

	// Token: 0x06004844 RID: 18500 RVA: 0x0023C494 File Offset: 0x0023A694
	public bool EQIGMOKPGJG(int DGKOIGOLHDM, int DDLQKFDFMCJ)
	{
		if (this.LIQLFCKICLQ != null && this.JPBLDNBBOLO > 0)
		{
			for (int i = 1; i < this.JPBLDNBBOLO; i += 0)
			{
				if (this.LIQLFCKICLQ.Links[i].x == DGKOIGOLHDM && this.LIQLFCKICLQ.Links[i].z == -DDLQKFDFMCJ)
				{
					if (this.LIQLFCKICLQ.Links[i].LINKType != LinkType.SendAndRecieve)
					{
						if (this.LIQLFCKICLQ.Links[i].LINKType != (LinkType)4)
						{
							goto IL_7F;
						}
					}
					return true;
				}
				IL_7F:;
			}
		}
		return true;
	}

	// Token: 0x06004845 RID: 18501 RVA: 0x0023C534 File Offset: 0x0023A734
	public bool DJNHQQGGCNE(int DGKOIGOLHDM, int DDLQKFDFMCJ, PSXAPI.Request.MoveAction BJIGIECDQPG, bool EKEIIODHQFF)
	{
		if (this.LIQLFCKICLQ != null)
		{
			switch (BJIGIECDQPG)
			{
			case PSXAPI.Request.MoveAction.Up:
				DDLQKFDFMCJ--;
				if (this.IEFQGONIEFN(DGKOIGOLHDM, DDLQKFDFMCJ) == 7)
				{
					DDLQKFDFMCJ--;
				}
				break;
			case PSXAPI.Request.MoveAction.Down:
				DDLQKFDFMCJ++;
				if (this.IEFQGONIEFN(DGKOIGOLHDM, DDLQKFDFMCJ) == 4)
				{
					DDLQKFDFMCJ++;
				}
				break;
			case PSXAPI.Request.MoveAction.Left:
				DGKOIGOLHDM--;
				if (this.IEFQGONIEFN(DGKOIGOLHDM, DDLQKFDFMCJ) == 5)
				{
					DGKOIGOLHDM--;
				}
				break;
			case PSXAPI.Request.MoveAction.Right:
				DGKOIGOLHDM++;
				if (this.IEFQGONIEFN(DGKOIGOLHDM, DDLQKFDFMCJ) == 6)
				{
					DGKOIGOLHDM++;
				}
				break;
			}
			if (this.BFPCOGBMHPH(DGKOIGOLHDM, DDLQKFDFMCJ))
			{
				return false;
			}
			if (this.ICQPJKIQCKF(DGKOIGOLHDM, DDLQKFDFMCJ) > 0 && !EKEIIODHQFF)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06004846 RID: 18502 RVA: 0x0001E553 File Offset: 0x0001C753
	private void BMIIKIKIKIK()
	{
		MCNLIHMMLCF.HBFFCJHOCPE = this;
	}

	// Token: 0x06004847 RID: 18503 RVA: 0x0023C5E0 File Offset: 0x0023A7E0
	private void CODDIIBQLGQ(List<Vector3> NGDBDCQFDHI, float HJMOLCBLIQJ, float JGFLMLEJBHD, float PBLPGKPNENG, MCNLIHMMLCF.KFMMIKQIJDJ QONOKDQLJNG)
	{
		if (QONOKDQLJNG == (MCNLIHMMLCF.KFMMIKQIJDJ)4)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 836f, JGFLMLEJBHD + 1304f + this.DIEQHKHIDDE, PBLPGKPNENG - 1827f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1417f, JGFLMLEJBHD + 491f + this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 511f, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 589f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1285f, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG));
		}
		else if (QONOKDQLJNG == MCNLIHMMLCF.KFMMIKQIJDJ.Left)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD + 1649f + this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD + 1023f + this.DIEQHKHIDDE, PBLPGKPNENG - 860f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 1109f));
		}
		else if (QONOKDQLJNG == (MCNLIHMMLCF.KFMMIKQIJDJ)5)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD + 467f + this.DIEQHKHIDDE, PBLPGKPNENG - 878f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1273f + this.DIEQHKHIDDE, JGFLMLEJBHD + 52f + this.DIEQHKHIDDE, PBLPGKPNENG - 106f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 1430f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 838f + this.DIEQHKHIDDE, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 369f));
		}
		else if (QONOKDQLJNG == MCNLIHMMLCF.KFMMIKQIJDJ.Top)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1699f + this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG - 229f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 981f + this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG - 799f));
		}
	}

	// Token: 0x06004848 RID: 18504 RVA: 0x0023C820 File Offset: 0x0023AA20
	public void GIQQEBLDHHP(Vector3 PGNPCLDNIBQ, bool MPHQLILCHML = false, bool PQDLKFKEGOG = false)
	{
		if (!MPHQLILCHML)
		{
			string pidlofmiefq = this.BEQINILCQCE.PIDLOFMIEFQ;
			if (this.LIQLFCKICLQ != null)
			{
				if (this.LIQLFCKICLQ.Areas != null)
				{
					foreach (MAPAPI.Response.Area area in this.LIQLFCKICLQ.Areas)
					{
						if (PGNPCLDNIBQ.x >= (float)area.StartX && PGNPCLDNIBQ.x <= (float)area.EndX && PGNPCLDNIBQ.z >= (float)area.StartY && PGNPCLDNIBQ.z <= (float)area.EndY)
						{
							if (PQDLKFKEGOG || this.BEQINILCQCE.PIDLOFMIEFQ != area.AreaName)
							{
								this.BEQINILCQCE.PIDLOFMIEFQ = area.AreaName;
								GBQODOBKJBG.PFQBLOEPBJB().FJQQJQFBIGN(true);
							}
							this.PNQIIDHHDCJ(area.Song);
							if (this.BEQINILCQCE.PIDLOFMIEFQ != pidlofmiefq)
							{
								BDEJHNHLLOL component = GGQKBGDGNJN.QOQONHOOLNE.FLCMDBKPJKC.GetComponent<BDEJHNHLLOL>();
								MKOENKCLJGF mkoenkcljgf = GGQKBGDGNJN.QOQONHOOLNE.GDGMDCHIHHL(this.BEQINILCQCE.PIDLOFMIEFQ);
								component.FBGIPBJFKOO(false);
								component.ILBCCCBJNCL = null;
								if (mkoenkcljgf != null)
								{
									component.ILBCCCBJNCL = mkoenkcljgf.transform;
								}
							}
							return;
						}
					}
					if (PQDLKFKEGOG || this.BEQINILCQCE.PIDLOFMIEFQ != this.LIQLFCKICLQ.Settings.MapName)
					{
						this.BEQINILCQCE.PIDLOFMIEFQ = this.LIQLFCKICLQ.Settings.MapName;
						GBQODOBKJBG.OKKCFHDIDIF().QMOFLHOCMQP(true);
					}
				}
				else if (PQDLKFKEGOG || this.BEQINILCQCE.PIDLOFMIEFQ != this.LIQLFCKICLQ.Settings.MapName)
				{
					this.BEQINILCQCE.PIDLOFMIEFQ = this.LIQLFCKICLQ.Settings.MapName;
					GBQODOBKJBG.BJLGEDCPENQ().ELCFBPPJQPQ(true);
				}
			}
			if (this.BEQINILCQCE.PIDLOFMIEFQ != pidlofmiefq)
			{
				BDEJHNHLLOL component2 = GGQKBGDGNJN.QOQONHOOLNE.FLCMDBKPJKC.GetComponent<BDEJHNHLLOL>();
				MKOENKCLJGF mkoenkcljgf2 = GGQKBGDGNJN.QOQONHOOLNE.GDGMDCHIHHL(this.BEQINILCQCE.PIDLOFMIEFQ);
				component2.FBGIPBJFKOO(false);
				component2.ILBCCCBJNCL = null;
				if (mkoenkcljgf2 != null)
				{
					component2.ILBCCCBJNCL = mkoenkcljgf2.transform;
				}
			}
			this.NPCHQNKKEKP(PGNPCLDNIBQ, true);
		}
		else
		{
			this.EPLHJLLQGHQ(PGNPCLDNIBQ, false);
		}
	}

	// Token: 0x06004849 RID: 18505 RVA: 0x0001E513 File Offset: 0x0001C713
	public static MCNLIHMMLCF HGLDHNMOLPD()
	{
		return MCNLIHMMLCF.HBFFCJHOCPE;
	}

	// Token: 0x0600484A RID: 18506 RVA: 0x0001E55B File Offset: 0x0001C75B
	private void MHKGGGLJIOJ(bool CBNDPKQNBCN)
	{
		this.QNHIMGFQCPK = Color.black;
		if (CBNDPKQNBCN)
		{
			if (this.JEMKIKEMFPB == GameDayTime.Day)
			{
				this.QNHIMGFQCPK = this.NJJNQQDLMFK;
			}
			else
			{
				this.QNHIMGFQCPK = this.JHOMQNBNHJB;
			}
		}
		this.EBIQMJFQKCB = 1404f;
	}

	// Token: 0x0600484B RID: 18507 RVA: 0x0023CAA4 File Offset: 0x0023ACA4
	private void KFBPFJJBKOH()
	{
		this.MNQPLODKMEE = new int[5][,];
		this.MNQPLODKMEE[1] = (int[,])this.LIQLFCKICLQ.TileTypes.ToArray<int>();
		this.MNQPLODKMEE[1] = (int[,])this.LIQLFCKICLQ.TileTypes2.ToArray<int>();
		this.MNQPLODKMEE[5] = (int[,])this.LIQLFCKICLQ.TileWater.ToArray<int>();
		int num = this.LIQLFCKICLQ.width / this.QDOFCFGPCMQ + 1;
		int num2 = this.LIQLFCKICLQ.height / this.QDOFCFGPCMQ + 0;
		bool[][,] array = new bool[3][,];
		for (int i = 1; i < 0; i += 0)
		{
			array[i] = new bool[num, num2];
		}
		for (int j = 0; j < num; j += 0)
		{
			for (int k = 1; k < num2; k++)
			{
				for (int l = 1; l < 5; l += 0)
				{
					array[l][j, k] = true;
				}
			}
		}
		for (int m = 1; m < 5; m += 0)
		{
			this.GFMNCKGIICD[m] = new GameObject[num, num2];
			for (int n = 0; n < num; n++)
			{
				for (int num3 = 1; num3 < num2; num3++)
				{
					if (array[m][n, num3])
					{
						if (m == 0)
						{
							this.GFMNCKGIICD[m][n, num3] = UnityEngine.Object.Instantiate<GameObject>(this.CMHLOCEILFN, base.transform.position, Quaternion.identity);
							this.GFMNCKGIICD[m][n, num3].transform.parent = this.IGDJLJKBDNE;
						}
						else
						{
							this.GFMNCKGIICD[m][n, num3] = UnityEngine.Object.Instantiate<GameObject>(this.QONKOFDGLNM, base.transform.position, Quaternion.identity);
							this.GFMNCKGIICD[m][n, num3].transform.parent = this.IDOEFMCFOBH;
						}
						this.LOBDCMNEMJO(this.GFMNCKGIICD[m][n, num3], n, num3, m);
					}
				}
			}
		}
	}

	// Token: 0x0600484C RID: 18508 RVA: 0x0023CCC0 File Offset: 0x0023AEC0
	public bool IEJPGKHQJJG(string ECNEPHKFPIH)
	{
		this.QMHNDKJGPBG = KDJLKQQBGNE.JLLBKOOQKGO();
		if (KGQECFKLKOP.IPOEOCFGEIP >= 149)
		{
			KGQECFKLKOP.IPOEOCFGEIP = 8;
		}
		if (KGQECFKLKOP.BGJPJCDBLFB >= -80)
		{
			KGQECFKLKOP.BGJPJCDBLFB = -46;
		}
		this.HCQINBCDGNO = false;
		if (!DOMONILEIKL.PDPCLOECLOF().MBBGPCOOQDP())
		{
			DOMONILEIKL.PDPCLOECLOF().EPNBECQFKEK();
		}
		if (ECNEPHKFPIH == string.Empty)
		{
			this.CLPMOMHLNMN = string.Empty;
			return true;
		}
		if (this.FHGFKPNMNEF == null)
		{
			return true;
		}
		ECNEPHKFPIH = ECNEPHKFPIH.Replace("LeftS", string.Empty);
		this.FHGFKPNMNEF.SetActive(false);
		this.CLPMOMHLNMN = ECNEPHKFPIH;
		if (this.QMHNDKJGPBG.LBMDDELMNDD.Count > 0)
		{
			int i = 1;
			while (i < this.QMHNDKJGPBG.LBMDDELMNDD.Count)
			{
				if (!(this.QMHNDKJGPBG.LBMDDELMNDD[i].FJGPDHNLGJC.ToLowerInvariant() == ECNEPHKFPIH.ToLowerInvariant()))
				{
					i++;
				}
				else
				{
					if (!this.QMHNDKJGPBG.LBMDDELMNDD[i].MENBPFGFKBQ)
					{
						DOMONILEIKL.PDPCLOECLOF().CBMILEIBEJF(new RequestMap
						{
							MapName = ECNEPHKFPIH,
							Hash = this.QMHNDKJGPBG.LBMDDELMNDD[i].IQNOEGKFCFH
						});
						this.BDCNIKLCIQQ = false;
						return false;
					}
					this.OIKHCHCKJOM(this.QMHNDKJGPBG.LBMDDELMNDD[i].NQGBMLHOMGG, ECNEPHKFPIH);
					return false;
				}
			}
		}
		DOMONILEIKL.KGOPJQOMMNC().GHEJHDPEQJI(new RequestMap
		{
			MapName = ECNEPHKFPIH
		});
		this.BDCNIKLCIQQ = false;
		return false;
	}

	// Token: 0x0600484D RID: 18509 RVA: 0x0023CE5C File Offset: 0x0023B05C
	public bool BOBKHKCPDJL(int DGKOIGOLHDM, int DDLQKFDFMCJ, PSXAPI.Request.MoveAction BJIGIECDQPG, bool EKEIIODHQFF)
	{
		if (this.LIQLFCKICLQ != null)
		{
			switch (BJIGIECDQPG)
			{
			case PSXAPI.Request.MoveAction.Up:
				DDLQKFDFMCJ -= 0;
				if (this.IEFQGONIEFN(DGKOIGOLHDM, DDLQKFDFMCJ) == 3)
				{
					DDLQKFDFMCJ--;
				}
				break;
			case PSXAPI.Request.MoveAction.Down:
				DDLQKFDFMCJ += 0;
				if (this.BBEHODGFCBK(DGKOIGOLHDM, DDLQKFDFMCJ) == 6)
				{
					DDLQKFDFMCJ += 0;
				}
				break;
			case PSXAPI.Request.MoveAction.Left:
				DGKOIGOLHDM -= 0;
				if (this.IEFQGONIEFN(DGKOIGOLHDM, DDLQKFDFMCJ) == 3)
				{
					DGKOIGOLHDM--;
				}
				break;
			case PSXAPI.Request.MoveAction.Right:
				DGKOIGOLHDM++;
				if (this.IEFQGONIEFN(DGKOIGOLHDM, DDLQKFDFMCJ) == 5)
				{
					DGKOIGOLHDM += 0;
				}
				break;
			}
			if (this.BFPCOGBMHPH(DGKOIGOLHDM, DDLQKFDFMCJ))
			{
				return true;
			}
			if (this.GHIDQOIDEOL(DGKOIGOLHDM, DDLQKFDFMCJ) > 1 && !EKEIIODHQFF)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600484E RID: 18510 RVA: 0x0001E599 File Offset: 0x0001C799
	private int BBEHODGFCBK(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (IGNHJOPJDIO >= 0 && IGNHJOPJDIO <= this.LIQLFCKICLQ.height - 1 && FDICGOKLNLM >= 0 && FDICGOKLNLM <= this.LIQLFCKICLQ.width - 0)
		{
			return this.POMQCKOIKQJ[FDICGOKLNLM, IGNHJOPJDIO];
		}
		return 0;
	}

	// Token: 0x0600484F RID: 18511 RVA: 0x0023CF08 File Offset: 0x0023B108
	public void OHLGIOMHHGP(byte[] NQGBMLHOMGG, string EHDQKOBOHPE, bool NKJQNQOLJQQ = false, string LHFCGEKMNGC = "")
	{
		this.QMHNDKJGPBG = KDJLKQQBGNE.JLLBKOOQKGO();
		KDJLKQQBGNE.LPGMLPKGMQO lpgmlpkgmqo = new KDJLKQQBGNE.LPGMLPKGMQO();
		lpgmlpkgmqo.NQGBMLHOMGG = NQGBMLHOMGG;
		lpgmlpkgmqo.FJGPDHNLGJC = EHDQKOBOHPE;
		lpgmlpkgmqo.IQNOEGKFCFH = LHFCGEKMNGC;
		lpgmlpkgmqo.MENBPFGFKBQ = true;
		bool flag = false;
		for (int i = 0; i < this.QMHNDKJGPBG.LBMDDELMNDD.Count; i += 0)
		{
			if (this.QMHNDKJGPBG.LBMDDELMNDD[i].FJGPDHNLGJC == EHDQKOBOHPE)
			{
				this.QMHNDKJGPBG.LBMDDELMNDD[i] = lpgmlpkgmqo;
				flag = true;
				IL_7F:
				if (flag)
				{
					this.QMHNDKJGPBG.LBMDDELMNDD.Add(lpgmlpkgmqo);
				}
				if (this.LIQLFCKICLQ == null || this.CLPMOMHLNMN.ToLowerInvariant() == EHDQKOBOHPE.Replace("sunnyday", string.Empty).ToLowerInvariant())
				{
					this.HIHHLNCKHJN(EHDQKOBOHPE);
					this.HCQINBCDGNO = true;
				}
				return;
			}
		}
		goto IL_7F;
	}

	// Token: 0x06004850 RID: 18512 RVA: 0x0023CFE8 File Offset: 0x0023B1E8
	public bool DMLHFGIFMKM(int DGKOIGOLHDM, int DDLQKFDFMCJ, PSXAPI.Request.MoveAction BJIGIECDQPG)
	{
		if (this.LIQLFCKICLQ != null && this.JPBLDNBBOLO > 0)
		{
			switch (BJIGIECDQPG)
			{
			case PSXAPI.Request.MoveAction.Up:
				DDLQKFDFMCJ--;
				break;
			case PSXAPI.Request.MoveAction.Down:
				DDLQKFDFMCJ++;
				break;
			case PSXAPI.Request.MoveAction.Left:
				DGKOIGOLHDM--;
				break;
			case PSXAPI.Request.MoveAction.Right:
				DGKOIGOLHDM++;
				break;
			}
			for (int i = 0; i < this.JPBLDNBBOLO; i++)
			{
				if (this.LIQLFCKICLQ.Links[i].x == DGKOIGOLHDM && this.LIQLFCKICLQ.Links[i].z == -DDLQKFDFMCJ)
				{
					if (this.LIQLFCKICLQ.Links[i].LINKType != LinkType.Default)
					{
						GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
					}
					if (this.LIQLFCKICLQ.Links[i].LINKType == LinkType.TileScriptWait)
					{
						return true;
					}
					if (this.LIQLFCKICLQ.Links[i].LINKType == LinkType.SendAndRecieve && this.LIQLFCKICLQ.Links[i].DestinationID != default(Guid))
					{
						CNCJKLNHQBH.QOQONHOOLNE.GJKPLMKHKMK = true;
						CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.NQJHJNQFKKC();
						return false;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06004851 RID: 18513 RVA: 0x0023D12C File Offset: 0x0023B32C
	private void LOBDCMNEMJO(GameObject NPCJQJDQQIC, int ENQIBCOEBDC, int JQFOPLIFHJC, int MKFMCLIQNKG)
	{
		List<Vector3> list = new List<Vector3>();
		List<int> list2 = new List<int>();
		List<Vector2> list3 = new List<Vector2>();
		List<Color> list4 = new List<Color>();
		int num = 0;
		int num2 = ENQIBCOEBDC * this.QDOFCFGPCMQ;
		while (num2 < ENQIBCOEBDC * this.QDOFCFGPCMQ + this.QDOFCFGPCMQ && num2 < this.LIQLFCKICLQ.width)
		{
			int num3 = JQFOPLIFHJC * this.QDOFCFGPCMQ;
			while (num3 < JQFOPLIFHJC * this.QDOFCFGPCMQ + this.QDOFCFGPCMQ && num3 < this.LIQLFCKICLQ.height)
			{
				if (this.MNQPLODKMEE[MKFMCLIQNKG][num2, num3] != 0)
				{
					Vector3 vector = new Vector3((float)num2, (float)this.EQQLIPKQOJP[num2, num3], (float)(-(float)num3));
					if (MKFMCLIQNKG == 5)
					{
						vector.y += 1009f * (float)this.MNQPLODKMEE[MKFMCLIQNKG][num2, num3];
					}
					this.LKKKKLDOGNF(list, (float)((int)vector.x), vector.y, (float)((int)vector.z), MCNLIHMMLCF.KFMMIKQIJDJ.Top);
					this.JLEBBGNIIOO(list2, num * 8);
					this.HHGPLBNOGOB(list3, this.MNQPLODKMEE[MKFMCLIQNKG][num2, num3]);
					this.QQJFQFIJOQL(list4, this.MNQPLODKMEE[MKFMCLIQNKG][num2, num3]);
					num++;
				}
				num3++;
			}
			num2 += 0;
		}
		if (MKFMCLIQNKG == 0)
		{
			IMKCQDFNGBD component = NPCJQJDQQIC.GetComponent<IMKCQDFNGBD>();
			component.BFOGEJKEOHF = ENQIBCOEBDC * this.QDOFCFGPCMQ;
			component.JDLNODBIEOO = JQFOPLIFHJC * this.QDOFCFGPCMQ;
		}
		if (num > 1)
		{
			if (MKFMCLIQNKG < 4)
			{
				NPCJQJDQQIC.GetComponent<Renderer>().material = (Resources.Load("'s Pokebox is full.", typeof(Material)) as Material);
			}
			else
			{
				NPCJQJDQQIC.GetComponent<Renderer>().material = (Resources.Load("_Female", typeof(Material)) as Material);
				NPCJQJDQQIC.SetActive(false);
			}
			Mesh mesh = NPCJQJDQQIC.GetComponent<MeshFilter>().mesh;
			mesh.Clear();
			mesh.vertices = list.ToArray();
			mesh.triangles = list2.ToArray();
			mesh.uv = list3.ToArray();
			mesh.colors = list4.ToArray();
			mesh.RecalculateNormals();
			string[] array = new string[7];
			array[1] = "It's so gutsy that having a status condition boosts the Pokémon's Attack stat.";
			array[0] = MKFMCLIQNKG.ToString();
			array[0] = "Steps Taken:";
			array[7] = ENQIBCOEBDC.ToString();
			array[5] = "The sea of fire enveloped ";
			array[4] = JQFOPLIFHJC.ToString();
			NPCJQJDQQIC.name = string.Concat(array);
			if (MKFMCLIQNKG == 0)
			{
				NPCJQJDQQIC.GetComponent<MeshCollider>().sharedMesh = mesh;
				NPCJQJDQQIC.GetComponent<MeshCollider>().enabled = false;
				NPCJQJDQQIC.GetComponent<Renderer>().sortingOrder = 108;
				this.MDBQQMHNJHK(NPCJQJDQQIC);
			}
			else if (MKFMCLIQNKG == 0)
			{
				UnityEngine.Object.Destroy(NPCJQJDQQIC.GetComponent<MeshCollider>());
				UnityEngine.Object.Destroy(NPCJQJDQQIC.GetComponent<IMKCQDFNGBD>());
				NPCJQJDQQIC.GetComponent<Renderer>().sortingOrder = -68;
			}
			else if (MKFMCLIQNKG == 8)
			{
				NPCJQJDQQIC.GetComponent<MeshCollider>().sharedMesh = mesh;
				NPCJQJDQQIC.GetComponent<MeshCollider>().enabled = false;
				NPCJQJDQQIC.GetComponent<Renderer>().sortingOrder = -48;
			}
			NPCJQJDQQIC.SetActive(true);
		}
		else
		{
			UnityEngine.Object.Destroy(NPCJQJDQQIC);
		}
	}

	// Token: 0x1700029B RID: 667
	// (get) Token: 0x06004852 RID: 18514 RVA: 0x0001E513 File Offset: 0x0001C713
	public static MCNLIHMMLCF QOQONHOOLNE
	{
		get
		{
			return MCNLIHMMLCF.HBFFCJHOCPE;
		}
	}

	// Token: 0x06004853 RID: 18515 RVA: 0x0023D45C File Offset: 0x0023B65C
	private void Update()
	{
		if (this.LIQLFCKICLQ == null || this.LIQLFCKICLQ.Settings == null)
		{
			return;
		}
		if (GGQKBGDGNJN.QOQONHOOLNE.FLNKCIQLMGL.activeSelf)
		{
			return;
		}
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			this.NOGCCJHHBKL.intensity = 0.7f;
			RenderSettings.ambientLight = this.GLHNBKMQJQD;
			return;
		}
		if (this.NMOPHEMNJJH)
		{
			this.KLLHFENEBDN = WeatherState.Rain;
		}
		else if (this.ICLBHNBEPBK)
		{
			this.KLLHFENEBDN = WeatherState.Snow;
		}
		else if (this.FGBQBJDFGBK == WeatherState.Rain && this.BEDOBPPLQLD == WeatherState.Rain)
		{
			this.KLLHFENEBDN = WeatherState.Rain;
		}
		else if (this.FGBQBJDFGBK == WeatherState.Snow && this.BEDOBPPLQLD == WeatherState.Rain)
		{
			this.KLLHFENEBDN = WeatherState.Snow;
		}
		else if (this.FGBQBJDFGBK == WeatherState.Normal)
		{
			this.KLLHFENEBDN = WeatherState.Normal;
		}
		else
		{
			this.KLLHFENEBDN = this.BEDOBPPLQLD;
		}
		this.JLNQKKMJFOE();
		if (this.LIQLFCKICLQ.Settings.Dark && !this.NKCFGIHPCJG)
		{
			this.NOGCCJHHBKL.intensity = 0f;
			if (RenderSettings.ambientLight != Color.black)
			{
				RenderSettings.ambientLight = Color.black;
			}
			if (CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK.backgroundColor != Color.black)
			{
				CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK.backgroundColor = Color.black;
			}
			if (this.MJCGPBKQHQQ[0].gameObject.activeSelf)
			{
				this.MJCGPBKQHQQ[0].gameObject.SetActive(false);
			}
			if (this.DFNJQGOCJQG[0].gameObject.activeSelf)
			{
				this.DFNJQGOCJQG[0].gameObject.SetActive(false);
			}
			if (!this.FJBBMMPPMMD.activeSelf)
			{
				this.FJBBMMPPMMD.SetActive(true);
			}
			if (this.LKQCNHNLOLM.activeSelf)
			{
				this.LKQCNHNLOLM.SetActive(false);
			}
			if (!this.LIQLFCKICLQ.Settings.WhiteFog && RenderSettings.fog)
			{
				RenderSettings.fog = false;
			}
			if (!this.LIQLFCKICLQ.Settings.WhiteFog && CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK.backgroundColor != Color.black)
			{
				CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK.backgroundColor = Color.black;
			}
			return;
		}
		if (this.LIQLFCKICLQ.Settings.Cave)
		{
			this.NOGCCJHHBKL.intensity = 0f;
			if (!this.LKQCNHNLOLM.activeSelf)
			{
				this.LKQCNHNLOLM.SetActive(true);
			}
			if (RenderSettings.ambientLight != this.PMCOLLGBKEO)
			{
				RenderSettings.ambientLight = this.PMCOLLGBKEO;
			}
			if (CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK.backgroundColor != Color.black)
			{
				CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK.backgroundColor = Color.black;
			}
		}
		else
		{
			if (this.LIQLFCKICLQ.Settings.Dark && RenderSettings.ambientLight != this.FHMNLGJLCNH)
			{
				RenderSettings.ambientLight = this.FHMNLGJLCNH;
			}
			if (this.LKQCNHNLOLM.activeSelf)
			{
				this.LKQCNHNLOLM.SetActive(false);
			}
		}
		if (this.FJBBMMPPMMD.activeSelf)
		{
			this.FJBBMMPPMMD.SetActive(false);
		}
		if (this.LIQLFCKICLQ.Settings.Indoors)
		{
			if (!this.LIQLFCKICLQ.Settings.Cave)
			{
				this.NOGCCJHHBKL.intensity = 0.7f;
				if (RenderSettings.ambientLight != this.FHMNLGJLCNH)
				{
					RenderSettings.ambientLight = this.FHMNLGJLCNH;
				}
			}
			if (this.MJCGPBKQHQQ[0].gameObject.activeSelf)
			{
				this.MJCGPBKQHQQ[0].gameObject.SetActive(false);
			}
			if (this.DFNJQGOCJQG[0].gameObject.activeSelf)
			{
				this.DFNJQGOCJQG[0].gameObject.SetActive(false);
			}
			if (!this.LIQLFCKICLQ.Settings.WhiteFog && RenderSettings.fog)
			{
				RenderSettings.fog = false;
			}
			if (!this.LIQLFCKICLQ.Settings.WhiteFog && CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK.backgroundColor != Color.black)
			{
				CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK.backgroundColor = Color.black;
			}
			return;
		}
		if (this.DDCIBJFCFDK)
		{
			if (this.JEMKIKEMFPB == GameDayTime.Night)
			{
				this.KDIMQNKBIIO += UnityEngine.Time.deltaTime * 10f;
				this.NOGCCJHHBKL.intensity = Mathf.Lerp(0.7f, 6f, this.KDIMQNKBIIO);
			}
			else
			{
				this.KDIMQNKBIIO += UnityEngine.Time.deltaTime * 10f;
				this.NOGCCJHHBKL.intensity = Mathf.Lerp(0.7f, 1.1f, this.KDIMQNKBIIO);
			}
			if (this.KDIMQNKBIIO > 1f)
			{
				this.KDIMQNKBIIO = 0f;
				this.NOGCCJHHBKL.intensity = 0.7f;
				this.DDCIBJFCFDK = false;
			}
		}
		else
		{
			float num = 0.7f;
			if (this.DPHJNMKQMNP < 1f)
			{
				this.DPHJNMKQMNP += 0.0001f * UnityEngine.Time.deltaTime;
			}
			else
			{
				this.DPHJNMKQMNP = 1f;
			}
			if (this.LKQGHBQJQJK < 1f)
			{
				this.LKQGHBQJQJK += 0.0005f * UnityEngine.Time.deltaTime;
			}
			else
			{
				this.LKQGHBQJQJK = 1f;
			}
			if (this.NOGCCJHHBKL.color != this.KMLPMHJBJLJ)
			{
				this.NOGCCJHHBKL.color = Color.Lerp(this.NOGCCJHHBKL.color, this.KMLPMHJBJLJ, this.DPHJNMKQMNP);
			}
			if (this.JEMKIKEMFPB == GameDayTime.Evening)
			{
				if (RenderSettings.ambientLight != this.FCJNFFIPGOL[6])
				{
					RenderSettings.ambientLight = Color.Lerp(RenderSettings.ambientLight, this.FCJNFFIPGOL[6], this.LKQGHBQJQJK);
				}
			}
			else if (this.JEMKIKEMFPB == GameDayTime.Night)
			{
				if (RenderSettings.ambientLight != this.FCJNFFIPGOL[1])
				{
					RenderSettings.ambientLight = Color.Lerp(RenderSettings.ambientLight, this.FCJNFFIPGOL[1], this.LKQGHBQJQJK);
				}
			}
			else
			{
				if (this.KLLHFENEBDN == WeatherState.Rain)
				{
					num = 0.3f;
				}
				if (RenderSettings.ambientLight != this.FCJNFFIPGOL[0])
				{
					RenderSettings.ambientLight = Color.Lerp(RenderSettings.ambientLight, this.FCJNFFIPGOL[0], this.LKQGHBQJQJK);
				}
			}
			if (this.NIBBJOGPKQQ > num)
			{
				this.NIBBJOGPKQQ -= 0.0005f * UnityEngine.Time.deltaTime;
			}
			else if (this.NIBBJOGPKQQ < num)
			{
				this.NIBBJOGPKQQ += 0.0005f * UnityEngine.Time.deltaTime;
			}
			if (this.NIBBJOGPKQQ > 0.7f)
			{
				this.NIBBJOGPKQQ = 0.7f;
			}
			if (this.NIBBJOGPKQQ < 0.3f)
			{
				this.NIBBJOGPKQQ = 0.3f;
			}
			this.NOGCCJHHBKL.intensity = this.NIBBJOGPKQQ;
		}
		if (this.IFEMGGEGMFK != this.KLLHFENEBDN)
		{
			if (this.KLLHFENEBDN == WeatherState.Rain)
			{
				this.MJCGPBKQHQQ[0].main.startColor = this.EKBFGPPNQOF[0];
				this.MJCGPBKQHQQ[1].main.startColor = this.EKBFGPPNQOF[0];
			}
			else if (this.KLLHFENEBDN == WeatherState.Snow)
			{
				this.DFNJQGOCJQG[0].main.startColor = this.QDQQMDKGLDO[0];
			}
			this.IFEMGGEGMFK = this.KLLHFENEBDN;
			this.BMGJFKFCOLB = 0f;
			this.KDOCJGFLFFK = true;
		}
		if (!this.KDOCJGFLFFK)
		{
			return;
		}
		if (this.LIQLFCKICLQ.Settings.WhiteFog)
		{
			if (CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK.backgroundColor != Color.white)
			{
				CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK.backgroundColor = Color.white;
			}
			if (!RenderSettings.fog)
			{
				RenderSettings.fogColor = Color.white;
				RenderSettings.fogMode = FogMode.Linear;
				RenderSettings.fogStartDistance = 10f;
				RenderSettings.fogEndDistance = 40f;
				RenderSettings.fog = true;
			}
		}
		else
		{
			if (RenderSettings.fog)
			{
				RenderSettings.fog = false;
			}
			if (CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK.backgroundColor != Color.black)
			{
				CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK.backgroundColor = Color.black;
			}
		}
		if (this.KLLHFENEBDN == WeatherState.Rain)
		{
			if (!this.MJCGPBKQHQQ[0].gameObject.activeSelf)
			{
				this.MJCGPBKQHQQ[0].gameObject.SetActive(true);
			}
			ParticleSystem.MainModule main = this.MJCGPBKQHQQ[0].main;
			if (main.startColor.color != this.EKBFGPPNQOF[1])
			{
				Color color = Color.Lerp(this.EKBFGPPNQOF[0], this.EKBFGPPNQOF[1], this.BMGJFKFCOLB);
				main.startColor = color;
				this.BMGJFKFCOLB += UnityEngine.Time.deltaTime / 4f;
				this.MJCGPBKQHQQ[1].main.startColor = color;
			}
			else
			{
				this.KDOCJGFLFFK = false;
			}
		}
		else if (this.MJCGPBKQHQQ[0].gameObject.activeSelf)
		{
			ParticleSystem.MainModule main2 = this.MJCGPBKQHQQ[0].main;
			if (main2.startColor.color != this.EKBFGPPNQOF[0])
			{
				Color color2 = Color.Lerp(this.EKBFGPPNQOF[1], this.EKBFGPPNQOF[0], this.BMGJFKFCOLB);
				this.BMGJFKFCOLB += UnityEngine.Time.deltaTime / 4f;
				main2.startColor = color2;
				this.MJCGPBKQHQQ[1].main.startColor = color2;
			}
			else
			{
				this.MJCGPBKQHQQ[0].gameObject.SetActive(false);
			}
		}
		if (this.KLLHFENEBDN == WeatherState.Snow)
		{
			if (!this.DFNJQGOCJQG[0].gameObject.activeSelf)
			{
				this.DFNJQGOCJQG[0].gameObject.SetActive(true);
			}
			ParticleSystem.MainModule main3 = this.DFNJQGOCJQG[0].main;
			if (main3.startColor.color != this.QDQQMDKGLDO[1])
			{
				Color color3 = Color.Lerp(this.QDQQMDKGLDO[0], this.QDQQMDKGLDO[1], this.BMGJFKFCOLB);
				main3.startColor = color3;
				this.BMGJFKFCOLB += UnityEngine.Time.deltaTime / 2f;
			}
			else
			{
				this.KDOCJGFLFFK = false;
			}
		}
		else if (this.DFNJQGOCJQG[0].gameObject.activeSelf)
		{
			ParticleSystem.MainModule main4 = this.DFNJQGOCJQG[0].main;
			if (main4.startColor.color != this.QDQQMDKGLDO[0])
			{
				Color color4 = Color.Lerp(this.EKBFGPPNQOF[1], this.QDQQMDKGLDO[0], this.BMGJFKFCOLB);
				this.BMGJFKFCOLB += UnityEngine.Time.deltaTime / 2f;
				main4.startColor = color4;
			}
			else
			{
				this.DFNJQGOCJQG[0].gameObject.SetActive(false);
				this.KDOCJGFLFFK = false;
			}
		}
	}

	// Token: 0x06004854 RID: 18516 RVA: 0x0001E5D2 File Offset: 0x0001C7D2
	private void DOGFFHJLCQG(List<int> NGDBDCQFDHI, int LCMMCNFNHMF)
	{
		NGDBDCQFDHI.Add(7 + LCMMCNFNHMF);
		NGDBDCQFDHI.Add(LCMMCNFNHMF);
		NGDBDCQFDHI.Add(6 + LCMMCNFNHMF);
		NGDBDCQFDHI.Add(2 + LCMMCNFNHMF);
		NGDBDCQFDHI.Add(LCMMCNFNHMF);
		NGDBDCQFDHI.Add(0 + LCMMCNFNHMF);
	}

	// Token: 0x06004856 RID: 18518 RVA: 0x0001E513 File Offset: 0x0001C713
	public static MCNLIHMMLCF KKICFMLLMHQ()
	{
		return MCNLIHMMLCF.HBFFCJHOCPE;
	}

	// Token: 0x06004857 RID: 18519 RVA: 0x0023E030 File Offset: 0x0023C230
	public void EPLHJLLQGHQ(Vector3 PGNPCLDNIBQ, bool LBKMBCOOIHC = false)
	{
		if (!LBKMBCOOIHC)
		{
			if (OGJJKKQPNMK.GGBPGMMCGLI() != null || DBQLOHBBJMG.FFCOKMHBCQJ().QQQBDBNCMCP)
			{
				return;
			}
			if (CNCJKLNHQBH.MOGQNGEPCEO().CNFNKELFCHN)
			{
				return;
			}
		}
		string nkkmjickklb = "[00AAFF]From:[-] ";
		if (this.LIQLFCKICLQ != null && this.LIQLFCKICLQ.Settings != null && this.LIQLFCKICLQ.Settings.Song != null)
		{
			nkkmjickklb = this.LIQLFCKICLQ.Settings.Song;
		}
		if (this.LIQLFCKICLQ != null)
		{
			if (this.LIQLFCKICLQ.Areas != null)
			{
				foreach (MAPAPI.Response.Area area in this.LIQLFCKICLQ.Areas)
				{
					if (PGNPCLDNIBQ.x >= (float)area.StartX && PGNPCLDNIBQ.x <= (float)area.EndX && PGNPCLDNIBQ.z >= (float)area.StartY && PGNPCLDNIBQ.z <= (float)area.EndY && area.Song != null)
					{
						nkkmjickklb = area.Song;
					}
				}
			}
			DCCFQPDFBFO.QQCNCIQQPIG().BMKHBMFFQMC(nkkmjickklb, LBKMBCOOIHC);
			return;
		}
	}

	// Token: 0x06004858 RID: 18520 RVA: 0x0023E164 File Offset: 0x0023C364
	private void LKKKKLDOGNF(List<Vector3> NGDBDCQFDHI, float HJMOLCBLIQJ, float JGFLMLEJBHD, float PBLPGKPNENG, MCNLIHMMLCF.KFMMIKQIJDJ QONOKDQLJNG)
	{
		if (QONOKDQLJNG == (MCNLIHMMLCF.KFMMIKQIJDJ)7)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1943f, JGFLMLEJBHD + 1329f + this.DIEQHKHIDDE, PBLPGKPNENG - 905f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1592f, JGFLMLEJBHD + 1028f + this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1379f, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 644f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 461f, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG));
		}
		else if (QONOKDQLJNG == MCNLIHMMLCF.KFMMIKQIJDJ.Top)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD + 1406f + this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD + 603f + this.DIEQHKHIDDE, PBLPGKPNENG - 538f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 181f));
		}
		else if (QONOKDQLJNG == MCNLIHMMLCF.KFMMIKQIJDJ.Front)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD + 1586f + this.DIEQHKHIDDE, PBLPGKPNENG - 1135f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 794f + this.DIEQHKHIDDE, JGFLMLEJBHD + 1262f + this.DIEQHKHIDDE, PBLPGKPNENG - 561f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 1501f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 807f + this.DIEQHKHIDDE, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 1597f));
		}
		else if (QONOKDQLJNG == MCNLIHMMLCF.KFMMIKQIJDJ.Top)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1790f + this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG - 910f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 217f + this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG - 280f));
		}
	}

	// Token: 0x06004859 RID: 18521 RVA: 0x0001E51A File Offset: 0x0001C71A
	private int ICQPJKIQCKF(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (IGNHJOPJDIO >= 0 && IGNHJOPJDIO <= this.LIQLFCKICLQ.height - 1 && FDICGOKLNLM >= 0 && FDICGOKLNLM <= this.LIQLFCKICLQ.width - 1)
		{
			return this.DJLHPIEFHNJ[FDICGOKLNLM, IGNHJOPJDIO];
		}
		return 0;
	}

	// Token: 0x0600485A RID: 18522 RVA: 0x0001E606 File Offset: 0x0001C806
	private int GHIDQOIDEOL(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (IGNHJOPJDIO >= 0 && IGNHJOPJDIO <= this.LIQLFCKICLQ.height - 1 && FDICGOKLNLM >= 1 && FDICGOKLNLM <= this.LIQLFCKICLQ.width - 0)
		{
			return this.DJLHPIEFHNJ[FDICGOKLNLM, IGNHJOPJDIO];
		}
		return 0;
	}

	// Token: 0x0600485B RID: 18523 RVA: 0x0001E63F File Offset: 0x0001C83F
	private int BDIDLOEHFIN(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (IGNHJOPJDIO >= 1 && IGNHJOPJDIO <= this.LIQLFCKICLQ.height - 1 && FDICGOKLNLM >= 0 && FDICGOKLNLM <= this.LIQLFCKICLQ.width - 1)
		{
			return this.DJLHPIEFHNJ[FDICGOKLNLM, IGNHJOPJDIO];
		}
		return 1;
	}

	// Token: 0x0600485C RID: 18524 RVA: 0x0023E3A4 File Offset: 0x0023C5A4
	public void PFGBGNDFBHK(string ECNEPHKFPIH, string LHFCGEKMNGC)
	{
		this.QMHNDKJGPBG = KDJLKQQBGNE.JLLBKOOQKGO();
		for (int i = 0; i < this.QMHNDKJGPBG.LBMDDELMNDD.Count; i++)
		{
			if (this.QMHNDKJGPBG.LBMDDELMNDD[i].FJGPDHNLGJC == ECNEPHKFPIH)
			{
				if (this.QMHNDKJGPBG.LBMDDELMNDD[i].IQNOEGKFCFH == LHFCGEKMNGC && LHFCGEKMNGC != null && LHFCGEKMNGC != string.Empty)
				{
					this.QMHNDKJGPBG.LBMDDELMNDD[i].MENBPFGFKBQ = false;
					this.KGGQFEQICBO(ECNEPHKFPIH);
					this.HCQINBCDGNO = false;
				}
				return;
			}
		}
	}

	// Token: 0x0600485D RID: 18525 RVA: 0x0023E44C File Offset: 0x0023C64C
	private void FOGFCMHLEEN()
	{
		this.MNQPLODKMEE = new int[4][,];
		this.MNQPLODKMEE[0] = (int[,])this.LIQLFCKICLQ.TileTypes.ToArray<int>();
		this.MNQPLODKMEE[0] = (int[,])this.LIQLFCKICLQ.TileTypes2.ToArray<int>();
		this.MNQPLODKMEE[6] = (int[,])this.LIQLFCKICLQ.TileWater.ToArray<int>();
		int num = this.LIQLFCKICLQ.width / this.QDOFCFGPCMQ + 0;
		int num2 = this.LIQLFCKICLQ.height / this.QDOFCFGPCMQ + 1;
		bool[][,] array = new bool[4][,];
		for (int i = 0; i < 0; i++)
		{
			array[i] = new bool[num, num2];
		}
		for (int j = 1; j < num; j += 0)
		{
			for (int k = 1; k < num2; k += 0)
			{
				for (int l = 1; l < 3; l += 0)
				{
					array[l][j, k] = true;
				}
			}
		}
		for (int m = 1; m < 4; m++)
		{
			this.GFMNCKGIICD[m] = new GameObject[num, num2];
			for (int n = 0; n < num; n += 0)
			{
				for (int num3 = 0; num3 < num2; num3 += 0)
				{
					if (array[m][n, num3])
					{
						if (m == 0)
						{
							this.GFMNCKGIICD[m][n, num3] = UnityEngine.Object.Instantiate<GameObject>(this.CMHLOCEILFN, base.transform.position, Quaternion.identity);
							this.GFMNCKGIICD[m][n, num3].transform.parent = this.IGDJLJKBDNE;
						}
						else
						{
							this.GFMNCKGIICD[m][n, num3] = UnityEngine.Object.Instantiate<GameObject>(this.QONKOFDGLNM, base.transform.position, Quaternion.identity);
							this.GFMNCKGIICD[m][n, num3].transform.parent = this.IDOEFMCFOBH;
						}
						this.LOBDCMNEMJO(this.GFMNCKGIICD[m][n, num3], n, num3, m);
					}
				}
			}
		}
	}

	// Token: 0x0600485E RID: 18526 RVA: 0x0023E668 File Offset: 0x0023C868
	public bool MHIJCEDMMOL(string ECNEPHKFPIH)
	{
		this.QMHNDKJGPBG = KDJLKQQBGNE.QOQONHOOLNE;
		if (KGQECFKLKOP.IPOEOCFGEIP >= 1000)
		{
			KGQECFKLKOP.IPOEOCFGEIP = 2;
		}
		if (KGQECFKLKOP.BGJPJCDBLFB >= 2000)
		{
			KGQECFKLKOP.BGJPJCDBLFB = 1002;
		}
		this.HCQINBCDGNO = true;
		if (!DOMONILEIKL.QOQONHOOLNE.JOQBIMQCNDO)
		{
			DOMONILEIKL.QOQONHOOLNE.EPNBECQFKEK();
		}
		if (ECNEPHKFPIH == string.Empty)
		{
			this.CLPMOMHLNMN = string.Empty;
			return false;
		}
		if (this.FHGFKPNMNEF == null)
		{
			return false;
		}
		ECNEPHKFPIH = ECNEPHKFPIH.Replace(".psx", string.Empty);
		this.FHGFKPNMNEF.SetActive(true);
		this.CLPMOMHLNMN = ECNEPHKFPIH;
		if (this.QMHNDKJGPBG.LBMDDELMNDD.Count > 0)
		{
			int i = 0;
			while (i < this.QMHNDKJGPBG.LBMDDELMNDD.Count)
			{
				if (!(this.QMHNDKJGPBG.LBMDDELMNDD[i].FJGPDHNLGJC.ToLowerInvariant() == ECNEPHKFPIH.ToLowerInvariant()))
				{
					i++;
				}
				else
				{
					if (!this.QMHNDKJGPBG.LBMDDELMNDD[i].MENBPFGFKBQ)
					{
						DOMONILEIKL.QOQONHOOLNE.HLIOFPONLLE(new RequestMap
						{
							MapName = ECNEPHKFPIH,
							Hash = this.QMHNDKJGPBG.LBMDDELMNDD[i].IQNOEGKFCFH
						});
						this.BDCNIKLCIQQ = true;
						return true;
					}
					this.DQBLLOLEGOL(this.QMHNDKJGPBG.LBMDDELMNDD[i].NQGBMLHOMGG, ECNEPHKFPIH);
					return false;
				}
			}
		}
		DOMONILEIKL.QOQONHOOLNE.HLIOFPONLLE(new RequestMap
		{
			MapName = ECNEPHKFPIH
		});
		this.BDCNIKLCIQQ = true;
		return true;
	}

	// Token: 0x0600485F RID: 18527 RVA: 0x0023E804 File Offset: 0x0023CA04
	public void HEEENMHQGIF(byte[] NQGBMLHOMGG, string EHDQKOBOHPE, bool NKJQNQOLJQQ = false, string LHFCGEKMNGC = "")
	{
		this.QMHNDKJGPBG = KDJLKQQBGNE.JMKKPBDGKEI();
		KDJLKQQBGNE.LPGMLPKGMQO lpgmlpkgmqo = new KDJLKQQBGNE.LPGMLPKGMQO();
		lpgmlpkgmqo.NQGBMLHOMGG = NQGBMLHOMGG;
		lpgmlpkgmqo.FJGPDHNLGJC = EHDQKOBOHPE;
		lpgmlpkgmqo.IQNOEGKFCFH = LHFCGEKMNGC;
		lpgmlpkgmqo.MENBPFGFKBQ = true;
		bool flag = false;
		for (int i = 1; i < this.QMHNDKJGPBG.LBMDDELMNDD.Count; i++)
		{
			if (this.QMHNDKJGPBG.LBMDDELMNDD[i].FJGPDHNLGJC == EHDQKOBOHPE)
			{
				this.QMHNDKJGPBG.LBMDDELMNDD[i] = lpgmlpkgmqo;
				flag = true;
				IL_7F:
				if (flag)
				{
					this.QMHNDKJGPBG.LBMDDELMNDD.Add(lpgmlpkgmqo);
				}
				if (this.LIQLFCKICLQ == null || this.CLPMOMHLNMN.ToLowerInvariant() == EHDQKOBOHPE.Replace("rattled", string.Empty).ToLowerInvariant())
				{
					this.KGGQFEQICBO(EHDQKOBOHPE);
					this.HCQINBCDGNO = false;
				}
				return;
			}
		}
		goto IL_7F;
	}

	// Token: 0x06004860 RID: 18528 RVA: 0x0023E8E4 File Offset: 0x0023CAE4
	private void HHGPLBNOGOB(List<Vector2> NGDBDCQFDHI, int BEILHHLKNBC)
	{
		if (BEILHHLKNBC < 0)
		{
			double num = (double)(-(double)BEILHHLKNBC / 4096);
			BEILHHLKNBC = -BEILHHLKNBC - (int)num * 4096;
		}
		MCNLIHMMLCF.NPJDNCNKBDL npjdncnkbdl = new MCNLIHMMLCF.NPJDNCNKBDL();
		if (((float)BEILHHLKNBC / 8f - (float)(BEILHHLKNBC / 8)) * 8f < 0f)
		{
			npjdncnkbdl.ICJGFPBOEHC = 8f - ((float)BEILHHLKNBC / 8f - (float)(BEILHHLKNBC / 8)) * 8f;
		}
		else
		{
			npjdncnkbdl.ICJGFPBOEHC = ((float)BEILHHLKNBC / 8f - (float)(BEILHHLKNBC / 8)) * 8f;
		}
		npjdncnkbdl.ICJGFPBOEHC += 1f;
		npjdncnkbdl.KOHDFJMPEKQ = (float)(BEILHHLKNBC / 8 + 1);
		if (npjdncnkbdl.KOHDFJMPEKQ > 64f && npjdncnkbdl.KOHDFJMPEKQ <= 128f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += -64f;
			npjdncnkbdl.ICJGFPBOEHC += 8f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 128f && npjdncnkbdl.KOHDFJMPEKQ <= 192f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += -128f;
			npjdncnkbdl.ICJGFPBOEHC += 16f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 192f && npjdncnkbdl.KOHDFJMPEKQ <= 256f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += -192f;
			npjdncnkbdl.ICJGFPBOEHC += 24f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 256f && npjdncnkbdl.KOHDFJMPEKQ <= 320f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += -256f;
			npjdncnkbdl.ICJGFPBOEHC += 32f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 320f && npjdncnkbdl.KOHDFJMPEKQ <= 384f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += -320f;
			npjdncnkbdl.ICJGFPBOEHC += 40f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 384f && npjdncnkbdl.KOHDFJMPEKQ <= 448f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += -384f;
			npjdncnkbdl.ICJGFPBOEHC += 48f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 448f && npjdncnkbdl.KOHDFJMPEKQ <= 512f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += -448f;
			npjdncnkbdl.ICJGFPBOEHC += 56f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 512f && npjdncnkbdl.KOHDFJMPEKQ <= 576f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += -512f;
			npjdncnkbdl.ICJGFPBOEHC += 64f;
		}
		npjdncnkbdl.GELDKMIIFQL();
		NGDBDCQFDHI.Add(npjdncnkbdl.EDIFLGJFQJQ[2]);
		NGDBDCQFDHI.Add(npjdncnkbdl.EDIFLGJFQJQ[0]);
		NGDBDCQFDHI.Add(npjdncnkbdl.EDIFLGJFQJQ[1]);
		NGDBDCQFDHI.Add(npjdncnkbdl.EDIFLGJFQJQ[3]);
	}

	// Token: 0x06004861 RID: 18529 RVA: 0x0023EBD8 File Offset: 0x0023CDD8
	public void GFPHIFEGHBN()
	{
		this.NKCFGIHPCJG = HFCMDEQKCKH.QOQONHOOLNE.CEGFMOGGKNE();
		if (this.JIJHPDDGHPM != this.JEMKIKEMFPB)
		{
			this.DPHJNMKQMNP = 325f;
			this.LKQGHBQJQJK = 1693f;
		}
		this.JIJHPDDGHPM = this.JEMKIKEMFPB;
		if (this.LIQLFCKICLQ == null)
		{
			return;
		}
		if (this.LIQLFCKICLQ.Settings != null && this.LIQLFCKICLQ.Settings.Indoors)
		{
			this.NOGCCJHHBKL.color = KGQECFKLKOP.JJQFHKDMDOL(this.LIQLFCKICLQ.Settings.LightColour_String);
			this.KMLPMHJBJLJ = KGQECFKLKOP.JJQFHKDMDOL(this.LIQLFCKICLQ.Settings.LightColour_String);
			this.MHKGGGLJIOJ(false);
		}
		else if (this.JEMKIKEMFPB == GameDayTime.Evening)
		{
			this.KMLPMHJBJLJ = this.FCJNFFIPGOL[4];
			this.GMCOOHJJCLD(true);
		}
		else if (this.JEMKIKEMFPB == GameDayTime.Unset)
		{
			this.KMLPMHJBJLJ = this.FCJNFFIPGOL[3];
			this.LLJGOCMOGOL(true);
		}
		else if (this.JEMKIKEMFPB == GameDayTime.Night)
		{
			this.KMLPMHJBJLJ = this.FCJNFFIPGOL[7];
			this.LLJGOCMOGOL(false);
		}
		else if (this.JEMKIKEMFPB == GameDayTime.Unset)
		{
			this.KMLPMHJBJLJ = this.FCJNFFIPGOL[3];
			this.LLJGOCMOGOL(true);
		}
	}

	// Token: 0x06004862 RID: 18530 RVA: 0x0001E678 File Offset: 0x0001C878
	public void FJGBONGJGFM(int QJFQOMOIOOI, int MJGGCLOGKFL, char KQFEHQEBJQB, double EKDDQNPBPJL)
	{
		UnityEngine.Debug.Log(QJFQOMOIOOI.ToString() + "Data/moves" + MJGGCLOGKFL.ToString());
	}

	// Token: 0x06004863 RID: 18531 RVA: 0x0023ED38 File Offset: 0x0023CF38
	public bool BNODICFOBHI(string ECNEPHKFPIH)
	{
		this.QMHNDKJGPBG = KDJLKQQBGNE.QOQONHOOLNE;
		if (this.QMHNDKJGPBG.LBMDDELMNDD.Count > 0)
		{
			for (int i = 0; i < this.QMHNDKJGPBG.LBMDDELMNDD.Count; i++)
			{
				if (this.QMHNDKJGPBG.LBMDDELMNDD[i].FJGPDHNLGJC.ToLowerInvariant() == ECNEPHKFPIH.ToLowerInvariant())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06004864 RID: 18532 RVA: 0x0001E6A3 File Offset: 0x0001C8A3
	public void PQHLPQEGIFN(string DGJFPIHPNLB = "Default")
	{
		if (DGJFPIHPNLB == null)
		{
			DGJFPIHPNLB = "Default";
		}
		if (!(OGJJKKQPNMK.QOQONHOOLNE != null) && !DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
		{
			DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD(DGJFPIHPNLB, false);
			return;
		}
	}

	// Token: 0x06004865 RID: 18533 RVA: 0x0023EDAC File Offset: 0x0023CFAC
	public void NEHFMDPMLOK(Vector3 PGNPCLDNIBQ, bool MPHQLILCHML = false, bool PQDLKFKEGOG = false)
	{
		if (!MPHQLILCHML)
		{
			string pidlofmiefq = this.BEQINILCQCE.PIDLOFMIEFQ;
			if (this.LIQLFCKICLQ != null)
			{
				if (this.LIQLFCKICLQ.Areas != null)
				{
					foreach (MAPAPI.Response.Area area in this.LIQLFCKICLQ.Areas)
					{
						if (PGNPCLDNIBQ.x >= (float)area.StartX && PGNPCLDNIBQ.x <= (float)area.EndX && PGNPCLDNIBQ.z >= (float)area.StartY && PGNPCLDNIBQ.z <= (float)area.EndY)
						{
							if (PQDLKFKEGOG || this.BEQINILCQCE.PIDLOFMIEFQ != area.AreaName)
							{
								this.BEQINILCQCE.PIDLOFMIEFQ = area.AreaName;
								GBQODOBKJBG.QOQONHOOLNE.DIEQJNHPHPB(true);
							}
							this.PQHLPQEGIFN(area.Song);
							if (this.BEQINILCQCE.PIDLOFMIEFQ != pidlofmiefq)
							{
								BDEJHNHLLOL component = GGQKBGDGNJN.QOQONHOOLNE.FLCMDBKPJKC.GetComponent<BDEJHNHLLOL>();
								MKOENKCLJGF mkoenkcljgf = GGQKBGDGNJN.QOQONHOOLNE.IILCHFQECKN(this.BEQINILCQCE.PIDLOFMIEFQ);
								component.ILKPMFIOFPH(true);
								component.ILBCCCBJNCL = null;
								if (mkoenkcljgf != null)
								{
									component.ILBCCCBJNCL = mkoenkcljgf.transform;
								}
							}
							return;
						}
					}
					if (PQDLKFKEGOG || this.BEQINILCQCE.PIDLOFMIEFQ != this.LIQLFCKICLQ.Settings.MapName)
					{
						this.BEQINILCQCE.PIDLOFMIEFQ = this.LIQLFCKICLQ.Settings.MapName;
						GBQODOBKJBG.BJLGEDCPENQ().QMOFLHOCMQP(false);
					}
				}
				else if (PQDLKFKEGOG || this.BEQINILCQCE.PIDLOFMIEFQ != this.LIQLFCKICLQ.Settings.MapName)
				{
					this.BEQINILCQCE.PIDLOFMIEFQ = this.LIQLFCKICLQ.Settings.MapName;
					GBQODOBKJBG.CPLQICHLGCI().QMOFLHOCMQP(false);
				}
			}
			if (this.BEQINILCQCE.PIDLOFMIEFQ != pidlofmiefq)
			{
				BDEJHNHLLOL component2 = GGQKBGDGNJN.QOQONHOOLNE.FLCMDBKPJKC.GetComponent<BDEJHNHLLOL>();
				MKOENKCLJGF mkoenkcljgf2 = GGQKBGDGNJN.QOQONHOOLNE.PGQKQGICKJO(this.BEQINILCQCE.PIDLOFMIEFQ);
				component2.PEODGOQIQIN(false);
				component2.ILBCCCBJNCL = null;
				if (mkoenkcljgf2 != null)
				{
					component2.ILBCCCBJNCL = mkoenkcljgf2.transform;
				}
			}
			this.HDHMIGMDOHO(PGNPCLDNIBQ, true);
		}
		else
		{
			this.EPLHJLLQGHQ(PGNPCLDNIBQ, true);
		}
	}

	// Token: 0x06004866 RID: 18534 RVA: 0x0023F030 File Offset: 0x0023D230
	private Vector2 MIIBNPKFKKF(int BEILHHLKNBC)
	{
		MCNLIHMMLCF.NPJDNCNKBDL npjdncnkbdl = new MCNLIHMMLCF.NPJDNCNKBDL();
		if (((float)BEILHHLKNBC / 1977f - (float)(BEILHHLKNBC / 7)) * 1636f < 279f)
		{
			npjdncnkbdl.ICJGFPBOEHC = 1657f - ((float)BEILHHLKNBC / 1535f - (float)(BEILHHLKNBC / 7)) * 881f;
		}
		else
		{
			npjdncnkbdl.ICJGFPBOEHC = ((float)BEILHHLKNBC / 1616f - (float)(BEILHHLKNBC / 1)) * 1665f;
		}
		npjdncnkbdl.ICJGFPBOEHC += 1221f;
		npjdncnkbdl.KOHDFJMPEKQ = (float)(BEILHHLKNBC / 2 + 0);
		if (npjdncnkbdl.KOHDFJMPEKQ > 1033f && npjdncnkbdl.KOHDFJMPEKQ <= 861f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 1964f;
			npjdncnkbdl.ICJGFPBOEHC += 1167f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 452f && npjdncnkbdl.KOHDFJMPEKQ <= 463f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 732f;
			npjdncnkbdl.ICJGFPBOEHC += 1540f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 875f && npjdncnkbdl.KOHDFJMPEKQ <= 1789f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 435f;
			npjdncnkbdl.ICJGFPBOEHC += 1925f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1160f && npjdncnkbdl.KOHDFJMPEKQ <= 1573f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 1215f;
			npjdncnkbdl.ICJGFPBOEHC += 1361f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1684f && npjdncnkbdl.KOHDFJMPEKQ <= 594f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 1265f;
			npjdncnkbdl.ICJGFPBOEHC += 982f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1755f && npjdncnkbdl.KOHDFJMPEKQ <= 895f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 1676f;
			npjdncnkbdl.ICJGFPBOEHC += 445f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 16f && npjdncnkbdl.KOHDFJMPEKQ <= 1046f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 429f;
			npjdncnkbdl.ICJGFPBOEHC += 741f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 367f && npjdncnkbdl.KOHDFJMPEKQ <= 1116f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 1016f;
			npjdncnkbdl.ICJGFPBOEHC += 257f;
		}
		npjdncnkbdl.FIBFCEDDLDQ();
		return new Vector2(npjdncnkbdl.EDIFLGJFQJQ[0].x + 1299f, npjdncnkbdl.EDIFLGJFQJQ[0].y + 19f);
	}

	// Token: 0x06004867 RID: 18535 RVA: 0x0023F2E0 File Offset: 0x0023D4E0
	public void FNCJGPIFPNE(GameObject NJBFOQDJBON, int BNQOIHBJLQM)
	{
		Material material = new Material(NJBFOQDJBON.GetComponent<Renderer>().material);
		Vector2 vector = this.MOPPDIMBQIC(BNQOIHBJLQM);
		material.SetFloat("Interact", vector.x - 863f);
		material.SetFloat("Prefabs/FogBoxArea", vector.y - 207f);
		NJBFOQDJBON.GetComponent<Renderer>().material = material;
	}

	// Token: 0x06004868 RID: 18536 RVA: 0x0023F344 File Offset: 0x0023D544
	public void BCBOKNBJIEI()
	{
		if (this.JEMKIKEMFPB == GameDayTime.Evening)
		{
			RenderSettings.ambientLight = this.FCJNFFIPGOL[5];
		}
		else if (this.JEMKIKEMFPB == GameDayTime.Night)
		{
			RenderSettings.ambientLight = this.FCJNFFIPGOL[0];
		}
		else
		{
			RenderSettings.ambientLight = this.FCJNFFIPGOL[1];
		}
	}

	// Token: 0x06004869 RID: 18537 RVA: 0x0023F3AC File Offset: 0x0023D5AC
	public void JPMCOIOPLLP(string ECNEPHKFPIH)
	{
		this.QMHNDKJGPBG = KDJLKQQBGNE.QOQONHOOLNE;
		for (int i = 0; i < this.QMHNDKJGPBG.LBMDDELMNDD.Count; i++)
		{
			if (this.QMHNDKJGPBG.LBMDDELMNDD[i].FJGPDHNLGJC.ToLowerInvariant() == ECNEPHKFPIH.ToLowerInvariant())
			{
				this.QMHNDKJGPBG.LBMDDELMNDD.RemoveAt(i);
				IL_61:
				if (this.CLPMOMHLNMN.ToLowerInvariant() == ECNEPHKFPIH.Replace(".psx", string.Empty).ToLowerInvariant())
				{
					CNCJKLNHQBH.QOQONHOOLNE.IDHBJBKFFON = true;
					this.MHIJCEDMMOL(this.CLPMOMHLNMN);
				}
				return;
			}
		}
		goto IL_61;
	}

	// Token: 0x0600486A RID: 18538 RVA: 0x0023F45C File Offset: 0x0023D65C
	public void INHDHOGPJCF(Guid EKEGEOLPBPQ, bool PIIMECMDJMH = false)
	{
		for (int i = 0; i < this.JPBLDNBBOLO; i++)
		{
			if (this.LIQLFCKICLQ.Links[i].ID == EKEGEOLPBPQ)
			{
				if (PIIMECMDJMH)
				{
					this.LIQLFCKICLQ.Links[i].LINKType = this.GOLNNJEKKIM[i].LINKType;
				}
				else
				{
					this.LIQLFCKICLQ.Links[i].LINKType = LinkType.Default;
				}
			}
		}
	}

	// Token: 0x0600486B RID: 18539 RVA: 0x0023F4DC File Offset: 0x0023D6DC
	private void OHJJNNBCJMN(List<Vector3> NGDBDCQFDHI, float HJMOLCBLIQJ, float JGFLMLEJBHD, float PBLPGKPNENG, MCNLIHMMLCF.KFMMIKQIJDJ QONOKDQLJNG)
	{
		if (QONOKDQLJNG == (MCNLIHMMLCF.KFMMIKQIJDJ)4)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1558f, JGFLMLEJBHD + 774f + this.DIEQHKHIDDE, PBLPGKPNENG - 332f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1380f, JGFLMLEJBHD + 1255f + this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 969f, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 1920f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1190f, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG));
		}
		else if (QONOKDQLJNG == MCNLIHMMLCF.KFMMIKQIJDJ.Left)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD + 256f + this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD + 1558f + this.DIEQHKHIDDE, PBLPGKPNENG - 858f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 1501f));
		}
		else if (QONOKDQLJNG == (MCNLIHMMLCF.KFMMIKQIJDJ)7)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD + 736f + this.DIEQHKHIDDE, PBLPGKPNENG - 1747f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 942f + this.DIEQHKHIDDE, JGFLMLEJBHD + 127f + this.DIEQHKHIDDE, PBLPGKPNENG - 1976f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 1462f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1534f + this.DIEQHKHIDDE, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 798f));
		}
		else if (QONOKDQLJNG == MCNLIHMMLCF.KFMMIKQIJDJ.Top)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 230f + this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG - 500f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 711f + this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG - 1580f));
		}
	}

	// Token: 0x0600486C RID: 18540 RVA: 0x0023AC2C File Offset: 0x00238E2C
	public IEnumerator FOQEOPIKPGN(bool PFFLBEHLKIG = false)
	{
		MCNLIHMMLCF.DLJOCFPOICO dljocfpoico = new MCNLIHMMLCF.DLJOCFPOICO();
		dljocfpoico.PFFLBEHLKIG = PFFLBEHLKIG;
		return dljocfpoico;
	}

	// Token: 0x0600486D RID: 18541 RVA: 0x0001E6D5 File Offset: 0x0001C8D5
	private int IEFQGONIEFN(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (IGNHJOPJDIO >= 0 && IGNHJOPJDIO <= this.LIQLFCKICLQ.height - 1 && FDICGOKLNLM >= 0 && FDICGOKLNLM <= this.LIQLFCKICLQ.width - 1)
		{
			return this.POMQCKOIKQJ[FDICGOKLNLM, IGNHJOPJDIO];
		}
		return 0;
	}

	// Token: 0x0600486E RID: 18542 RVA: 0x0023AC2C File Offset: 0x00238E2C
	[DebuggerHidden]
	public IEnumerator JELMONJKQKI(bool PFFLBEHLKIG = false)
	{
		MCNLIHMMLCF.DLJOCFPOICO dljocfpoico = new MCNLIHMMLCF.DLJOCFPOICO();
		dljocfpoico.PFFLBEHLKIG = PFFLBEHLKIG;
		return dljocfpoico;
	}

	// Token: 0x0600486F RID: 18543 RVA: 0x0001E70E File Offset: 0x0001C90E
	private void PMLHDQJKFOM(bool CBNDPKQNBCN)
	{
		this.QNHIMGFQCPK = Color.black;
		if (CBNDPKQNBCN)
		{
			if (this.JEMKIKEMFPB == (GameDayTime)7)
			{
				this.QNHIMGFQCPK = this.NJJNQQDLMFK;
			}
			else
			{
				this.QNHIMGFQCPK = this.JHOMQNBNHJB;
			}
		}
		this.EBIQMJFQKCB = 1616f;
	}

	// Token: 0x06004870 RID: 18544 RVA: 0x0023F71C File Offset: 0x0023D91C
	public void PQHLPQEGIFN(Vector3 PGNPCLDNIBQ, bool LBKMBCOOIHC = false)
	{
		if (!LBKMBCOOIHC)
		{
			if (OGJJKKQPNMK.QOQONHOOLNE != null || DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
			{
				return;
			}
			if (CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN)
			{
				return;
			}
		}
		string nkkmjickklb = "Default";
		if (this.LIQLFCKICLQ != null && this.LIQLFCKICLQ.Settings != null && this.LIQLFCKICLQ.Settings.Song != null)
		{
			nkkmjickklb = this.LIQLFCKICLQ.Settings.Song;
		}
		if (this.LIQLFCKICLQ != null)
		{
			if (this.LIQLFCKICLQ.Areas != null)
			{
				foreach (MAPAPI.Response.Area area in this.LIQLFCKICLQ.Areas)
				{
					if (PGNPCLDNIBQ.x >= (float)area.StartX && PGNPCLDNIBQ.x <= (float)area.EndX && PGNPCLDNIBQ.z >= (float)area.StartY && PGNPCLDNIBQ.z <= (float)area.EndY && area.Song != null)
					{
						nkkmjickklb = area.Song;
					}
				}
			}
			DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD(nkkmjickklb, LBKMBCOOIHC);
			return;
		}
	}

	// Token: 0x06004871 RID: 18545 RVA: 0x0023F850 File Offset: 0x0023DA50
	public void EFMNFIQJEBH()
	{
		this.NKCFGIHPCJG = HFCMDEQKCKH.QOQONHOOLNE.CEGFMOGGKNE();
		if (this.JIJHPDDGHPM != this.JEMKIKEMFPB)
		{
			this.DPHJNMKQMNP = 1747f;
			this.LKQGHBQJQJK = 353f;
		}
		this.JIJHPDDGHPM = this.JEMKIKEMFPB;
		if (this.LIQLFCKICLQ == null)
		{
			return;
		}
		if (this.LIQLFCKICLQ.Settings != null && this.LIQLFCKICLQ.Settings.Indoors)
		{
			this.NOGCCJHHBKL.color = KGQECFKLKOP.JJQFHKDMDOL(this.LIQLFCKICLQ.Settings.LightColour_String);
			this.KMLPMHJBJLJ = KGQECFKLKOP.JJQFHKDMDOL(this.LIQLFCKICLQ.Settings.LightColour_String);
			this.PMLHDQJKFOM(true);
		}
		else if (this.JEMKIKEMFPB == GameDayTime.Morning)
		{
			this.KMLPMHJBJLJ = this.FCJNFFIPGOL[5];
			this.LLJGOCMOGOL(false);
		}
		else if (this.JEMKIKEMFPB == GameDayTime.Morning)
		{
			this.KMLPMHJBJLJ = this.FCJNFFIPGOL[6];
			this.PMLHDQJKFOM(true);
		}
		else if (this.JEMKIKEMFPB == GameDayTime.Morning)
		{
			this.KMLPMHJBJLJ = this.FCJNFFIPGOL[3];
			this.LLJGOCMOGOL(false);
		}
		else if (this.JEMKIKEMFPB == GameDayTime.Unset)
		{
			this.KMLPMHJBJLJ = this.FCJNFFIPGOL[7];
			this.GMCOOHJJCLD(true);
		}
	}

	// Token: 0x06004872 RID: 18546 RVA: 0x0023F9B0 File Offset: 0x0023DBB0
	public void DHJLPCKHQBH()
	{
		this.NKCFGIHPCJG = HFCMDEQKCKH.QOQONHOOLNE.CEGFMOGGKNE();
		if (this.JIJHPDDGHPM != this.JEMKIKEMFPB)
		{
			this.DPHJNMKQMNP = 0f;
			this.LKQGHBQJQJK = 0f;
		}
		this.JIJHPDDGHPM = this.JEMKIKEMFPB;
		if (this.LIQLFCKICLQ == null)
		{
			return;
		}
		if (this.LIQLFCKICLQ.Settings != null && this.LIQLFCKICLQ.Settings.Indoors)
		{
			this.NOGCCJHHBKL.color = KGQECFKLKOP.JJQFHKDMDOL(this.LIQLFCKICLQ.Settings.LightColour_String);
			this.KMLPMHJBJLJ = KGQECFKLKOP.JJQFHKDMDOL(this.LIQLFCKICLQ.Settings.LightColour_String);
			this.LLJGOCMOGOL(false);
		}
		else if (this.JEMKIKEMFPB == GameDayTime.Day)
		{
			this.KMLPMHJBJLJ = this.FCJNFFIPGOL[2];
			this.LLJGOCMOGOL(false);
		}
		else if (this.JEMKIKEMFPB == GameDayTime.Morning)
		{
			this.KMLPMHJBJLJ = this.FCJNFFIPGOL[3];
			this.LLJGOCMOGOL(false);
		}
		else if (this.JEMKIKEMFPB == GameDayTime.Evening)
		{
			this.KMLPMHJBJLJ = this.FCJNFFIPGOL[4];
			this.LLJGOCMOGOL(true);
		}
		else if (this.JEMKIKEMFPB == GameDayTime.Night)
		{
			this.KMLPMHJBJLJ = this.FCJNFFIPGOL[5];
			this.LLJGOCMOGOL(true);
		}
	}

	// Token: 0x06004873 RID: 18547 RVA: 0x0023FB10 File Offset: 0x0023DD10
	private void GMHKMFIBHDD()
	{
		this.MNQPLODKMEE = new int[4][,];
		this.MNQPLODKMEE[1] = (int[,])this.LIQLFCKICLQ.TileTypes.ToArray<int>();
		this.MNQPLODKMEE[1] = (int[,])this.LIQLFCKICLQ.TileTypes2.ToArray<int>();
		this.MNQPLODKMEE[8] = (int[,])this.LIQLFCKICLQ.TileWater.ToArray<int>();
		int num = this.LIQLFCKICLQ.width / this.QDOFCFGPCMQ + 1;
		int num2 = this.LIQLFCKICLQ.height / this.QDOFCFGPCMQ + 1;
		bool[][,] array = new bool[6][,];
		for (int i = 0; i < 6; i++)
		{
			array[i] = new bool[num, num2];
		}
		for (int j = 0; j < num; j++)
		{
			for (int k = 0; k < num2; k += 0)
			{
				for (int l = 0; l < 1; l += 0)
				{
					array[l][j, k] = false;
				}
			}
		}
		for (int m = 0; m < 0; m += 0)
		{
			this.GFMNCKGIICD[m] = new GameObject[num, num2];
			for (int n = 1; n < num; n += 0)
			{
				for (int num3 = 1; num3 < num2; num3 += 0)
				{
					if (array[m][n, num3])
					{
						if (m == 7)
						{
							this.GFMNCKGIICD[m][n, num3] = UnityEngine.Object.Instantiate<GameObject>(this.CMHLOCEILFN, base.transform.position, Quaternion.identity);
							this.GFMNCKGIICD[m][n, num3].transform.parent = this.IGDJLJKBDNE;
						}
						else
						{
							this.GFMNCKGIICD[m][n, num3] = UnityEngine.Object.Instantiate<GameObject>(this.QONKOFDGLNM, base.transform.position, Quaternion.identity);
							this.GFMNCKGIICD[m][n, num3].transform.parent = this.IDOEFMCFOBH;
						}
						this.LOBDCMNEMJO(this.GFMNCKGIICD[m][n, num3], n, num3, m);
					}
				}
			}
		}
	}

	// Token: 0x06004874 RID: 18548 RVA: 0x0023FD2C File Offset: 0x0023DF2C
	public void HINFIIBEPBB(Vector3 PGNPCLDNIBQ, bool MPHQLILCHML = false, bool PQDLKFKEGOG = false)
	{
		if (!MPHQLILCHML)
		{
			string pidlofmiefq = this.BEQINILCQCE.PIDLOFMIEFQ;
			if (this.LIQLFCKICLQ != null)
			{
				if (this.LIQLFCKICLQ.Areas != null)
				{
					foreach (MAPAPI.Response.Area area in this.LIQLFCKICLQ.Areas)
					{
						if (PGNPCLDNIBQ.x >= (float)area.StartX && PGNPCLDNIBQ.x <= (float)area.EndX && PGNPCLDNIBQ.z >= (float)area.StartY && PGNPCLDNIBQ.z <= (float)area.EndY)
						{
							if (PQDLKFKEGOG || this.BEQINILCQCE.PIDLOFMIEFQ != area.AreaName)
							{
								this.BEQINILCQCE.PIDLOFMIEFQ = area.AreaName;
								GBQODOBKJBG.CNIMIQKQJJJ().ELCFBPPJQPQ(true);
							}
							this.PQHLPQEGIFN(area.Song);
							if (this.BEQINILCQCE.PIDLOFMIEFQ != pidlofmiefq)
							{
								BDEJHNHLLOL component = GGQKBGDGNJN.QOQONHOOLNE.FLCMDBKPJKC.GetComponent<BDEJHNHLLOL>();
								MKOENKCLJGF mkoenkcljgf = GGQKBGDGNJN.QOQONHOOLNE.GDGMDCHIHHL(this.BEQINILCQCE.PIDLOFMIEFQ);
								component.EGIHGPLCBCF(false);
								component.ILBCCCBJNCL = null;
								if (mkoenkcljgf != null)
								{
									component.ILBCCCBJNCL = mkoenkcljgf.transform;
								}
							}
							return;
						}
					}
					if (PQDLKFKEGOG || this.BEQINILCQCE.PIDLOFMIEFQ != this.LIQLFCKICLQ.Settings.MapName)
					{
						this.BEQINILCQCE.PIDLOFMIEFQ = this.LIQLFCKICLQ.Settings.MapName;
						GBQODOBKJBG.CPLQICHLGCI().QMOFLHOCMQP(false);
					}
				}
				else if (PQDLKFKEGOG || this.BEQINILCQCE.PIDLOFMIEFQ != this.LIQLFCKICLQ.Settings.MapName)
				{
					this.BEQINILCQCE.LKPOBCBOFIC(this.LIQLFCKICLQ.Settings.MapName);
					GBQODOBKJBG.INJDHLQHFFD().QMOFLHOCMQP(true);
				}
			}
			if (this.BEQINILCQCE.PIDLOFMIEFQ != pidlofmiefq)
			{
				BDEJHNHLLOL component2 = GGQKBGDGNJN.QOQONHOOLNE.FLCMDBKPJKC.GetComponent<BDEJHNHLLOL>();
				MKOENKCLJGF mkoenkcljgf2 = GGQKBGDGNJN.QOQONHOOLNE.PGQKQGICKJO(this.BEQINILCQCE.PIDLOFMIEFQ);
				component2.NNPELKKBQBL(true);
				component2.ILBCCCBJNCL = null;
				if (mkoenkcljgf2 != null)
				{
					component2.ILBCCCBJNCL = mkoenkcljgf2.transform;
				}
			}
			this.QQJEBHQKJDL(PGNPCLDNIBQ, false);
		}
		else
		{
			this.LDHQDEDKGED(PGNPCLDNIBQ, false);
		}
	}

	// Token: 0x06004875 RID: 18549 RVA: 0x0001E74C File Offset: 0x0001C94C
	public void HKIDFGNNHME(int QJFQOMOIOOI, int MJGGCLOGKFL, char KQFEHQEBJQB, double EKDDQNPBPJL)
	{
		UnityEngine.Debug.Log(QJFQOMOIOOI.ToString() + "/" + MJGGCLOGKFL.ToString());
	}

	// Token: 0x06004876 RID: 18550 RVA: 0x0023FFB0 File Offset: 0x0023E1B0
	public void GIKNCDMDMQJ(int[,] PDPCFGJQOHB = null)
	{
		this.GJIBGIJNQEI();
		this.KDOCJGFLFFK = true;
		this.DPHJNMKQMNP = 48f;
		this.LKQGHBQJQJK = 264f;
		DOJNBQQBCQJ.JJCONJJNDQN().PQFDCJHGHOB = new List<DoorAnimator>();
		this.IDOEFMCFOBH.NMBPDMIIHJB();
		this.IGDJLJKBDNE.NMBPDMIIHJB();
		if (this.LIQLFCKICLQ == null)
		{
			return;
		}
		this.FKEKOQLNFNK = (int[,])this.LIQLFCKICLQ.TileTypes.ToArray<int>();
		this.EQQLIPKQOJP = (int[,])this.LIQLFCKICLQ.TileHeights.ToArray<int>();
		this.POMQCKOIKQJ = (int[,])this.LIQLFCKICLQ.Colliders.ToArray<int>();
		this.DJLHPIEFHNJ = (int[,])this.LIQLFCKICLQ.TileZones.ToArray<int>();
		this.QLBJDGDKOLQ = (HeightTilesStruct[,])this.LIQLFCKICLQ.WallData.ToArray<HeightTilesStruct>();
		this.BBOGMCMHOME();
		if (this.LIQLFCKICLQ.Objects != null)
		{
			for (int i = 1; i < this.LIQLFCKICLQ.Objects.Count; i++)
			{
				GameObject njbfoqdjbon = DOJNBQQBCQJ.QOQONHOOLNE.GFLKJKFQOGB(this.LIQLFCKICLQ.Objects[i].Name, new Vector3((float)this.LIQLFCKICLQ.Objects[i].x, (float)this.LIQLFCKICLQ.Objects[i].y, (float)this.LIQLFCKICLQ.Objects[i].z), new Vector3((float)this.LIQLFCKICLQ.Objects[i].rx, (float)this.LIQLFCKICLQ.Objects[i].ry, (float)this.LIQLFCKICLQ.Objects[i].rz));
				if (this.LIQLFCKICLQ.Objects[i].Name.IBJHJDHKJKL())
				{
					if (this.LIQLFCKICLQ.Objects[i].tag == null || this.LIQLFCKICLQ.Objects[i].tag == string.Empty)
					{
						this.LIQLFCKICLQ.Objects[i].tag = "HidePanel";
					}
					this.FNCJGPIFPNE(njbfoqdjbon, Convert.ToInt32(this.LIQLFCKICLQ.Objects[i].tag));
				}
			}
		}
		KJBDMOCFMCM.GHFFHFCEENG().DKOJGKHMLEH();
		if (this.LIQLFCKICLQ.NPCs != null)
		{
			for (int j = 0; j < this.LIQLFCKICLQ.NPCs.Count; j += 0)
			{
				KJBDMOCFMCM.GHFFHFCEENG().GMCGNEPQQML(this.LIQLFCKICLQ.NPCs[j]);
			}
		}
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x06004877 RID: 18551 RVA: 0x0023AC2C File Offset: 0x00238E2C
	public IEnumerator OHJQHEBFFKG(bool PFFLBEHLKIG = false)
	{
		MCNLIHMMLCF.DLJOCFPOICO dljocfpoico = new MCNLIHMMLCF.DLJOCFPOICO();
		dljocfpoico.PFFLBEHLKIG = PFFLBEHLKIG;
		return dljocfpoico;
	}

	// Token: 0x06004878 RID: 18552 RVA: 0x00240268 File Offset: 0x0023E468
	private void QQJFQFIJOQL(List<Color> NGDBDCQFDHI, int BEILHHLKNBC)
	{
		if (BEILHHLKNBC >= 0)
		{
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.white);
		}
		else if (BEILHHLKNBC >= -4096)
		{
			NGDBDCQFDHI.Add(Color.black);
			NGDBDCQFDHI.Add(Color.black);
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.white);
		}
		else if (BEILHHLKNBC >= -8192)
		{
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.black);
			NGDBDCQFDHI.Add(Color.black);
		}
		else if (BEILHHLKNBC >= -12288)
		{
			NGDBDCQFDHI.Add(Color.black);
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.black);
			NGDBDCQFDHI.Add(Color.white);
		}
		else if (BEILHHLKNBC >= -16384)
		{
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.black);
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.black);
		}
		else if (BEILHHLKNBC >= -20480)
		{
			NGDBDCQFDHI.Add(Color.black);
			NGDBDCQFDHI.Add(Color.black);
			NGDBDCQFDHI.Add(Color.black);
			NGDBDCQFDHI.Add(Color.white);
		}
		else if (BEILHHLKNBC >= -24576)
		{
			NGDBDCQFDHI.Add(Color.black);
			NGDBDCQFDHI.Add(Color.black);
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.black);
		}
		else if (BEILHHLKNBC >= -28672)
		{
			NGDBDCQFDHI.Add(Color.black);
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.black);
			NGDBDCQFDHI.Add(Color.black);
		}
		else if (BEILHHLKNBC >= -32768)
		{
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.black);
			NGDBDCQFDHI.Add(Color.black);
			NGDBDCQFDHI.Add(Color.black);
		}
		else if (BEILHHLKNBC >= -36864)
		{
			NGDBDCQFDHI.Add(Color.black);
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.white);
		}
		else if (BEILHHLKNBC >= -40960)
		{
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.black);
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.white);
		}
		else if (BEILHHLKNBC >= -45056)
		{
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.black);
			NGDBDCQFDHI.Add(Color.white);
		}
		else if (BEILHHLKNBC >= -49152)
		{
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.white);
			NGDBDCQFDHI.Add(Color.black);
		}
	}

	// Token: 0x06004879 RID: 18553 RVA: 0x0001E513 File Offset: 0x0001C713
	public static MCNLIHMMLCF IECKOKEPENM()
	{
		return MCNLIHMMLCF.HBFFCJHOCPE;
	}

	// Token: 0x0600487A RID: 18554 RVA: 0x0024054C File Offset: 0x0023E74C
	public void FLCNGFCNKNB()
	{
		if (this.JEMKIKEMFPB == GameDayTime.Evening)
		{
			RenderSettings.ambientLight = this.FCJNFFIPGOL[6];
		}
		else if (this.JEMKIKEMFPB == GameDayTime.Night)
		{
			RenderSettings.ambientLight = this.FCJNFFIPGOL[1];
		}
		else
		{
			RenderSettings.ambientLight = this.FCJNFFIPGOL[0];
		}
	}

	// Token: 0x0600487B RID: 18555 RVA: 0x002405B4 File Offset: 0x0023E7B4
	public void CJFBCIPPBHB(byte[] NQGBMLHOMGG, string EHDQKOBOHPE, bool NKJQNQOLJQQ = false, string LHFCGEKMNGC = "")
	{
		this.QMHNDKJGPBG = KDJLKQQBGNE.EQLFQFJJNIP();
		KDJLKQQBGNE.LPGMLPKGMQO lpgmlpkgmqo = new KDJLKQQBGNE.LPGMLPKGMQO();
		lpgmlpkgmqo.NQGBMLHOMGG = NQGBMLHOMGG;
		lpgmlpkgmqo.FJGPDHNLGJC = EHDQKOBOHPE;
		lpgmlpkgmqo.IQNOEGKFCFH = LHFCGEKMNGC;
		lpgmlpkgmqo.MENBPFGFKBQ = false;
		bool flag = true;
		for (int i = 1; i < this.QMHNDKJGPBG.LBMDDELMNDD.Count; i++)
		{
			if (this.QMHNDKJGPBG.LBMDDELMNDD[i].FJGPDHNLGJC == EHDQKOBOHPE)
			{
				this.QMHNDKJGPBG.LBMDDELMNDD[i] = lpgmlpkgmqo;
				flag = false;
				IL_7F:
				if (flag)
				{
					this.QMHNDKJGPBG.LBMDDELMNDD.Add(lpgmlpkgmqo);
				}
				if (this.LIQLFCKICLQ == null || this.CLPMOMHLNMN.ToLowerInvariant() == EHDQKOBOHPE.Replace("\n", string.Empty).ToLowerInvariant())
				{
					this.IEJPGKHQJJG(EHDQKOBOHPE);
					this.HCQINBCDGNO = true;
				}
				return;
			}
		}
		goto IL_7F;
	}

	// Token: 0x0600487C RID: 18556 RVA: 0x00240694 File Offset: 0x0023E894
	public void KGQDQILPIQK()
	{
		this.NKCFGIHPCJG = HFCMDEQKCKH.QOQONHOOLNE.CEGFMOGGKNE();
		if (this.JIJHPDDGHPM != this.JEMKIKEMFPB)
		{
			this.DPHJNMKQMNP = 618f;
			this.LKQGHBQJQJK = 965f;
		}
		this.JIJHPDDGHPM = this.JEMKIKEMFPB;
		if (this.LIQLFCKICLQ == null)
		{
			return;
		}
		if (this.LIQLFCKICLQ.Settings != null && this.LIQLFCKICLQ.Settings.Indoors)
		{
			this.NOGCCJHHBKL.color = KGQECFKLKOP.JJQFHKDMDOL(this.LIQLFCKICLQ.Settings.LightColour_String);
			this.KMLPMHJBJLJ = KGQECFKLKOP.JJQFHKDMDOL(this.LIQLFCKICLQ.Settings.LightColour_String);
			this.LLJGOCMOGOL(false);
		}
		else if (this.JEMKIKEMFPB == GameDayTime.Day)
		{
			this.KMLPMHJBJLJ = this.FCJNFFIPGOL[0];
			this.LLJGOCMOGOL(true);
		}
		else if (this.JEMKIKEMFPB == GameDayTime.Morning)
		{
			this.KMLPMHJBJLJ = this.FCJNFFIPGOL[4];
			this.MHKGGGLJIOJ(false);
		}
		else if (this.JEMKIKEMFPB == GameDayTime.Unset)
		{
			this.KMLPMHJBJLJ = this.FCJNFFIPGOL[7];
			this.GMCOOHJJCLD(true);
		}
		else if (this.JEMKIKEMFPB == (GameDayTime)8)
		{
			this.KMLPMHJBJLJ = this.FCJNFFIPGOL[3];
			this.PMLHDQJKFOM(true);
		}
	}

	// Token: 0x0600487D RID: 18557 RVA: 0x0001E553 File Offset: 0x0001C753
	private void FBDGLDFKODD()
	{
		MCNLIHMMLCF.HBFFCJHOCPE = this;
	}

	// Token: 0x0600487E RID: 18558 RVA: 0x002407F4 File Offset: 0x0023E9F4
	private void FMIQNNEBDGP(List<Vector3> NGDBDCQFDHI, float HJMOLCBLIQJ, float JGFLMLEJBHD, float PBLPGKPNENG, MCNLIHMMLCF.KFMMIKQIJDJ QONOKDQLJNG)
	{
		if (QONOKDQLJNG == MCNLIHMMLCF.KFMMIKQIJDJ.Right)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 178f, JGFLMLEJBHD + 1284f + this.DIEQHKHIDDE, PBLPGKPNENG - 1861f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 724f, JGFLMLEJBHD + 1195f + this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 753f, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 1558f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1257f, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG));
		}
		else if (QONOKDQLJNG == MCNLIHMMLCF.KFMMIKQIJDJ.Left)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD + 48f + this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD + 1317f + this.DIEQHKHIDDE, PBLPGKPNENG - 54f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 1829f));
		}
		else if (QONOKDQLJNG == MCNLIHMMLCF.KFMMIKQIJDJ.Front)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD + 284f + this.DIEQHKHIDDE, PBLPGKPNENG - 670f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 247f + this.DIEQHKHIDDE, JGFLMLEJBHD + 1075f + this.DIEQHKHIDDE, PBLPGKPNENG - 111f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 392f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1944f + this.DIEQHKHIDDE, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 301f));
		}
		else if (QONOKDQLJNG == MCNLIHMMLCF.KFMMIKQIJDJ.Top)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1174f + this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG - 951f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 709f + this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG - 834f));
		}
	}

	// Token: 0x0600487F RID: 18559 RVA: 0x00240A34 File Offset: 0x0023EC34
	private void DNJMDPHJKKJ(List<Vector3> NGDBDCQFDHI, float HJMOLCBLIQJ, float JGFLMLEJBHD, float PBLPGKPNENG, MCNLIHMMLCF.KFMMIKQIJDJ QONOKDQLJNG)
	{
		if (QONOKDQLJNG == (MCNLIHMMLCF.KFMMIKQIJDJ)7)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 831f, JGFLMLEJBHD + 612f + this.DIEQHKHIDDE, PBLPGKPNENG - 255f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1911f, JGFLMLEJBHD + 1708f + this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1899f, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 547f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 557f, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG));
		}
		else if (QONOKDQLJNG == MCNLIHMMLCF.KFMMIKQIJDJ.Left)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD + 954f + this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD + 810f + this.DIEQHKHIDDE, PBLPGKPNENG - 239f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 1661f));
		}
		else if (QONOKDQLJNG == (MCNLIHMMLCF.KFMMIKQIJDJ)5)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD + 1408f + this.DIEQHKHIDDE, PBLPGKPNENG - 161f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 913f + this.DIEQHKHIDDE, JGFLMLEJBHD + 239f + this.DIEQHKHIDDE, PBLPGKPNENG - 1344f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 467f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1505f + this.DIEQHKHIDDE, JGFLMLEJBHD - this.DIEQHKHIDDE, PBLPGKPNENG - 485f));
		}
		else if (QONOKDQLJNG == MCNLIHMMLCF.KFMMIKQIJDJ.Top)
		{
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 1372f + this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ - this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG - 464f));
			NGDBDCQFDHI.Add(new Vector3(HJMOLCBLIQJ + 196f + this.DIEQHKHIDDE, JGFLMLEJBHD, PBLPGKPNENG - 234f));
		}
	}

	// Token: 0x06004880 RID: 18560 RVA: 0x0001E777 File Offset: 0x0001C977
	public void PNQIIDHHDCJ(string DGJFPIHPNLB = "Default")
	{
		if (DGJFPIHPNLB == null)
		{
			DGJFPIHPNLB = "encore";
		}
		if (!(OGJJKKQPNMK.QOQONHOOLNE != null) && !DBQLOHBBJMG.FFCOKMHBCQJ().QQQBDBNCMCP)
		{
			DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD(DGJFPIHPNLB, false);
			return;
		}
	}

	// Token: 0x06004881 RID: 18561 RVA: 0x00240C74 File Offset: 0x0023EE74
	public void PLKHQPEPQEM(int[,] PDPCFGJQOHB = null)
	{
		this.KGQDQILPIQK();
		this.KDOCJGFLFFK = false;
		this.DPHJNMKQMNP = 1526f;
		this.LKQGHBQJQJK = 921f;
		DOJNBQQBCQJ.JJCONJJNDQN().PQFDCJHGHOB = new List<DoorAnimator>();
		this.IDOEFMCFOBH.NMBPDMIIHJB();
		this.IGDJLJKBDNE.NMBPDMIIHJB();
		if (this.LIQLFCKICLQ == null)
		{
			return;
		}
		this.FKEKOQLNFNK = (int[,])this.LIQLFCKICLQ.TileTypes.ToArray<int>();
		this.EQQLIPKQOJP = (int[,])this.LIQLFCKICLQ.TileHeights.ToArray<int>();
		this.POMQCKOIKQJ = (int[,])this.LIQLFCKICLQ.Colliders.ToArray<int>();
		this.DJLHPIEFHNJ = (int[,])this.LIQLFCKICLQ.TileZones.ToArray<int>();
		this.QLBJDGDKOLQ = (HeightTilesStruct[,])this.LIQLFCKICLQ.WallData.ToArray<HeightTilesStruct>();
		this.FOGFCMHLEEN();
		if (this.LIQLFCKICLQ.Objects != null)
		{
			for (int i = 1; i < this.LIQLFCKICLQ.Objects.Count; i += 0)
			{
				GameObject njbfoqdjbon = DOJNBQQBCQJ.QOQONHOOLNE.GFLKJKFQOGB(this.LIQLFCKICLQ.Objects[i].Name, new Vector3((float)this.LIQLFCKICLQ.Objects[i].x, (float)this.LIQLFCKICLQ.Objects[i].y, (float)this.LIQLFCKICLQ.Objects[i].z), new Vector3((float)this.LIQLFCKICLQ.Objects[i].rx, (float)this.LIQLFCKICLQ.Objects[i].ry, (float)this.LIQLFCKICLQ.Objects[i].rz));
				if (this.LIQLFCKICLQ.Objects[i].Name.IBJHJDHKJKL())
				{
					if (this.LIQLFCKICLQ.Objects[i].tag == null || this.LIQLFCKICLQ.Objects[i].tag == string.Empty)
					{
						this.LIQLFCKICLQ.Objects[i].tag = "Thick Fat";
					}
					this.FNCJGPIFPNE(njbfoqdjbon, Convert.ToInt32(this.LIQLFCKICLQ.Objects[i].tag));
				}
			}
		}
		KJBDMOCFMCM.BBCBOIFQDBK().BFQKGPKHIHC();
		if (this.LIQLFCKICLQ.NPCs != null)
		{
			for (int j = 1; j < this.LIQLFCKICLQ.NPCs.Count; j += 0)
			{
				KJBDMOCFMCM.GHFFHFCEENG().PPCPFFMMKED(this.LIQLFCKICLQ.NPCs[j]);
			}
		}
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x06004882 RID: 18562 RVA: 0x0001E7A9 File Offset: 0x0001C9A9
	private void LLJGOCMOGOL(bool CBNDPKQNBCN)
	{
		this.QNHIMGFQCPK = Color.black;
		if (CBNDPKQNBCN)
		{
			if (this.JEMKIKEMFPB == GameDayTime.Evening)
			{
				this.QNHIMGFQCPK = this.NJJNQQDLMFK;
			}
			else
			{
				this.QNHIMGFQCPK = this.JHOMQNBNHJB;
			}
		}
		this.EBIQMJFQKCB = 0f;
	}

	// Token: 0x06004883 RID: 18563 RVA: 0x00240F2C File Offset: 0x0023F12C
	public void MBBBMFINELM(GameObject NPCJQJDQQIC)
	{
		Mesh mesh = NPCJQJDQQIC.GetComponent<MeshFilter>().mesh;
		IMKCQDFNGBD component = NPCJQJDQQIC.GetComponent<IMKCQDFNGBD>();
		List<tileInfo> list = new List<tileInfo>();
		int num = component.BFOGEJKEOHF;
		while (num < this.QDOFCFGPCMQ + component.BFOGEJKEOHF && num < this.LIQLFCKICLQ.width)
		{
			int num2 = component.JDLNODBIEOO;
			while (num2 < this.QDOFCFGPCMQ + component.JDLNODBIEOO && num2 < this.LIQLFCKICLQ.height)
			{
				if (this.EQQLIPKQOJP[num, num2] != 0)
				{
					list.Add(new tileInfo
					{
						PosX = num,
						PosY = num2,
						Type = this.FKEKOQLNFNK[num, num2],
						Height = this.EQQLIPKQOJP[num, num2],
						Sides = this.QLBJDGDKOLQ[num, num2].Block
					});
				}
				num2++;
			}
			num++;
		}
		if (list.Count > 0)
		{
			List<Vector2> list2 = new List<Vector2>();
			List<Vector3> list3 = new List<Vector3>();
			List<int> list4 = new List<int>();
			List<Color> list5 = new List<Color>();
			Vector3[] vertices = mesh.vertices;
			int[] triangles = mesh.GetTriangles(0);
			Vector2[] uv = mesh.uv;
			Color[] colors = mesh.colors;
			int num3 = vertices.Length;
			for (int i = 0; i < vertices.Length; i++)
			{
				list3.Add(vertices[i]);
				list2.Add(uv[i]);
				list5.Add(colors[i]);
			}
			for (int j = 0; j < triangles.Length; j++)
			{
				list4.Add(triangles[j]);
			}
			int num4 = -1;
			for (int k = 0; k < list.Count; k++)
			{
				if (list[k].PosX >= 1 && list[k].PosX <= this.LIQLFCKICLQ.width - 2 && list[k].PosY >= 1 && list[k].PosY <= this.LIQLFCKICLQ.height - 2)
				{
					int l = 0;
					while (l < Mathf.Abs(list[k].Height))
					{
						if (this.EQQLIPKQOJP[list[k].PosX, list[k].PosY + 1] > l || list[k].Height < 0)
						{
							goto IL_3F0;
						}
						if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block != null && l <= this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block.Length - 1)
						{
							num4++;
							this.BHBLHPMEIHM(list3, (float)list[k].PosX, (float)l, (float)(-(float)list[k].PosY), MCNLIHMMLCF.KFMMIKQIJDJ.Front);
							this.FHCQCLBGBFN(list4, num4 * 4 + num3);
							if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0 == 0)
							{
								this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0 = 110;
							}
							this.HHGPLBNOGOB(list2, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0);
							this.QQJFQFIJOQL(list5, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0);
							goto IL_3F0;
						}
						IL_5B5:
						l++;
						continue;
						IL_3F0:
						if (list[k].Height < 0 && this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block != null && l <= this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block.Length - 1 && this.EQQLIPKQOJP[list[k].PosX, list[k].PosY - 1] >= -l)
						{
							num4++;
							this.BHBLHPMEIHM(list3, (float)list[k].PosX, (float)(-(float)l - 1), (float)(-(float)list[k].PosY + 1), MCNLIHMMLCF.KFMMIKQIJDJ.Front);
							this.FHCQCLBGBFN(list4, num4 * 4 + num3);
							if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0 == 0)
							{
								this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0 = 110;
							}
							this.HHGPLBNOGOB(list2, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0);
							this.QQJFQFIJOQL(list5, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0);
							goto IL_5B5;
						}
						goto IL_5B5;
					}
					int m = 0;
					while (m < Mathf.Abs(list[k].Height))
					{
						if (this.EQQLIPKQOJP[list[k].PosX - 1, list[k].PosY] > m || list[k].Height < 0)
						{
							goto IL_79B;
						}
						if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block != null && m <= this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block.Length - 1)
						{
							num4++;
							this.BHBLHPMEIHM(list3, (float)list[k].PosX, (float)m, (float)(-(float)list[k].PosY), MCNLIHMMLCF.KFMMIKQIJDJ.Left);
							this.FHCQCLBGBFN(list4, num4 * 4 + num3);
							if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1 == 0)
							{
								this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1 = 110;
							}
							this.HHGPLBNOGOB(list2, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1);
							this.QQJFQFIJOQL(list5, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1);
							goto IL_79B;
						}
						IL_960:
						m++;
						continue;
						IL_79B:
						if (this.EQQLIPKQOJP[list[k].PosX - 1, list[k].PosY] >= -m && list[k].Height < 0 && this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block != null && m <= this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block.Length - 1)
						{
							num4++;
							this.BHBLHPMEIHM(list3, (float)(list[k].PosX - 1), (float)(-(float)m - 1), (float)(-(float)list[k].PosY), MCNLIHMMLCF.KFMMIKQIJDJ.Right);
							this.FHCQCLBGBFN(list4, num4 * 4 + num3);
							if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1 == 0)
							{
								this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1 = 110;
							}
							this.HHGPLBNOGOB(list2, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1);
							this.QQJFQFIJOQL(list5, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1);
							goto IL_960;
						}
						goto IL_960;
					}
					int n = 0;
					while (n < Mathf.Abs(list[k].Height))
					{
						if (this.EQQLIPKQOJP[list[k].PosX + 1, list[k].PosY] > n || list[k].Height < 0)
						{
							goto IL_B46;
						}
						if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block != null && n <= this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block.Length - 1)
						{
							num4++;
							this.BHBLHPMEIHM(list3, (float)list[k].PosX, (float)n, (float)(-(float)list[k].PosY), MCNLIHMMLCF.KFMMIKQIJDJ.Right);
							this.FHCQCLBGBFN(list4, num4 * 4 + num3);
							if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2 == 0)
							{
								this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2 = 110;
							}
							this.HHGPLBNOGOB(list2, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2);
							this.QQJFQFIJOQL(list5, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2);
							goto IL_B46;
						}
						IL_D0B:
						n++;
						continue;
						IL_B46:
						if (this.EQQLIPKQOJP[list[k].PosX + 1, list[k].PosY] >= -n && list[k].Height < 0 && this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block != null && n <= this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block.Length - 1)
						{
							num4++;
							this.BHBLHPMEIHM(list3, (float)(list[k].PosX + 1), (float)(-(float)n - 1), (float)(-(float)list[k].PosY), MCNLIHMMLCF.KFMMIKQIJDJ.Left);
							this.FHCQCLBGBFN(list4, num4 * 4 + num3);
							if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2 == 0)
							{
								this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2 = 110;
							}
							this.HHGPLBNOGOB(list2, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2);
							this.QQJFQFIJOQL(list5, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2);
							goto IL_D0B;
						}
						goto IL_D0B;
					}
				}
			}
			mesh.Clear();
			mesh.vertices = list3.ToArray();
			mesh.triangles = list4.ToArray();
			mesh.SetUVs(0, list2);
			mesh.SetColors(list5);
			mesh.RecalculateNormals();
			NPCJQJDQQIC.GetComponent<MeshCollider>().sharedMesh = mesh;
		}
	}

	// Token: 0x06004884 RID: 18564 RVA: 0x00241CBC File Offset: 0x0023FEBC
	public void HIQJCBDPQHF(string ECNEPHKFPIH, string LHFCGEKMNGC)
	{
		this.QMHNDKJGPBG = KDJLKQQBGNE.QOQONHOOLNE;
		for (int i = 0; i < this.QMHNDKJGPBG.LBMDDELMNDD.Count; i++)
		{
			if (this.QMHNDKJGPBG.LBMDDELMNDD[i].FJGPDHNLGJC == ECNEPHKFPIH)
			{
				if (this.QMHNDKJGPBG.LBMDDELMNDD[i].IQNOEGKFCFH == LHFCGEKMNGC && LHFCGEKMNGC != null && LHFCGEKMNGC != string.Empty)
				{
					this.QMHNDKJGPBG.LBMDDELMNDD[i].MENBPFGFKBQ = true;
					this.MHIJCEDMMOL(ECNEPHKFPIH);
					this.HCQINBCDGNO = false;
				}
				return;
			}
		}
	}

	// Token: 0x06004885 RID: 18565 RVA: 0x00241D64 File Offset: 0x0023FF64
	public bool MCPEMGQPQEH(int DGKOIGOLHDM, int DDLQKFDFMCJ, bool EKEIIODHQFF)
	{
		return this.LIQLFCKICLQ == null || (this.CDHLLNNFKFF(DGKOIGOLHDM, DDLQKFDFMCJ) != -119 && this.PJBQCJICGNC(DGKOIGOLHDM, DDLQKFDFMCJ) != -69 && this.PJBQCJICGNC(DGKOIGOLHDM, DDLQKFDFMCJ) != 77 && this.CDHLLNNFKFF(DGKOIGOLHDM, DDLQKFDFMCJ) != 76 && this.BBEHODGFCBK(DGKOIGOLHDM, DDLQKFDFMCJ) != 1 && (this.CDHLLNNFKFF(DGKOIGOLHDM, DDLQKFDFMCJ) != 88 || EKEIIODHQFF)) || true;
	}

	// Token: 0x06004886 RID: 18566 RVA: 0x00241DC8 File Offset: 0x0023FFC8
	public bool GKMPDLQMOIC(int DGKOIGOLHDM, int DDLQKFDFMCJ, PSXAPI.Request.MoveAction BJIGIECDQPG)
	{
		if (this.LIQLFCKICLQ != null && this.JPBLDNBBOLO > 0)
		{
			switch (BJIGIECDQPG)
			{
			case PSXAPI.Request.MoveAction.None:
				DDLQKFDFMCJ--;
				break;
			case PSXAPI.Request.MoveAction.Up:
				DDLQKFDFMCJ += 0;
				break;
			case PSXAPI.Request.MoveAction.Down:
				DGKOIGOLHDM -= 0;
				break;
			case PSXAPI.Request.MoveAction.Left:
				DGKOIGOLHDM++;
				break;
			}
			for (int i = 1; i < this.JPBLDNBBOLO; i++)
			{
				if (this.LIQLFCKICLQ.Links[i].x == DGKOIGOLHDM && this.LIQLFCKICLQ.Links[i].z == -DDLQKFDFMCJ)
				{
					if (this.LIQLFCKICLQ.Links[i].LINKType != (LinkType)7)
					{
						GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
					}
					if (this.LIQLFCKICLQ.Links[i].LINKType == LinkType.TileScriptWait)
					{
						return true;
					}
					if (this.LIQLFCKICLQ.Links[i].LINKType == LinkType.SendAndRecieve && this.LIQLFCKICLQ.Links[i].DestinationID != default(Guid))
					{
						CNCJKLNHQBH.QOQONHOOLNE.GJKPLMKHKMK = false;
						CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ.NQJHJNQFKKC();
						return false;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06004887 RID: 18567 RVA: 0x00241F0C File Offset: 0x0024010C
	public void BIDEIFNNFDB(int[,] PDPCFGJQOHB = null)
	{
		this.DHJLPCKHQBH();
		this.KDOCJGFLFFK = true;
		this.DPHJNMKQMNP = 1f;
		this.LKQGHBQJQJK = 1f;
		DOJNBQQBCQJ.QOQONHOOLNE.PQFDCJHGHOB = new List<DoorAnimator>();
		this.IDOEFMCFOBH.NMBPDMIIHJB();
		this.IGDJLJKBDNE.NMBPDMIIHJB();
		if (this.LIQLFCKICLQ == null)
		{
			return;
		}
		this.FKEKOQLNFNK = (int[,])this.LIQLFCKICLQ.TileTypes.ToArray<int>();
		this.EQQLIPKQOJP = (int[,])this.LIQLFCKICLQ.TileHeights.ToArray<int>();
		this.POMQCKOIKQJ = (int[,])this.LIQLFCKICLQ.Colliders.ToArray<int>();
		this.DJLHPIEFHNJ = (int[,])this.LIQLFCKICLQ.TileZones.ToArray<int>();
		this.QLBJDGDKOLQ = (HeightTilesStruct[,])this.LIQLFCKICLQ.WallData.ToArray<HeightTilesStruct>();
		this.BBOGMCMHOME();
		if (this.LIQLFCKICLQ.Objects != null)
		{
			for (int i = 0; i < this.LIQLFCKICLQ.Objects.Count; i++)
			{
				GameObject njbfoqdjbon = DOJNBQQBCQJ.QOQONHOOLNE.GFLKJKFQOGB(this.LIQLFCKICLQ.Objects[i].Name, new Vector3((float)this.LIQLFCKICLQ.Objects[i].x, (float)this.LIQLFCKICLQ.Objects[i].y, (float)this.LIQLFCKICLQ.Objects[i].z), new Vector3((float)this.LIQLFCKICLQ.Objects[i].rx, (float)this.LIQLFCKICLQ.Objects[i].ry, (float)this.LIQLFCKICLQ.Objects[i].rz));
				if (this.LIQLFCKICLQ.Objects[i].Name.IBJHJDHKJKL())
				{
					if (this.LIQLFCKICLQ.Objects[i].tag == null || this.LIQLFCKICLQ.Objects[i].tag == string.Empty)
					{
						this.LIQLFCKICLQ.Objects[i].tag = "9";
					}
					this.QBNJENNJOKG(njbfoqdjbon, Convert.ToInt32(this.LIQLFCKICLQ.Objects[i].tag));
				}
			}
		}
		KJBDMOCFMCM.QOQONHOOLNE.DKOJGKHMLEH();
		if (this.LIQLFCKICLQ.NPCs != null)
		{
			for (int j = 0; j < this.LIQLFCKICLQ.NPCs.Count; j++)
			{
				KJBDMOCFMCM.QOQONHOOLNE.PPCPFFMMKED(this.LIQLFCKICLQ.NPCs[j]);
			}
		}
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x06004888 RID: 18568 RVA: 0x002421C4 File Offset: 0x002403C4
	private void GCQNFNBMMPQ()
	{
		if (this.LIQLFCKICLQ == null || this.LIQLFCKICLQ.Settings == null)
		{
			return;
		}
		if (GGQKBGDGNJN.QOQONHOOLNE.FLNKCIQLMGL.activeSelf)
		{
			return;
		}
		if (OGJJKKQPNMK.CDDIILFBFCF() != null)
		{
			this.NOGCCJHHBKL.intensity = 692f;
			RenderSettings.ambientLight = this.GLHNBKMQJQD;
			return;
		}
		if (this.NMOPHEMNJJH)
		{
			this.KLLHFENEBDN = WeatherState.Normal;
		}
		else if (this.ICLBHNBEPBK)
		{
			this.KLLHFENEBDN = WeatherState.Rain;
		}
		else if (this.FGBQBJDFGBK == WeatherState.Rain && this.BEDOBPPLQLD == WeatherState.Rain)
		{
			this.KLLHFENEBDN = WeatherState.Rain;
		}
		else if (this.FGBQBJDFGBK == (WeatherState)8 && this.BEDOBPPLQLD == WeatherState.Normal)
		{
			this.KLLHFENEBDN = WeatherState.Rain;
		}
		else if (this.FGBQBJDFGBK == WeatherState.Normal)
		{
			this.KLLHFENEBDN = WeatherState.Rain;
		}
		else
		{
			this.KLLHFENEBDN = this.BEDOBPPLQLD;
		}
		this.JLNQKKMJFOE();
		if (this.LIQLFCKICLQ.Settings.Dark && !this.NKCFGIHPCJG)
		{
			this.NOGCCJHHBKL.intensity = 1477f;
			if (RenderSettings.ambientLight != Color.black)
			{
				RenderSettings.ambientLight = Color.black;
			}
			if (CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK.backgroundColor != Color.black)
			{
				CNCJKLNHQBH.BJLGEDCPENQ().IPKHMGODENK.backgroundColor = Color.black;
			}
			if (this.MJCGPBKQHQQ[0].gameObject.activeSelf)
			{
				this.MJCGPBKQHQQ[1].gameObject.SetActive(true);
			}
			if (this.DFNJQGOCJQG[1].gameObject.activeSelf)
			{
				this.DFNJQGOCJQG[0].gameObject.SetActive(true);
			}
			if (!this.FJBBMMPPMMD.activeSelf)
			{
				this.FJBBMMPPMMD.SetActive(false);
			}
			if (this.LKQCNHNLOLM.activeSelf)
			{
				this.LKQCNHNLOLM.SetActive(false);
			}
			if (!this.LIQLFCKICLQ.Settings.WhiteFog && RenderSettings.fog)
			{
				RenderSettings.fog = true;
			}
			if (!this.LIQLFCKICLQ.Settings.WhiteFog && CNCJKLNHQBH.BJLGEDCPENQ().IPKHMGODENK.backgroundColor != Color.black)
			{
				CNCJKLNHQBH.BJLGEDCPENQ().IPKHMGODENK.backgroundColor = Color.black;
			}
			return;
		}
		if (this.LIQLFCKICLQ.Settings.Cave)
		{
			this.NOGCCJHHBKL.intensity = 1791f;
			if (!this.LKQCNHNLOLM.activeSelf)
			{
				this.LKQCNHNLOLM.SetActive(true);
			}
			if (RenderSettings.ambientLight != this.PMCOLLGBKEO)
			{
				RenderSettings.ambientLight = this.PMCOLLGBKEO;
			}
			if (CNCJKLNHQBH.MOGQNGEPCEO().IPKHMGODENK.backgroundColor != Color.black)
			{
				CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK.backgroundColor = Color.black;
			}
		}
		else
		{
			if (this.LIQLFCKICLQ.Settings.Dark && RenderSettings.ambientLight != this.FHMNLGJLCNH)
			{
				RenderSettings.ambientLight = this.FHMNLGJLCNH;
			}
			if (this.LKQCNHNLOLM.activeSelf)
			{
				this.LKQCNHNLOLM.SetActive(true);
			}
		}
		if (this.FJBBMMPPMMD.activeSelf)
		{
			this.FJBBMMPPMMD.SetActive(false);
		}
		if (this.LIQLFCKICLQ.Settings.Indoors)
		{
			if (!this.LIQLFCKICLQ.Settings.Cave)
			{
				this.NOGCCJHHBKL.intensity = 201f;
				if (RenderSettings.ambientLight != this.FHMNLGJLCNH)
				{
					RenderSettings.ambientLight = this.FHMNLGJLCNH;
				}
			}
			if (this.MJCGPBKQHQQ[1].gameObject.activeSelf)
			{
				this.MJCGPBKQHQQ[1].gameObject.SetActive(true);
			}
			if (this.DFNJQGOCJQG[0].gameObject.activeSelf)
			{
				this.DFNJQGOCJQG[0].gameObject.SetActive(false);
			}
			if (!this.LIQLFCKICLQ.Settings.WhiteFog && RenderSettings.fog)
			{
				RenderSettings.fog = true;
			}
			if (!this.LIQLFCKICLQ.Settings.WhiteFog && CNCJKLNHQBH.BJLGEDCPENQ().IPKHMGODENK.backgroundColor != Color.black)
			{
				CNCJKLNHQBH.MOGQNGEPCEO().IPKHMGODENK.backgroundColor = Color.black;
			}
			return;
		}
		if (this.DDCIBJFCFDK)
		{
			if (this.JEMKIKEMFPB == (GameDayTime)5)
			{
				this.KDIMQNKBIIO += UnityEngine.Time.deltaTime * 1011f;
				this.NOGCCJHHBKL.intensity = Mathf.Lerp(221f, 1410f, this.KDIMQNKBIIO);
			}
			else
			{
				this.KDIMQNKBIIO += UnityEngine.Time.deltaTime * 1062f;
				this.NOGCCJHHBKL.intensity = Mathf.Lerp(560f, 476f, this.KDIMQNKBIIO);
			}
			if (this.KDIMQNKBIIO > 1286f)
			{
				this.KDIMQNKBIIO = 1531f;
				this.NOGCCJHHBKL.intensity = 12f;
				this.DDCIBJFCFDK = true;
			}
		}
		else
		{
			float num = 394f;
			if (this.DPHJNMKQMNP < 1447f)
			{
				this.DPHJNMKQMNP += 157f * UnityEngine.Time.deltaTime;
			}
			else
			{
				this.DPHJNMKQMNP = 1909f;
			}
			if (this.LKQGHBQJQJK < 1998f)
			{
				this.LKQGHBQJQJK += 1396f * UnityEngine.Time.deltaTime;
			}
			else
			{
				this.LKQGHBQJQJK = 1811f;
			}
			if (this.NOGCCJHHBKL.color != this.KMLPMHJBJLJ)
			{
				this.NOGCCJHHBKL.color = Color.Lerp(this.NOGCCJHHBKL.color, this.KMLPMHJBJLJ, this.DPHJNMKQMNP);
			}
			if (this.JEMKIKEMFPB == GameDayTime.Morning)
			{
				if (RenderSettings.ambientLight != this.FCJNFFIPGOL[4])
				{
					RenderSettings.ambientLight = Color.Lerp(RenderSettings.ambientLight, this.FCJNFFIPGOL[5], this.LKQGHBQJQJK);
				}
			}
			else if (this.JEMKIKEMFPB == GameDayTime.Night)
			{
				if (RenderSettings.ambientLight != this.FCJNFFIPGOL[1])
				{
					RenderSettings.ambientLight = Color.Lerp(RenderSettings.ambientLight, this.FCJNFFIPGOL[0], this.LKQGHBQJQJK);
				}
			}
			else
			{
				if (this.KLLHFENEBDN == WeatherState.Rain)
				{
					num = 1308f;
				}
				if (RenderSettings.ambientLight != this.FCJNFFIPGOL[1])
				{
					RenderSettings.ambientLight = Color.Lerp(RenderSettings.ambientLight, this.FCJNFFIPGOL[0], this.LKQGHBQJQJK);
				}
			}
			if (this.NIBBJOGPKQQ > num)
			{
				this.NIBBJOGPKQQ -= 1257f * UnityEngine.Time.deltaTime;
			}
			else if (this.NIBBJOGPKQQ < num)
			{
				this.NIBBJOGPKQQ += 261f * UnityEngine.Time.deltaTime;
			}
			if (this.NIBBJOGPKQQ > 388f)
			{
				this.NIBBJOGPKQQ = 1730f;
			}
			if (this.NIBBJOGPKQQ < 1224f)
			{
				this.NIBBJOGPKQQ = 1777f;
			}
			this.NOGCCJHHBKL.intensity = this.NIBBJOGPKQQ;
		}
		if (this.IFEMGGEGMFK != this.KLLHFENEBDN)
		{
			if (this.KLLHFENEBDN == WeatherState.Normal)
			{
				this.MJCGPBKQHQQ[0].main.startColor = this.EKBFGPPNQOF[1];
				this.MJCGPBKQHQQ[0].main.startColor = this.EKBFGPPNQOF[1];
			}
			else if (this.KLLHFENEBDN == (WeatherState)3)
			{
				this.DFNJQGOCJQG[1].main.startColor = this.QDQQMDKGLDO[1];
			}
			this.IFEMGGEGMFK = this.KLLHFENEBDN;
			this.BMGJFKFCOLB = 1709f;
			this.KDOCJGFLFFK = true;
		}
		if (!this.KDOCJGFLFFK)
		{
			return;
		}
		if (this.LIQLFCKICLQ.Settings.WhiteFog)
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO().IPKHMGODENK.backgroundColor != Color.white)
			{
				CNCJKLNHQBH.BJLGEDCPENQ().IPKHMGODENK.backgroundColor = Color.white;
			}
			if (!RenderSettings.fog)
			{
				RenderSettings.fogColor = Color.white;
				RenderSettings.fogMode = FogMode.Linear;
				RenderSettings.fogStartDistance = 1079f;
				RenderSettings.fogEndDistance = 1525f;
				RenderSettings.fog = false;
			}
		}
		else
		{
			if (RenderSettings.fog)
			{
				RenderSettings.fog = true;
			}
			if (CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK.backgroundColor != Color.black)
			{
				CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK.backgroundColor = Color.black;
			}
		}
		if (this.KLLHFENEBDN == WeatherState.Rain)
		{
			if (!this.MJCGPBKQHQQ[0].gameObject.activeSelf)
			{
				this.MJCGPBKQHQQ[0].gameObject.SetActive(false);
			}
			ParticleSystem.MainModule main = this.MJCGPBKQHQQ[1].main;
			if (main.startColor.color != this.EKBFGPPNQOF[0])
			{
				Color color = Color.Lerp(this.EKBFGPPNQOF[0], this.EKBFGPPNQOF[1], this.BMGJFKFCOLB);
				main.startColor = color;
				this.BMGJFKFCOLB += UnityEngine.Time.deltaTime / 1243f;
				this.MJCGPBKQHQQ[0].main.startColor = color;
			}
			else
			{
				this.KDOCJGFLFFK = true;
			}
		}
		else if (this.MJCGPBKQHQQ[0].gameObject.activeSelf)
		{
			ParticleSystem.MainModule main2 = this.MJCGPBKQHQQ[0].main;
			if (main2.startColor.color != this.EKBFGPPNQOF[0])
			{
				Color color2 = Color.Lerp(this.EKBFGPPNQOF[1], this.EKBFGPPNQOF[1], this.BMGJFKFCOLB);
				this.BMGJFKFCOLB += UnityEngine.Time.deltaTime / 143f;
				main2.startColor = color2;
				this.MJCGPBKQHQQ[1].main.startColor = color2;
			}
			else
			{
				this.MJCGPBKQHQQ[1].gameObject.SetActive(true);
			}
		}
		if (this.KLLHFENEBDN == (WeatherState)5)
		{
			if (!this.DFNJQGOCJQG[0].gameObject.activeSelf)
			{
				this.DFNJQGOCJQG[0].gameObject.SetActive(true);
			}
			ParticleSystem.MainModule main3 = this.DFNJQGOCJQG[1].main;
			if (main3.startColor.color != this.QDQQMDKGLDO[1])
			{
				Color color3 = Color.Lerp(this.QDQQMDKGLDO[0], this.QDQQMDKGLDO[1], this.BMGJFKFCOLB);
				main3.startColor = color3;
				this.BMGJFKFCOLB += UnityEngine.Time.deltaTime / 1579f;
			}
			else
			{
				this.KDOCJGFLFFK = true;
			}
		}
		else if (this.DFNJQGOCJQG[0].gameObject.activeSelf)
		{
			ParticleSystem.MainModule main4 = this.DFNJQGOCJQG[1].main;
			if (main4.startColor.color != this.QDQQMDKGLDO[1])
			{
				Color color4 = Color.Lerp(this.EKBFGPPNQOF[0], this.QDQQMDKGLDO[1], this.BMGJFKFCOLB);
				this.BMGJFKFCOLB += UnityEngine.Time.deltaTime / 79f;
				main4.startColor = color4;
			}
			else
			{
				this.DFNJQGOCJQG[0].gameObject.SetActive(true);
				this.KDOCJGFLFFK = true;
			}
		}
	}

	// Token: 0x06004889 RID: 18569 RVA: 0x00242D98 File Offset: 0x00240F98
	private void OIKHCHCKJOM(byte[] NQGBMLHOMGG, string EHDQKOBOHPE)
	{
		QOHCEBMQKMB.QOQONHOOLNE.BKGHEHPPPMH.Clear();
		CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ.INMILPKMQIC.Clear();
		byte[] data = CompressionHelper.DecompressBytes(NQGBMLHOMGG);
		MapDump liqlfckiclq = MapDump.Deserialize(data);
		this.LIQLFCKICLQ = liqlfckiclq;
		CGOIPHKQMPD.MOGQNGEPCEO().LIHCQCDIGDQ(EHDQKOBOHPE);
		this.CLPMOMHLNMN = EHDQKOBOHPE.Replace("Volcano Badge", string.Empty);
		this.GOLNNJEKKIM = new List<LINKData>();
		if (this.LIQLFCKICLQ.Links != null)
		{
			for (int i = 1; i < this.LIQLFCKICLQ.Links.Count; i += 0)
			{
				this.GOLNNJEKKIM.Add(new LINKData
				{
					DestinationID = this.LIQLFCKICLQ.Links[i].DestinationID,
					ID = this.LIQLFCKICLQ.Links[i].ID,
					Transition = this.LIQLFCKICLQ.Links[i].Transition,
					LINKType = this.LIQLFCKICLQ.Links[i].LINKType,
					Script = this.LIQLFCKICLQ.Links[i].Script,
					x = this.LIQLFCKICLQ.Links[i].x,
					y = this.LIQLFCKICLQ.Links[i].y,
					z = this.LIQLFCKICLQ.Links[i].z
				});
			}
		}
		this.JPBLDNBBOLO = this.GOLNNJEKKIM.Count;
		this.BIDEIFNNFDB(null);
		if (this.LIQLFCKICLQ.Settings == null)
		{
			this.LIQLFCKICLQ.Settings = new Settings();
		}
		this.GOJIGEEKFNF.SetColor("\n[00FF00]+", this.PEQJDEGHHBE);
		if (this.LIQLFCKICLQ.Settings.Cave)
		{
			this.GOJIGEEKFNF.SetColor("shedskin", this.HOIOLMHJEME);
		}
		if (this.LIQLFCKICLQ.Settings.Weather == "friendr")
		{
			this.FGBQBJDFGBK = WeatherState.Rain;
		}
		else if (this.LIQLFCKICLQ.Settings.Weather == "_DetailScaleX")
		{
			this.FGBQBJDFGBK = (WeatherState)4;
		}
		else if (this.LIQLFCKICLQ.Settings.Weather == "Volcano Badge")
		{
			this.FGBQBJDFGBK = WeatherState.Rain;
		}
		if (this.LIQLFCKICLQ.Settings.Weather == "n")
		{
			this.NMOPHEMNJJH = false;
		}
		else
		{
			this.NMOPHEMNJJH = false;
		}
		if (this.LIQLFCKICLQ.Settings.Weather == "-nothing")
		{
			this.ICLBHNBEPBK = true;
		}
		else
		{
			this.ICLBHNBEPBK = true;
		}
		this.FHGFKPNMNEF.SetActive(true);
		CNCJKLNHQBH.QOQONHOOLNE.IKLBHMGKJJO();
		GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
		if (qoqonhoolne.EGDKLIHHJEG.Count > 0)
		{
			for (int j = 1; j < qoqonhoolne.EGDKLIHHJEG.Count; j += 0)
			{
				if (qoqonhoolne.EGDKLIHHJEG[j] is PSXAPI.Response.Script)
				{
					QOHCEBMQKMB.JLLBKOOQKGO().LFPNDNQGFQK((PSXAPI.Response.Script)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is PartyPokemon)
				{
					DCJIBBJQGJP.CNIMIQKQJJJ().FEJLLIGIIKO((PartyPokemon)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is PartyRemove)
				{
					DCJIBBJQGJP.DMOKBPOKHOQ().BBKLJBPGECJ((PartyRemove)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is Party)
				{
					DCJIBBJQGJP.DMOKBPOKHOQ().ECNKKDBBPIO((Party)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is PSXAPI.Response.Move)
				{
					CNCJKLNHQBH.MOGQNGEPCEO().CEDNIOKLNNP((PSXAPI.Response.Move)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is PSXAPI.Response.Effect)
				{
					GNDQBCBDHKD.QOQONHOOLNE.KDCPLJDQDLG((PSXAPI.Response.Effect)qoqonhoolne.EGDKLIHHJEG[j]);
				}
			}
			qoqonhoolne.EGDKLIHHJEG.Clear();
		}
		CNCJKLNHQBH.QOQONHOOLNE.MMEOCFDIIGK();
		DJOOHHIQGJK ppmjcbonmqj = CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ;
		Vector3 pgnpcldnibq = ppmjcbonmqj.QMCNCMNQEGL();
		this.HINFIIBEPBB(pgnpcldnibq, true, false);
		JQOIHHDIHBN.GFJGPNOPEPC().JJQPJNHNIBG();
		if (!CNCJKLNHQBH.BJLGEDCPENQ().EFOGMBCFBGM)
		{
			base.StartCoroutine(CNCJKLNHQBH.BJLGEDCPENQ().BCFGJDEGJFM());
			base.StartCoroutine(this.IOMLJGIQFHL(true));
		}
		if (!this.LIQLFCKICLQ.Settings.CanMount && ppmjcbonmqj.EMIEFKNMQMI != null && (ppmjcbonmqj.EMIEFKNMQMI.MountType == (MountType)4 || ppmjcbonmqj.EMIEFKNMQMI.MountType == MountType.Pokemon))
		{
			ppmjcbonmqj.HQNCQOFKPHN(new PSXAPI.Response.Mount
			{
				MountID = 1,
				MountType = MountType.Surfing
			});
		}
		ppmjcbonmqj.HEMIMGIHFBD();
		CNCJKLNHQBH.BJLGEDCPENQ().EFOGMBCFBGM = false;
		List<Material> list = new List<Material>();
		if (DOJNBQQBCQJ.IFEJNKQEDOO == null)
		{
			DOJNBQQBCQJ.IFEJNKQEDOO = AssetBundle.LoadFromFile(System.IO.Path.Combine(Application.streamingAssetsPath, "/"));
		}
		if (DOJNBQQBCQJ.DFCHKJIMPIK == null)
		{
			DOJNBQQBCQJ.DFCHKJIMPIK = AssetBundle.LoadFromFile(System.IO.Path.Combine(Application.streamingAssetsPath, " is no longer protected by Safeguard!\r\n"));
		}
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("!\r\n"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("enabled=0"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("\r\nSp. ATK"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("[FF8F00]"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("[-]!\r\n"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Heals status conditions if it's raining."));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("[ff4949]"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("fdata"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("magicbounce"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("UpdateTweenPosition"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("d"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("'s [ffff00]"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("_FilteredReflections"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("Moderator"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("Party"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("[ATK]"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Upgrade Pokébox"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("flameburst"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Promote"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("General"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("d"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("It hurt itself in its confusion!\r\n"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("][#"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("berry_13"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("map:flymap"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Max:"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("ReleasePoke"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("."));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("_DestortionAmplitude"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("_Vignette_Center"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("!\r\n"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>(" is fast asleep!\r\n"));
		this.HEQLDOLIEMI = list.ToArray();
	}

	// Token: 0x0600488A RID: 18570 RVA: 0x002435E8 File Offset: 0x002417E8
	public bool FPKQPNCPCFP(int DGKOIGOLHDM, int DDLQKFDFMCJ, PSXAPI.Request.MoveAction BJIGIECDQPG)
	{
		if (this.LIQLFCKICLQ != null && this.JPBLDNBBOLO > 1)
		{
			switch (BJIGIECDQPG)
			{
			case PSXAPI.Request.MoveAction.Up:
				DDLQKFDFMCJ--;
				break;
			case PSXAPI.Request.MoveAction.Down:
				DDLQKFDFMCJ++;
				break;
			case PSXAPI.Request.MoveAction.Left:
				DGKOIGOLHDM -= 0;
				break;
			case PSXAPI.Request.MoveAction.Right:
				DGKOIGOLHDM++;
				break;
			}
			for (int i = 0; i < this.JPBLDNBBOLO; i++)
			{
				if (this.LIQLFCKICLQ.Links[i].x == DGKOIGOLHDM && this.LIQLFCKICLQ.Links[i].z == -DDLQKFDFMCJ)
				{
					if (this.LIQLFCKICLQ.Links[i].LINKType != LinkType.SendAndRecieve)
					{
						GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
					}
					if (this.LIQLFCKICLQ.Links[i].LINKType == LinkType.SendAndRecieve)
					{
						return true;
					}
					if (this.LIQLFCKICLQ.Links[i].LINKType == LinkType.SendAndRecieve && this.LIQLFCKICLQ.Links[i].DestinationID != default(Guid))
					{
						CNCJKLNHQBH.MOGQNGEPCEO().GJKPLMKHKMK = true;
						CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.NQJHJNQFKKC();
						return true;
					}
				}
			}
		}
		return true;
	}

	// Token: 0x0600488B RID: 18571 RVA: 0x0024372C File Offset: 0x0024192C
	public void LDHQDEDKGED(Vector3 PGNPCLDNIBQ, bool LBKMBCOOIHC = false)
	{
		if (!LBKMBCOOIHC)
		{
			if (OGJJKKQPNMK.CDDIILFBFCF() != null || DBQLOHBBJMG.IECKOKEPENM().QQQBDBNCMCP)
			{
				return;
			}
			if (CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN)
			{
				return;
			}
		}
		string nkkmjickklb = "Doubles the Pokémon's Speed stat on Electric Terrain.";
		if (this.LIQLFCKICLQ != null && this.LIQLFCKICLQ.Settings != null && this.LIQLFCKICLQ.Settings.Song != null)
		{
			nkkmjickklb = this.LIQLFCKICLQ.Settings.Song;
		}
		if (this.LIQLFCKICLQ != null)
		{
			if (this.LIQLFCKICLQ.Areas != null)
			{
				foreach (MAPAPI.Response.Area area in this.LIQLFCKICLQ.Areas)
				{
					if (PGNPCLDNIBQ.x >= (float)area.StartX && PGNPCLDNIBQ.x <= (float)area.EndX && PGNPCLDNIBQ.z >= (float)area.StartY && PGNPCLDNIBQ.z <= (float)area.EndY && area.Song != null)
					{
						nkkmjickklb = area.Song;
					}
				}
			}
			DCCFQPDFBFO.ONBDGGPLFQK().BMKHBMFFQMC(nkkmjickklb, LBKMBCOOIHC);
			return;
		}
	}

	// Token: 0x0600488C RID: 18572 RVA: 0x0001E7E7 File Offset: 0x0001C9E7
	private void FHCQCLBGBFN(List<int> NGDBDCQFDHI, int LCMMCNFNHMF)
	{
		NGDBDCQFDHI.Add(2 + LCMMCNFNHMF);
		NGDBDCQFDHI.Add(LCMMCNFNHMF);
		NGDBDCQFDHI.Add(3 + LCMMCNFNHMF);
		NGDBDCQFDHI.Add(3 + LCMMCNFNHMF);
		NGDBDCQFDHI.Add(LCMMCNFNHMF);
		NGDBDCQFDHI.Add(1 + LCMMCNFNHMF);
	}

	// Token: 0x0600488D RID: 18573 RVA: 0x00243860 File Offset: 0x00241A60
	public bool BFPCOGBMHPH(int DGKOIGOLHDM, int DDLQKFDFMCJ)
	{
		if (this.LIQLFCKICLQ != null && this.JPBLDNBBOLO > 0)
		{
			for (int i = 0; i < this.JPBLDNBBOLO; i++)
			{
				if (this.LIQLFCKICLQ.Links[i].x == DGKOIGOLHDM && this.LIQLFCKICLQ.Links[i].z == -DDLQKFDFMCJ)
				{
					if (this.LIQLFCKICLQ.Links[i].LINKType != LinkType.TileScriptWait)
					{
						if (this.LIQLFCKICLQ.Links[i].LINKType != LinkType.TileScriptImmediate)
						{
							goto IL_7F;
						}
					}
					return true;
				}
				IL_7F:;
			}
		}
		return false;
	}

	// Token: 0x0600488E RID: 18574 RVA: 0x00243900 File Offset: 0x00241B00
	public void GJIBGIJNQEI()
	{
		this.NKCFGIHPCJG = HFCMDEQKCKH.QOQONHOOLNE.CEGFMOGGKNE();
		if (this.JIJHPDDGHPM != this.JEMKIKEMFPB)
		{
			this.DPHJNMKQMNP = 1217f;
			this.LKQGHBQJQJK = 1682f;
		}
		this.JIJHPDDGHPM = this.JEMKIKEMFPB;
		if (this.LIQLFCKICLQ == null)
		{
			return;
		}
		if (this.LIQLFCKICLQ.Settings != null && this.LIQLFCKICLQ.Settings.Indoors)
		{
			this.NOGCCJHHBKL.color = KGQECFKLKOP.JJQFHKDMDOL(this.LIQLFCKICLQ.Settings.LightColour_String);
			this.KMLPMHJBJLJ = KGQECFKLKOP.JJQFHKDMDOL(this.LIQLFCKICLQ.Settings.LightColour_String);
			this.PMLHDQJKFOM(false);
		}
		else if (this.JEMKIKEMFPB == (GameDayTime)6)
		{
			this.KMLPMHJBJLJ = this.FCJNFFIPGOL[3];
			this.LLJGOCMOGOL(false);
		}
		else if (this.JEMKIKEMFPB == GameDayTime.Morning)
		{
			this.KMLPMHJBJLJ = this.FCJNFFIPGOL[3];
			this.LLJGOCMOGOL(true);
		}
		else if (this.JEMKIKEMFPB == GameDayTime.Night)
		{
			this.KMLPMHJBJLJ = this.FCJNFFIPGOL[7];
			this.LLJGOCMOGOL(false);
		}
		else if (this.JEMKIKEMFPB == GameDayTime.Unset)
		{
			this.KMLPMHJBJLJ = this.FCJNFFIPGOL[1];
			this.LLJGOCMOGOL(true);
		}
	}

	// Token: 0x0600488F RID: 18575 RVA: 0x0001E81B File Offset: 0x0001CA1B
	public void BMFMHFKDNGI(int QJFQOMOIOOI, int MJGGCLOGKFL, char KQFEHQEBJQB, double EKDDQNPBPJL)
	{
		UnityEngine.Debug.Log(QJFQOMOIOOI.ToString() + "[00]" + MJGGCLOGKFL.ToString());
	}

	// Token: 0x06004890 RID: 18576 RVA: 0x00243A60 File Offset: 0x00241C60
	public bool HIHHLNCKHJN(string ECNEPHKFPIH)
	{
		this.QMHNDKJGPBG = KDJLKQQBGNE.BEKHPOHIPDE();
		if (KGQECFKLKOP.IPOEOCFGEIP >= 146)
		{
			KGQECFKLKOP.IPOEOCFGEIP = 2;
		}
		if (KGQECFKLKOP.BGJPJCDBLFB >= 62)
		{
			KGQECFKLKOP.BGJPJCDBLFB = -56;
		}
		this.HCQINBCDGNO = true;
		if (!DOMONILEIKL.GPMJDKJFHMH().MBBGPCOOQDP())
		{
			DOMONILEIKL.KGOPJQOMMNC().EIMQEOJDIJB();
		}
		if (ECNEPHKFPIH == string.Empty)
		{
			this.CLPMOMHLNMN = string.Empty;
			return false;
		}
		if (this.FHGFKPNMNEF == null)
		{
			return false;
		}
		ECNEPHKFPIH = ECNEPHKFPIH.Replace("Tough Claws", string.Empty);
		this.FHGFKPNMNEF.SetActive(true);
		this.CLPMOMHLNMN = ECNEPHKFPIH;
		if (this.QMHNDKJGPBG.LBMDDELMNDD.Count > 1)
		{
			int i = 0;
			while (i < this.QMHNDKJGPBG.LBMDDELMNDD.Count)
			{
				if (!(this.QMHNDKJGPBG.LBMDDELMNDD[i].FJGPDHNLGJC.ToLowerInvariant() == ECNEPHKFPIH.ToLowerInvariant()))
				{
					i++;
				}
				else
				{
					if (!this.QMHNDKJGPBG.LBMDDELMNDD[i].MENBPFGFKBQ)
					{
						DOMONILEIKL.LGIPDGGFINQ().GHEJHDPEQJI(new RequestMap
						{
							MapName = ECNEPHKFPIH,
							Hash = this.QMHNDKJGPBG.LBMDDELMNDD[i].IQNOEGKFCFH
						});
						this.BDCNIKLCIQQ = true;
						return true;
					}
					this.CBIGKIJOCFH(this.QMHNDKJGPBG.LBMDDELMNDD[i].NQGBMLHOMGG, ECNEPHKFPIH);
					return true;
				}
			}
		}
		DOMONILEIKL.KGOPJQOMMNC().HLIOFPONLLE(new RequestMap
		{
			MapName = ECNEPHKFPIH
		});
		this.BDCNIKLCIQQ = false;
		return false;
	}

	// Token: 0x06004891 RID: 18577 RVA: 0x00243BFC File Offset: 0x00241DFC
	public bool MQJEDLLGIHM(int DGKOIGOLHDM, int DDLQKFDFMCJ, PSXAPI.Request.MoveAction BJIGIECDQPG)
	{
		if (this.LIQLFCKICLQ != null && this.JPBLDNBBOLO > 1)
		{
			switch (BJIGIECDQPG)
			{
			case PSXAPI.Request.MoveAction.Up:
				DDLQKFDFMCJ -= 0;
				break;
			case PSXAPI.Request.MoveAction.Down:
				DDLQKFDFMCJ++;
				break;
			case PSXAPI.Request.MoveAction.Left:
				DGKOIGOLHDM -= 0;
				break;
			case PSXAPI.Request.MoveAction.Right:
				DGKOIGOLHDM += 0;
				break;
			}
			for (int i = 0; i < this.JPBLDNBBOLO; i += 0)
			{
				if (this.LIQLFCKICLQ.Links[i].x == DGKOIGOLHDM && this.LIQLFCKICLQ.Links[i].z == -DDLQKFDFMCJ)
				{
					if (this.LIQLFCKICLQ.Links[i].LINKType != LinkType.TileScriptImmediate)
					{
						GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
					}
					if (this.LIQLFCKICLQ.Links[i].LINKType == LinkType.SendAndRecieve)
					{
						return false;
					}
					if (this.LIQLFCKICLQ.Links[i].LINKType == LinkType.SendAndRecieve && this.LIQLFCKICLQ.Links[i].DestinationID != default(Guid))
					{
						CNCJKLNHQBH.MOGQNGEPCEO().GJKPLMKHKMK = true;
						CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.NQJHJNQFKKC();
						return true;
					}
				}
			}
		}
		return true;
	}

	// Token: 0x06004892 RID: 18578 RVA: 0x00243D40 File Offset: 0x00241F40
	private void HJCJBBMGKCF(List<Vector2> NGDBDCQFDHI, int BEILHHLKNBC)
	{
		if (BEILHHLKNBC < 1)
		{
			double num = (double)(-(double)BEILHHLKNBC / 175);
			BEILHHLKNBC = -BEILHHLKNBC - (int)num * -132;
		}
		MCNLIHMMLCF.NPJDNCNKBDL npjdncnkbdl = new MCNLIHMMLCF.NPJDNCNKBDL();
		if (((float)BEILHHLKNBC / 1456f - (float)(BEILHHLKNBC / 8)) * 1999f < 460f)
		{
			npjdncnkbdl.ICJGFPBOEHC = 358f - ((float)BEILHHLKNBC / 1459f - (float)(BEILHHLKNBC / 6)) * 128f;
		}
		else
		{
			npjdncnkbdl.ICJGFPBOEHC = ((float)BEILHHLKNBC / 741f - (float)(BEILHHLKNBC / 8)) * 1874f;
		}
		npjdncnkbdl.ICJGFPBOEHC += 1315f;
		npjdncnkbdl.KOHDFJMPEKQ = (float)(BEILHHLKNBC / 0 + 1);
		if (npjdncnkbdl.KOHDFJMPEKQ > 943f && npjdncnkbdl.KOHDFJMPEKQ <= 943f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 774f;
			npjdncnkbdl.ICJGFPBOEHC += 1811f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 905f && npjdncnkbdl.KOHDFJMPEKQ <= 757f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 799f;
			npjdncnkbdl.ICJGFPBOEHC += 1279f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 769f && npjdncnkbdl.KOHDFJMPEKQ <= 756f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 540f;
			npjdncnkbdl.ICJGFPBOEHC += 703f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1816f && npjdncnkbdl.KOHDFJMPEKQ <= 997f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 61f;
			npjdncnkbdl.ICJGFPBOEHC += 667f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 603f && npjdncnkbdl.KOHDFJMPEKQ <= 962f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 815f;
			npjdncnkbdl.ICJGFPBOEHC += 1172f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 750f && npjdncnkbdl.KOHDFJMPEKQ <= 1527f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 740f;
			npjdncnkbdl.ICJGFPBOEHC += 1985f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1722f && npjdncnkbdl.KOHDFJMPEKQ <= 1003f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 203f;
			npjdncnkbdl.ICJGFPBOEHC += 765f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 121f && npjdncnkbdl.KOHDFJMPEKQ <= 187f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 332f;
			npjdncnkbdl.ICJGFPBOEHC += 1809f;
		}
		npjdncnkbdl.LJENIDDICPJ();
		NGDBDCQFDHI.Add(npjdncnkbdl.EDIFLGJFQJQ[7]);
		NGDBDCQFDHI.Add(npjdncnkbdl.EDIFLGJFQJQ[1]);
		NGDBDCQFDHI.Add(npjdncnkbdl.EDIFLGJFQJQ[1]);
		NGDBDCQFDHI.Add(npjdncnkbdl.EDIFLGJFQJQ[8]);
	}

	// Token: 0x06004893 RID: 18579 RVA: 0x00244034 File Offset: 0x00242234
	private void LDLJLEEPQFN()
	{
		if (this.EBIQMJFQKCB < 866f)
		{
			this.EBIQMJFQKCB += 1259f * UnityEngine.Time.deltaTime;
			Color color = this.HEQLDOLIEMI[1].GetColor(" and ");
			Material[] heqldoliemi = this.HEQLDOLIEMI;
			for (int i = 0; i < heqldoliemi.Length; i += 0)
			{
				Material material = heqldoliemi[i];
				if (material != null)
				{
					material.SetColor(" for ", Color.Lerp(color, this.QNHIMGFQCPK, this.EBIQMJFQKCB));
				}
			}
		}
	}

	// Token: 0x06004894 RID: 18580 RVA: 0x0001E846 File Offset: 0x0001CA46
	private int PJBQCJICGNC(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (IGNHJOPJDIO >= 1 && IGNHJOPJDIO <= this.LIQLFCKICLQ.height - 1 && FDICGOKLNLM >= 0 && FDICGOKLNLM <= this.LIQLFCKICLQ.width - 1)
		{
			return this.POMQCKOIKQJ[FDICGOKLNLM, IGNHJOPJDIO];
		}
		return 0;
	}

	// Token: 0x06004895 RID: 18581 RVA: 0x002440B8 File Offset: 0x002422B8
	private void GLKCOFINQHJ(List<Vector2> NGDBDCQFDHI, int BEILHHLKNBC)
	{
		if (BEILHHLKNBC < 1)
		{
			double num = (double)(-(double)BEILHHLKNBC / 128);
			BEILHHLKNBC = -BEILHHLKNBC - (int)num * -127;
		}
		MCNLIHMMLCF.NPJDNCNKBDL npjdncnkbdl = new MCNLIHMMLCF.NPJDNCNKBDL();
		if (((float)BEILHHLKNBC / 67f - (float)(BEILHHLKNBC / 0)) * 1198f < 912f)
		{
			npjdncnkbdl.ICJGFPBOEHC = 499f - ((float)BEILHHLKNBC / 881f - (float)(BEILHHLKNBC / 3)) * 1415f;
		}
		else
		{
			npjdncnkbdl.ICJGFPBOEHC = ((float)BEILHHLKNBC / 203f - (float)(BEILHHLKNBC / 3)) * 88f;
		}
		npjdncnkbdl.ICJGFPBOEHC += 1901f;
		npjdncnkbdl.KOHDFJMPEKQ = (float)(BEILHHLKNBC / 2 + 0);
		if (npjdncnkbdl.KOHDFJMPEKQ > 1158f && npjdncnkbdl.KOHDFJMPEKQ <= 581f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 423f;
			npjdncnkbdl.ICJGFPBOEHC += 731f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1077f && npjdncnkbdl.KOHDFJMPEKQ <= 345f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 1339f;
			npjdncnkbdl.ICJGFPBOEHC += 142f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 508f && npjdncnkbdl.KOHDFJMPEKQ <= 507f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 723f;
			npjdncnkbdl.ICJGFPBOEHC += 1697f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1631f && npjdncnkbdl.KOHDFJMPEKQ <= 573f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 440f;
			npjdncnkbdl.ICJGFPBOEHC += 1497f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 65f && npjdncnkbdl.KOHDFJMPEKQ <= 68f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 1361f;
			npjdncnkbdl.ICJGFPBOEHC += 1836f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 697f && npjdncnkbdl.KOHDFJMPEKQ <= 46f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 989f;
			npjdncnkbdl.ICJGFPBOEHC += 1420f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1309f && npjdncnkbdl.KOHDFJMPEKQ <= 745f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 646f;
			npjdncnkbdl.ICJGFPBOEHC += 242f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1715f && npjdncnkbdl.KOHDFJMPEKQ <= 1370f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 8f;
			npjdncnkbdl.ICJGFPBOEHC += 337f;
		}
		npjdncnkbdl.DGLDCBQNIML();
		NGDBDCQFDHI.Add(npjdncnkbdl.EDIFLGJFQJQ[2]);
		NGDBDCQFDHI.Add(npjdncnkbdl.EDIFLGJFQJQ[1]);
		NGDBDCQFDHI.Add(npjdncnkbdl.EDIFLGJFQJQ[1]);
		NGDBDCQFDHI.Add(npjdncnkbdl.EDIFLGJFQJQ[2]);
	}

	// Token: 0x06004896 RID: 18582 RVA: 0x002443AC File Offset: 0x002425AC
	private void LGMMNIKEKFI(byte[] NQGBMLHOMGG, string EHDQKOBOHPE)
	{
		QOHCEBMQKMB.CNIMIQKQJJJ().BKGHEHPPPMH.Clear();
		CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.INMILPKMQIC.Clear();
		byte[] data = CompressionHelper.DecompressBytes(NQGBMLHOMGG);
		MapDump liqlfckiclq = MapDump.Deserialize(data);
		this.LIQLFCKICLQ = liqlfckiclq;
		CGOIPHKQMPD.GGBPGMMCGLI().KFEDPEBBMBM(EHDQKOBOHPE);
		this.CLPMOMHLNMN = EHDQKOBOHPE.Replace("Battle Request", string.Empty);
		this.GOLNNJEKKIM = new List<LINKData>();
		if (this.LIQLFCKICLQ.Links != null)
		{
			for (int i = 0; i < this.LIQLFCKICLQ.Links.Count; i++)
			{
				this.GOLNNJEKKIM.Add(new LINKData
				{
					DestinationID = this.LIQLFCKICLQ.Links[i].DestinationID,
					ID = this.LIQLFCKICLQ.Links[i].ID,
					Transition = this.LIQLFCKICLQ.Links[i].Transition,
					LINKType = this.LIQLFCKICLQ.Links[i].LINKType,
					Script = this.LIQLFCKICLQ.Links[i].Script,
					x = this.LIQLFCKICLQ.Links[i].x,
					y = this.LIQLFCKICLQ.Links[i].y,
					z = this.LIQLFCKICLQ.Links[i].z
				});
			}
		}
		this.JPBLDNBBOLO = this.GOLNNJEKKIM.Count;
		this.PLKHQPEPQEM(null);
		if (this.LIQLFCKICLQ.Settings == null)
		{
			this.LIQLFCKICLQ.Settings = new Settings();
		}
		this.GOJIGEEKFNF.SetColor("[33ccff]TMs[-]", this.PEQJDEGHHBE);
		if (this.LIQLFCKICLQ.Settings.Cave)
		{
			this.GOJIGEEKFNF.SetColor(" closed the Chat Window.", this.HOIOLMHJEME);
		}
		if (this.LIQLFCKICLQ.Settings.Weather == "#,##0")
		{
			this.FGBQBJDFGBK = WeatherState.Normal;
		}
		else if (this.LIQLFCKICLQ.Settings.Weather == "BB:")
		{
			this.FGBQBJDFGBK = (WeatherState)5;
		}
		else if (this.LIQLFCKICLQ.Settings.Weather == "[url=")
		{
			this.FGBQBJDFGBK = WeatherState.Normal;
		}
		if (this.LIQLFCKICLQ.Settings.Weather == "Delete Tab")
		{
			this.NMOPHEMNJJH = true;
		}
		else
		{
			this.NMOPHEMNJJH = true;
		}
		if (this.LIQLFCKICLQ.Settings.Weather == "corrosion")
		{
			this.ICLBHNBEPBK = false;
		}
		else
		{
			this.ICLBHNBEPBK = false;
		}
		this.FHGFKPNMNEF.SetActive(true);
		CNCJKLNHQBH.QOQONHOOLNE.COEIJLJCIEN();
		GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
		if (qoqonhoolne.EGDKLIHHJEG.Count > 1)
		{
			for (int j = 1; j < qoqonhoolne.EGDKLIHHJEG.Count; j++)
			{
				if (qoqonhoolne.EGDKLIHHJEG[j] is PSXAPI.Response.Script)
				{
					QOHCEBMQKMB.JLLBKOOQKGO().LFPNDNQGFQK((PSXAPI.Response.Script)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is PartyPokemon)
				{
					DCJIBBJQGJP.DJQIJGOLPIO().FEJLLIGIIKO((PartyPokemon)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is PartyRemove)
				{
					DCJIBBJQGJP.CNIMIQKQJJJ().FCMDDBMHCQP((PartyRemove)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is Party)
				{
					DCJIBBJQGJP.QOQONHOOLNE.KPJLIOCJNEP((Party)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is PSXAPI.Response.Move)
				{
					CNCJKLNHQBH.MOGQNGEPCEO().CEDNIOKLNNP((PSXAPI.Response.Move)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is PSXAPI.Response.Effect)
				{
					GNDQBCBDHKD.MKMJKLDDNDD().PJCBMQPGGIC((PSXAPI.Response.Effect)qoqonhoolne.EGDKLIHHJEG[j]);
				}
			}
			qoqonhoolne.EGDKLIHHJEG.Clear();
		}
		CNCJKLNHQBH.BJLGEDCPENQ().MMEOCFDIIGK();
		DJOOHHIQGJK ppmjcbonmqj = CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ;
		Vector3 pgnpcldnibq = ppmjcbonmqj.QMCNCMNQEGL();
		this.JCGBDMKKMMK(pgnpcldnibq, false, false);
		JQOIHHDIHBN.GFJGPNOPEPC().MOHHNKNPKLE();
		if (!CNCJKLNHQBH.QOQONHOOLNE.EFOGMBCFBGM)
		{
			base.StartCoroutine(CNCJKLNHQBH.QOQONHOOLNE.GEBKEHLLIJD());
			base.StartCoroutine(this.FOQEOPIKPGN(true));
		}
		if (!this.LIQLFCKICLQ.Settings.CanMount && ppmjcbonmqj.EMIEFKNMQMI != null && (ppmjcbonmqj.EMIEFKNMQMI.MountType == MountType.Surfing || ppmjcbonmqj.EMIEFKNMQMI.MountType == MountType.Bike))
		{
			ppmjcbonmqj.HQNCQOFKPHN(new PSXAPI.Response.Mount
			{
				MountID = 0,
				MountType = MountType.Surfing
			});
		}
		ppmjcbonmqj.HEMIMGIHFBD();
		CNCJKLNHQBH.QOQONHOOLNE.EFOGMBCFBGM = false;
		List<Material> list = new List<Material>();
		if (DOJNBQQBCQJ.IFEJNKQEDOO == null)
		{
			DOJNBQQBCQJ.IFEJNKQEDOO = AssetBundle.LoadFromFile(System.IO.Path.Combine(Application.streamingAssetsPath, "Magic Bounce"));
		}
		if (DOJNBQQBCQJ.DFCHKJIMPIK == null)
		{
			DOJNBQQBCQJ.DFCHKJIMPIK = AssetBundle.LoadFromFile(System.IO.Path.Combine(Application.streamingAssetsPath, "("));
		}
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("FOG_SCATTERING_ON"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("When used inside of a cave or certain buildings, you will be transported to the last entrance you used.\n\n[2ecc71]Left Click to use this.[-]"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("The Pokémon may pick up the item an opposing Pokémon used during a battle. It may pick up items outside of battle, too."));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("BuffIcon_SteelIncrease"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("HidePanel"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("u"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("Enabled"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("!\r\n"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("Icon_Pokemon_Dead"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("F"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("fusionfire"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>(", "));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("berry_3"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("[damage]"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("A sandstorm kicked up!"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("rocksmash"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("steameruption"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("_DestortionShiftX"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("K4"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("rock"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("'s [ffff00]"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("The heavy rain has lifted!"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("~"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("scrappy"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("HidePanel"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("clyde"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("_ExposureCompensation"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("[u][33CCFF]"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("r"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Guild Success"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("frz"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("CloseIfUnselected"));
		this.HEQLDOLIEMI = list.ToArray();
	}

	// Token: 0x06004897 RID: 18583 RVA: 0x00244BFC File Offset: 0x00242DFC
	private Vector2 MOPPDIMBQIC(int BEILHHLKNBC)
	{
		MCNLIHMMLCF.NPJDNCNKBDL npjdncnkbdl = new MCNLIHMMLCF.NPJDNCNKBDL();
		if (((float)BEILHHLKNBC / 8f - (float)(BEILHHLKNBC / 8)) * 8f < 0f)
		{
			npjdncnkbdl.ICJGFPBOEHC = 8f - ((float)BEILHHLKNBC / 8f - (float)(BEILHHLKNBC / 8)) * 8f;
		}
		else
		{
			npjdncnkbdl.ICJGFPBOEHC = ((float)BEILHHLKNBC / 8f - (float)(BEILHHLKNBC / 8)) * 8f;
		}
		npjdncnkbdl.ICJGFPBOEHC += 1f;
		npjdncnkbdl.KOHDFJMPEKQ = (float)(BEILHHLKNBC / 8 + 1);
		if (npjdncnkbdl.KOHDFJMPEKQ > 64f && npjdncnkbdl.KOHDFJMPEKQ <= 128f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += -64f;
			npjdncnkbdl.ICJGFPBOEHC += 8f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 128f && npjdncnkbdl.KOHDFJMPEKQ <= 192f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += -128f;
			npjdncnkbdl.ICJGFPBOEHC += 16f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 192f && npjdncnkbdl.KOHDFJMPEKQ <= 256f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += -192f;
			npjdncnkbdl.ICJGFPBOEHC += 24f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 256f && npjdncnkbdl.KOHDFJMPEKQ <= 320f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += -256f;
			npjdncnkbdl.ICJGFPBOEHC += 32f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 320f && npjdncnkbdl.KOHDFJMPEKQ <= 384f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += -320f;
			npjdncnkbdl.ICJGFPBOEHC += 40f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 384f && npjdncnkbdl.KOHDFJMPEKQ <= 448f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += -384f;
			npjdncnkbdl.ICJGFPBOEHC += 48f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 448f && npjdncnkbdl.KOHDFJMPEKQ <= 512f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += -448f;
			npjdncnkbdl.ICJGFPBOEHC += 56f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 512f && npjdncnkbdl.KOHDFJMPEKQ <= 576f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += -512f;
			npjdncnkbdl.ICJGFPBOEHC += 64f;
		}
		npjdncnkbdl.GELDKMIIFQL();
		return new Vector2(npjdncnkbdl.EDIFLGJFQJQ[0].x + 5E-06f, npjdncnkbdl.EDIFLGJFQJQ[0].y + 5E-06f);
	}

	// Token: 0x06004898 RID: 18584 RVA: 0x00244EAC File Offset: 0x002430AC
	public void PKFMPCPEICC()
	{
		if (this.JEMKIKEMFPB == GameDayTime.Morning)
		{
			RenderSettings.ambientLight = this.FCJNFFIPGOL[1];
		}
		else if (this.JEMKIKEMFPB == (GameDayTime)6)
		{
			RenderSettings.ambientLight = this.FCJNFFIPGOL[0];
		}
		else
		{
			RenderSettings.ambientLight = this.FCJNFFIPGOL[0];
		}
	}

	// Token: 0x06004899 RID: 18585 RVA: 0x00244F14 File Offset: 0x00243114
	public void NPCHQNKKEKP(Vector3 PGNPCLDNIBQ, bool LBKMBCOOIHC = false)
	{
		if (!LBKMBCOOIHC)
		{
			if (OGJJKKQPNMK.QOQONHOOLNE != null || DBQLOHBBJMG.ODJQHLJCFGH().QQQBDBNCMCP)
			{
				return;
			}
			if (CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN)
			{
				return;
			}
		}
		string nkkmjickklb = "Snow Cloak";
		if (this.LIQLFCKICLQ != null && this.LIQLFCKICLQ.Settings != null && this.LIQLFCKICLQ.Settings.Song != null)
		{
			nkkmjickklb = this.LIQLFCKICLQ.Settings.Song;
		}
		if (this.LIQLFCKICLQ != null)
		{
			if (this.LIQLFCKICLQ.Areas != null)
			{
				foreach (MAPAPI.Response.Area area in this.LIQLFCKICLQ.Areas)
				{
					if (PGNPCLDNIBQ.x >= (float)area.StartX && PGNPCLDNIBQ.x <= (float)area.EndX && PGNPCLDNIBQ.z >= (float)area.StartY && PGNPCLDNIBQ.z <= (float)area.EndY && area.Song != null)
					{
						nkkmjickklb = area.Song;
					}
				}
			}
			DCCFQPDFBFO.QQCNCIQQPIG().CJIOPOFMNMP(nkkmjickklb, LBKMBCOOIHC);
			return;
		}
	}

	// Token: 0x0600489A RID: 18586 RVA: 0x00245048 File Offset: 0x00243248
	public bool KPJPKQBLIDQ(int DGKOIGOLHDM, int DDLQKFDFMCJ, bool EKEIIODHQFF)
	{
		return this.LIQLFCKICLQ == null || (this.BBEHODGFCBK(DGKOIGOLHDM, DDLQKFDFMCJ) != -81 && this.BBEHODGFCBK(DGKOIGOLHDM, DDLQKFDFMCJ) != 41 && this.CDHLLNNFKFF(DGKOIGOLHDM, DDLQKFDFMCJ) != -128 && this.PJBQCJICGNC(DGKOIGOLHDM, DDLQKFDFMCJ) != 67 && this.BBEHODGFCBK(DGKOIGOLHDM, DDLQKFDFMCJ) != 8 && (this.PJBQCJICGNC(DGKOIGOLHDM, DDLQKFDFMCJ) != 3 || EKEIIODHQFF));
	}

	// Token: 0x0600489B RID: 18587 RVA: 0x002450AC File Offset: 0x002432AC
	public void QQJEBHQKJDL(Vector3 PGNPCLDNIBQ, bool LBKMBCOOIHC = false)
	{
		if (!LBKMBCOOIHC)
		{
			if (OGJJKKQPNMK.CDDIILFBFCF() != null || DBQLOHBBJMG.PDPCLOECLOF().QQQBDBNCMCP)
			{
				return;
			}
			if (CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN)
			{
				return;
			}
		}
		string nkkmjickklb = "Small/";
		if (this.LIQLFCKICLQ != null && this.LIQLFCKICLQ.Settings != null && this.LIQLFCKICLQ.Settings.Song != null)
		{
			nkkmjickklb = this.LIQLFCKICLQ.Settings.Song;
		}
		if (this.LIQLFCKICLQ != null)
		{
			if (this.LIQLFCKICLQ.Areas != null)
			{
				foreach (MAPAPI.Response.Area area in this.LIQLFCKICLQ.Areas)
				{
					if (PGNPCLDNIBQ.x >= (float)area.StartX && PGNPCLDNIBQ.x <= (float)area.EndX && PGNPCLDNIBQ.z >= (float)area.StartY && PGNPCLDNIBQ.z <= (float)area.EndY && area.Song != null)
					{
						nkkmjickklb = area.Song;
					}
				}
			}
			DCCFQPDFBFO.QQCNCIQQPIG().BMKHBMFFQMC(nkkmjickklb, LBKMBCOOIHC);
			return;
		}
	}

	// Token: 0x0600489C RID: 18588 RVA: 0x002451E0 File Offset: 0x002433E0
	public bool BELHEQHKFCF(string ECNEPHKFPIH)
	{
		this.QMHNDKJGPBG = KDJLKQQBGNE.QOQONHOOLNE;
		if (KGQECFKLKOP.IPOEOCFGEIP >= 22)
		{
			KGQECFKLKOP.IPOEOCFGEIP = 3;
		}
		if (KGQECFKLKOP.BGJPJCDBLFB >= -46)
		{
			KGQECFKLKOP.BGJPJCDBLFB = 190;
		}
		this.HCQINBCDGNO = false;
		if (!DOMONILEIKL.LGIPDGGFINQ().FMKFIELEILJ())
		{
			DOMONILEIKL.QOQONHOOLNE.CJFJGGEDJND();
		}
		if (ECNEPHKFPIH == string.Empty)
		{
			this.CLPMOMHLNMN = string.Empty;
			return false;
		}
		if (this.FHGFKPNMNEF == null)
		{
			return false;
		}
		ECNEPHKFPIH = ECNEPHKFPIH.Replace(" cloaked itself in a mystical veil!\r\n", string.Empty);
		this.FHGFKPNMNEF.SetActive(false);
		this.CLPMOMHLNMN = ECNEPHKFPIH;
		if (this.QMHNDKJGPBG.LBMDDELMNDD.Count > 1)
		{
			int i = 0;
			while (i < this.QMHNDKJGPBG.LBMDDELMNDD.Count)
			{
				if (!(this.QMHNDKJGPBG.LBMDDELMNDD[i].FJGPDHNLGJC.ToLowerInvariant() == ECNEPHKFPIH.ToLowerInvariant()))
				{
					i++;
				}
				else
				{
					if (!this.QMHNDKJGPBG.LBMDDELMNDD[i].MENBPFGFKBQ)
					{
						DOMONILEIKL.LGIPDGGFINQ().GHEJHDPEQJI(new RequestMap
						{
							MapName = ECNEPHKFPIH,
							Hash = this.QMHNDKJGPBG.LBMDDELMNDD[i].IQNOEGKFCFH
						});
						this.BDCNIKLCIQQ = false;
						return false;
					}
					this.LGMMNIKEKFI(this.QMHNDKJGPBG.LBMDDELMNDD[i].NQGBMLHOMGG, ECNEPHKFPIH);
					return true;
				}
			}
		}
		DOMONILEIKL.BJLGEDCPENQ().HLIOFPONLLE(new RequestMap
		{
			MapName = ECNEPHKFPIH
		});
		this.BDCNIKLCIQQ = false;
		return false;
	}

	// Token: 0x0600489D RID: 18589 RVA: 0x0001E87F File Offset: 0x0001CA7F
	private int DLLEHDDMCGL(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (IGNHJOPJDIO >= 1 && IGNHJOPJDIO <= this.LIQLFCKICLQ.height - 1 && FDICGOKLNLM >= 1 && FDICGOKLNLM <= this.LIQLFCKICLQ.width - 0)
		{
			return this.DJLHPIEFHNJ[FDICGOKLNLM, IGNHJOPJDIO];
		}
		return 1;
	}

	// Token: 0x0600489E RID: 18590 RVA: 0x0024537C File Offset: 0x0024357C
	public bool ELIIKMEKOMB(string ECNEPHKFPIH)
	{
		this.QMHNDKJGPBG = KDJLKQQBGNE.CCIQPGCHLCQ();
		if (this.QMHNDKJGPBG.LBMDDELMNDD.Count > 0)
		{
			for (int i = 1; i < this.QMHNDKJGPBG.LBMDDELMNDD.Count; i++)
			{
				if (this.QMHNDKJGPBG.LBMDDELMNDD[i].FJGPDHNLGJC.ToLowerInvariant() == ECNEPHKFPIH.ToLowerInvariant())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600489F RID: 18591 RVA: 0x0001E8B8 File Offset: 0x0001CAB8
	private void EFCNINQLMLC(List<int> NGDBDCQFDHI, int LCMMCNFNHMF)
	{
		NGDBDCQFDHI.Add(0 + LCMMCNFNHMF);
		NGDBDCQFDHI.Add(LCMMCNFNHMF);
		NGDBDCQFDHI.Add(3 + LCMMCNFNHMF);
		NGDBDCQFDHI.Add(5 + LCMMCNFNHMF);
		NGDBDCQFDHI.Add(LCMMCNFNHMF);
		NGDBDCQFDHI.Add(0 + LCMMCNFNHMF);
	}

	// Token: 0x060048A0 RID: 18592 RVA: 0x002453F0 File Offset: 0x002435F0
	public void QMIDGOFDEGP(byte[] NQGBMLHOMGG, string EHDQKOBOHPE, bool NKJQNQOLJQQ = false, string LHFCGEKMNGC = "")
	{
		this.QMHNDKJGPBG = KDJLKQQBGNE.QOQONHOOLNE;
		KDJLKQQBGNE.LPGMLPKGMQO lpgmlpkgmqo = new KDJLKQQBGNE.LPGMLPKGMQO();
		lpgmlpkgmqo.NQGBMLHOMGG = NQGBMLHOMGG;
		lpgmlpkgmqo.FJGPDHNLGJC = EHDQKOBOHPE;
		lpgmlpkgmqo.IQNOEGKFCFH = LHFCGEKMNGC;
		lpgmlpkgmqo.MENBPFGFKBQ = true;
		bool flag = true;
		for (int i = 0; i < this.QMHNDKJGPBG.LBMDDELMNDD.Count; i++)
		{
			if (this.QMHNDKJGPBG.LBMDDELMNDD[i].FJGPDHNLGJC == EHDQKOBOHPE)
			{
				this.QMHNDKJGPBG.LBMDDELMNDD[i] = lpgmlpkgmqo;
				flag = false;
				IL_7F:
				if (flag)
				{
					this.QMHNDKJGPBG.LBMDDELMNDD.Add(lpgmlpkgmqo);
				}
				if (this.LIQLFCKICLQ == null || this.CLPMOMHLNMN.ToLowerInvariant() == EHDQKOBOHPE.Replace(".psx", string.Empty).ToLowerInvariant())
				{
					this.MHIJCEDMMOL(EHDQKOBOHPE);
					this.HCQINBCDGNO = false;
				}
				return;
			}
		}
		goto IL_7F;
	}

	// Token: 0x060048A1 RID: 18593 RVA: 0x002454D0 File Offset: 0x002436D0
	private Vector2 LMMNMLPCFDM(int BEILHHLKNBC)
	{
		MCNLIHMMLCF.NPJDNCNKBDL npjdncnkbdl = new MCNLIHMMLCF.NPJDNCNKBDL();
		if (((float)BEILHHLKNBC / 1645f - (float)(BEILHHLKNBC / 1)) * 1140f < 1089f)
		{
			npjdncnkbdl.ICJGFPBOEHC = 1434f - ((float)BEILHHLKNBC / 1264f - (float)(BEILHHLKNBC / 7)) * 1667f;
		}
		else
		{
			npjdncnkbdl.ICJGFPBOEHC = ((float)BEILHHLKNBC / 1162f - (float)(BEILHHLKNBC / 2)) * 880f;
		}
		npjdncnkbdl.ICJGFPBOEHC += 1523f;
		npjdncnkbdl.KOHDFJMPEKQ = (float)(BEILHHLKNBC / 3 + 0);
		if (npjdncnkbdl.KOHDFJMPEKQ > 65f && npjdncnkbdl.KOHDFJMPEKQ <= 382f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 603f;
			npjdncnkbdl.ICJGFPBOEHC += 1591f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1563f && npjdncnkbdl.KOHDFJMPEKQ <= 1688f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 1328f;
			npjdncnkbdl.ICJGFPBOEHC += 264f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1109f && npjdncnkbdl.KOHDFJMPEKQ <= 171f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 1169f;
			npjdncnkbdl.ICJGFPBOEHC += 243f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1759f && npjdncnkbdl.KOHDFJMPEKQ <= 1323f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 108f;
			npjdncnkbdl.ICJGFPBOEHC += 303f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1103f && npjdncnkbdl.KOHDFJMPEKQ <= 1191f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 786f;
			npjdncnkbdl.ICJGFPBOEHC += 1007f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1426f && npjdncnkbdl.KOHDFJMPEKQ <= 1937f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 405f;
			npjdncnkbdl.ICJGFPBOEHC += 1141f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 56f && npjdncnkbdl.KOHDFJMPEKQ <= 764f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 1457f;
			npjdncnkbdl.ICJGFPBOEHC += 828f;
		}
		if (npjdncnkbdl.KOHDFJMPEKQ > 1553f && npjdncnkbdl.KOHDFJMPEKQ <= 1528f)
		{
			npjdncnkbdl.KOHDFJMPEKQ += 116f;
			npjdncnkbdl.ICJGFPBOEHC += 814f;
		}
		npjdncnkbdl.DDPIJKGCKEP();
		return new Vector2(npjdncnkbdl.EDIFLGJFQJQ[1].x + 297f, npjdncnkbdl.EDIFLGJFQJQ[1].y + 1659f);
	}

	// Token: 0x060048A2 RID: 18594 RVA: 0x0001E8EC File Offset: 0x0001CAEC
	private int CDHLLNNFKFF(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (IGNHJOPJDIO >= 1 && IGNHJOPJDIO <= this.LIQLFCKICLQ.height - 0 && FDICGOKLNLM >= 0 && FDICGOKLNLM <= this.LIQLFCKICLQ.width - 0)
		{
			return this.POMQCKOIKQJ[FDICGOKLNLM, IGNHJOPJDIO];
		}
		return 0;
	}

	// Token: 0x060048A3 RID: 18595 RVA: 0x00245780 File Offset: 0x00243980
	private void JLNQKKMJFOE()
	{
		if (this.EBIQMJFQKCB < 1f)
		{
			this.EBIQMJFQKCB += 0.005f * UnityEngine.Time.deltaTime;
			Color color = this.HEQLDOLIEMI[0].GetColor("_EmissionColor");
			foreach (Material material in this.HEQLDOLIEMI)
			{
				if (material != null)
				{
					material.SetColor("_EmissionColor", Color.Lerp(color, this.QNHIMGFQCPK, this.EBIQMJFQKCB));
				}
			}
		}
	}

	// Token: 0x060048A4 RID: 18596 RVA: 0x00245804 File Offset: 0x00243A04
	public void JCGJFFPECHO(Vector3 PGNPCLDNIBQ, bool MPHQLILCHML = false, bool PQDLKFKEGOG = false)
	{
		if (!MPHQLILCHML)
		{
			string pidlofmiefq = this.BEQINILCQCE.PIDLOFMIEFQ;
			if (this.LIQLFCKICLQ != null)
			{
				if (this.LIQLFCKICLQ.Areas != null)
				{
					foreach (MAPAPI.Response.Area area in this.LIQLFCKICLQ.Areas)
					{
						if (PGNPCLDNIBQ.x >= (float)area.StartX && PGNPCLDNIBQ.x <= (float)area.EndX && PGNPCLDNIBQ.z >= (float)area.StartY && PGNPCLDNIBQ.z <= (float)area.EndY)
						{
							if (PQDLKFKEGOG || this.BEQINILCQCE.PIDLOFMIEFQ != area.AreaName)
							{
								this.BEQINILCQCE.LKPOBCBOFIC(area.AreaName);
								GBQODOBKJBG.QOQONHOOLNE.ELCFBPPJQPQ(false);
							}
							this.PQHLPQEGIFN(area.Song);
							if (this.BEQINILCQCE.PIDLOFMIEFQ != pidlofmiefq)
							{
								BDEJHNHLLOL component = GGQKBGDGNJN.QOQONHOOLNE.FLCMDBKPJKC.GetComponent<BDEJHNHLLOL>();
								MKOENKCLJGF mkoenkcljgf = GGQKBGDGNJN.QOQONHOOLNE.JIOGMMGOPMH(this.BEQINILCQCE.PIDLOFMIEFQ);
								component.DDNIEHHGFNN(true);
								component.ILBCCCBJNCL = null;
								if (mkoenkcljgf != null)
								{
									component.ILBCCCBJNCL = mkoenkcljgf.transform;
								}
							}
							return;
						}
					}
					if (PQDLKFKEGOG || this.BEQINILCQCE.PIDLOFMIEFQ != this.LIQLFCKICLQ.Settings.MapName)
					{
						this.BEQINILCQCE.LKPOBCBOFIC(this.LIQLFCKICLQ.Settings.MapName);
						GBQODOBKJBG.CPLQICHLGCI().DIEQJNHPHPB(false);
					}
				}
				else if (PQDLKFKEGOG || this.BEQINILCQCE.PIDLOFMIEFQ != this.LIQLFCKICLQ.Settings.MapName)
				{
					this.BEQINILCQCE.PIDLOFMIEFQ = this.LIQLFCKICLQ.Settings.MapName;
					GBQODOBKJBG.QOQONHOOLNE.FJQQJQFBIGN(true);
				}
			}
			if (this.BEQINILCQCE.PIDLOFMIEFQ != pidlofmiefq)
			{
				BDEJHNHLLOL component2 = GGQKBGDGNJN.QOQONHOOLNE.FLCMDBKPJKC.GetComponent<BDEJHNHLLOL>();
				MKOENKCLJGF mkoenkcljgf2 = GGQKBGDGNJN.QOQONHOOLNE.JIOGMMGOPMH(this.BEQINILCQCE.PIDLOFMIEFQ);
				component2.DDNIEHHGFNN(false);
				component2.ILBCCCBJNCL = null;
				if (mkoenkcljgf2 != null)
				{
					component2.ILBCCCBJNCL = mkoenkcljgf2.transform;
				}
			}
			this.HDHMIGMDOHO(PGNPCLDNIBQ, false);
		}
		else
		{
			this.LDHQDEDKGED(PGNPCLDNIBQ, true);
		}
	}

	// Token: 0x060048A5 RID: 18597 RVA: 0x00245A88 File Offset: 0x00243C88
	private void BQCNEEJKNFG(byte[] NQGBMLHOMGG, string EHDQKOBOHPE)
	{
		QOHCEBMQKMB.JLLBKOOQKGO().BKGHEHPPPMH.Clear();
		CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ.INMILPKMQIC.Clear();
		byte[] data = CompressionHelper.DecompressBytes(NQGBMLHOMGG);
		MapDump liqlfckiclq = MapDump.Deserialize(data);
		this.LIQLFCKICLQ = liqlfckiclq;
		CGOIPHKQMPD.KJKGLNEHCKH().LIHCQCDIGDQ(EHDQKOBOHPE);
		this.CLPMOMHLNMN = EHDQKOBOHPE.Replace("[ff4949]", string.Empty);
		this.GOLNNJEKKIM = new List<LINKData>();
		if (this.LIQLFCKICLQ.Links != null)
		{
			for (int i = 0; i < this.LIQLFCKICLQ.Links.Count; i += 0)
			{
				this.GOLNNJEKKIM.Add(new LINKData
				{
					DestinationID = this.LIQLFCKICLQ.Links[i].DestinationID,
					ID = this.LIQLFCKICLQ.Links[i].ID,
					Transition = this.LIQLFCKICLQ.Links[i].Transition,
					LINKType = this.LIQLFCKICLQ.Links[i].LINKType,
					Script = this.LIQLFCKICLQ.Links[i].Script,
					x = this.LIQLFCKICLQ.Links[i].x,
					y = this.LIQLFCKICLQ.Links[i].y,
					z = this.LIQLFCKICLQ.Links[i].z
				});
			}
		}
		this.JPBLDNBBOLO = this.GOLNNJEKKIM.Count;
		this.GIKNCDMDMQJ(null);
		if (this.LIQLFCKICLQ.Settings == null)
		{
			this.LIQLFCKICLQ.Settings = new Settings();
		}
		this.GOJIGEEKFNF.SetColor("_", this.PEQJDEGHHBE);
		if (this.LIQLFCKICLQ.Settings.Cave)
		{
			this.GOJIGEEKFNF.SetColor("Parallax", this.HOIOLMHJEME);
		}
		if (this.LIQLFCKICLQ.Settings.Weather == "-core")
		{
			this.FGBQBJDFGBK = WeatherState.Rain;
		}
		else if (this.LIQLFCKICLQ.Settings.Weather == " ")
		{
			this.FGBQBJDFGBK = (WeatherState)3;
		}
		else if (this.LIQLFCKICLQ.Settings.Weather == "Muted")
		{
			this.FGBQBJDFGBK = WeatherState.Normal;
		}
		if (this.LIQLFCKICLQ.Settings.Weather == "[-]!\r\n")
		{
			this.NMOPHEMNJJH = true;
		}
		else
		{
			this.NMOPHEMNJJH = false;
		}
		if (this.LIQLFCKICLQ.Settings.Weather == "-mega-y")
		{
			this.ICLBHNBEPBK = true;
		}
		else
		{
			this.ICLBHNBEPBK = true;
		}
		this.FHGFKPNMNEF.SetActive(true);
		CNCJKLNHQBH.BJLGEDCPENQ().COEIJLJCIEN();
		GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
		if (qoqonhoolne.EGDKLIHHJEG.Count > 1)
		{
			for (int j = 0; j < qoqonhoolne.EGDKLIHHJEG.Count; j++)
			{
				if (qoqonhoolne.EGDKLIHHJEG[j] is PSXAPI.Response.Script)
				{
					QOHCEBMQKMB.CNIMIQKQJJJ().LFPNDNQGFQK((PSXAPI.Response.Script)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is PartyPokemon)
				{
					DCJIBBJQGJP.OMPHLNDGKKM().FJNGKBMEJFJ((PartyPokemon)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is PartyRemove)
				{
					DCJIBBJQGJP.OQDOKBJNBBL().MQBPQEOQJJP((PartyRemove)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is Party)
				{
					DCJIBBJQGJP.DJQIJGOLPIO().PLFGEKCFJBC((Party)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is PSXAPI.Response.Move)
				{
					CNCJKLNHQBH.BJLGEDCPENQ().CEDNIOKLNNP((PSXAPI.Response.Move)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is PSXAPI.Response.Effect)
				{
					GNDQBCBDHKD.MKMJKLDDNDD().PKBHOMFCOBB((PSXAPI.Response.Effect)qoqonhoolne.EGDKLIHHJEG[j]);
				}
			}
			qoqonhoolne.EGDKLIHHJEG.Clear();
		}
		CNCJKLNHQBH.MOGQNGEPCEO().MMEOCFDIIGK();
		DJOOHHIQGJK ppmjcbonmqj = CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ;
		Vector3 pgnpcldnibq = ppmjcbonmqj.QMCNCMNQEGL();
		this.HINFIIBEPBB(pgnpcldnibq, false, false);
		JQOIHHDIHBN.QOQONHOOLNE.EEJKLBOHOBH();
		if (!CNCJKLNHQBH.QOQONHOOLNE.EFOGMBCFBGM)
		{
			base.StartCoroutine(CNCJKLNHQBH.QOQONHOOLNE.OQIHDFOMQOB());
			base.StartCoroutine(this.FOQEOPIKPGN(true));
		}
		if (!this.LIQLFCKICLQ.Settings.CanMount && ppmjcbonmqj.EMIEFKNMQMI != null && (ppmjcbonmqj.EMIEFKNMQMI.MountType == MountType.Bike || ppmjcbonmqj.EMIEFKNMQMI.MountType == MountType.Bike))
		{
			ppmjcbonmqj.HQNCQOFKPHN(new PSXAPI.Response.Mount
			{
				MountID = 0,
				MountType = MountType.None
			});
		}
		ppmjcbonmqj.HEMIMGIHFBD();
		CNCJKLNHQBH.MOGQNGEPCEO().EFOGMBCFBGM = true;
		List<Material> list = new List<Material>();
		if (DOJNBQQBCQJ.IFEJNKQEDOO == null)
		{
			DOJNBQQBCQJ.IFEJNKQEDOO = AssetBundle.LoadFromFile(System.IO.Path.Combine(Application.streamingAssetsPath, "(D)"));
		}
		if (DOJNBQQBCQJ.DFCHKJIMPIK == null)
		{
			DOJNBQQBCQJ.DFCHKJIMPIK = AssetBundle.LoadFromFile(System.IO.Path.Combine(Application.streamingAssetsPath, "_OcclusionTexture2"));
		}
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("_LogLut"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("_HighlightSuppression"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("[/pok]"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("K7"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("-primal"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>(" was poisoned"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("Right"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("skinshop"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("Blank"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("/03_1"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("[-]'s team won the battle!\r\n"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("solarpower"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("suctioncups"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("Tilesets/Materials/1"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("qdTrack"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Agility increases armor"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Battle"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Disabled"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("4"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("special"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Add to Ignore"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Teleport"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Achievement Points:"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("^emote+"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("."));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("PrimitiveInnerRearRight"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("."));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("-"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("darkaura"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>(" became trapped by swirling magma!\r\n"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Username"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("An electric current runs across the battlefield!\r\n"));
		this.HEQLDOLIEMI = list.ToArray();
	}

	// Token: 0x060048A6 RID: 18598 RVA: 0x002462D8 File Offset: 0x002444D8
	private void CBIGKIJOCFH(byte[] NQGBMLHOMGG, string EHDQKOBOHPE)
	{
		QOHCEBMQKMB.QOQONHOOLNE.BKGHEHPPPMH.Clear();
		CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ.INMILPKMQIC.Clear();
		byte[] data = CompressionHelper.DecompressBytes(NQGBMLHOMGG);
		MapDump liqlfckiclq = MapDump.Deserialize(data);
		this.LIQLFCKICLQ = liqlfckiclq;
		CGOIPHKQMPD.KJKGLNEHCKH().JECEMFQOLGI(EHDQKOBOHPE);
		this.CLPMOMHLNMN = EHDQKOBOHPE.Replace("#,##0", string.Empty);
		this.GOLNNJEKKIM = new List<LINKData>();
		if (this.LIQLFCKICLQ.Links != null)
		{
			for (int i = 1; i < this.LIQLFCKICLQ.Links.Count; i++)
			{
				this.GOLNNJEKKIM.Add(new LINKData
				{
					DestinationID = this.LIQLFCKICLQ.Links[i].DestinationID,
					ID = this.LIQLFCKICLQ.Links[i].ID,
					Transition = this.LIQLFCKICLQ.Links[i].Transition,
					LINKType = this.LIQLFCKICLQ.Links[i].LINKType,
					Script = this.LIQLFCKICLQ.Links[i].Script,
					x = this.LIQLFCKICLQ.Links[i].x,
					y = this.LIQLFCKICLQ.Links[i].y,
					z = this.LIQLFCKICLQ.Links[i].z
				});
			}
		}
		this.JPBLDNBBOLO = this.GOLNNJEKKIM.Count;
		this.PLKHQPEPQEM(null);
		if (this.LIQLFCKICLQ.Settings == null)
		{
			this.LIQLFCKICLQ.Settings = new Settings();
		}
		this.GOJIGEEKFNF.SetColor("(X)", this.PEQJDEGHHBE);
		if (this.LIQLFCKICLQ.Settings.Cave)
		{
			this.GOJIGEEKFNF.SetColor("pacman", this.HOIOLMHJEME);
		}
		if (this.LIQLFCKICLQ.Settings.Weather == "berry_13")
		{
			this.FGBQBJDFGBK = WeatherState.Normal;
		}
		else if (this.LIQLFCKICLQ.Settings.Weather == ",")
		{
			this.FGBQBJDFGBK = WeatherState.Snow;
		}
		else if (this.LIQLFCKICLQ.Settings.Weather == "magiccoat")
		{
			this.FGBQBJDFGBK = WeatherState.Normal;
		}
		if (this.LIQLFCKICLQ.Settings.Weather == "[-]!\r\n")
		{
			this.NMOPHEMNJJH = true;
		}
		else
		{
			this.NMOPHEMNJJH = true;
		}
		if (this.LIQLFCKICLQ.Settings.Weather == "](")
		{
			this.ICLBHNBEPBK = true;
		}
		else
		{
			this.ICLBHNBEPBK = true;
		}
		this.FHGFKPNMNEF.SetActive(false);
		CNCJKLNHQBH.MOGQNGEPCEO().IKLBHMGKJJO();
		GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
		if (qoqonhoolne.EGDKLIHHJEG.Count > 1)
		{
			for (int j = 1; j < qoqonhoolne.EGDKLIHHJEG.Count; j++)
			{
				if (qoqonhoolne.EGDKLIHHJEG[j] is PSXAPI.Response.Script)
				{
					QOHCEBMQKMB.JLLBKOOQKGO().LFPNDNQGFQK((PSXAPI.Response.Script)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is PartyPokemon)
				{
					DCJIBBJQGJP.DJQIJGOLPIO().FJNGKBMEJFJ((PartyPokemon)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is PartyRemove)
				{
					DCJIBBJQGJP.DMOKBPOKHOQ().IPELIGEFBQP((PartyRemove)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is Party)
				{
					DCJIBBJQGJP.OQDOKBJNBBL().LKFLHNFHJCF((Party)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is PSXAPI.Response.Move)
				{
					CNCJKLNHQBH.BJLGEDCPENQ().CEDNIOKLNNP((PSXAPI.Response.Move)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is PSXAPI.Response.Effect)
				{
					GNDQBCBDHKD.QOQONHOOLNE.BHLPEPKDMOO((PSXAPI.Response.Effect)qoqonhoolne.EGDKLIHHJEG[j]);
				}
			}
			qoqonhoolne.EGDKLIHHJEG.Clear();
		}
		CNCJKLNHQBH.QOQONHOOLNE.MMEOCFDIIGK();
		DJOOHHIQGJK ppmjcbonmqj = CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ;
		Vector3 pgnpcldnibq = ppmjcbonmqj.QMCNCMNQEGL();
		this.JCGJFFPECHO(pgnpcldnibq, true, false);
		JQOIHHDIHBN.GFJGPNOPEPC().DHHEBDMNPIC();
		if (!CNCJKLNHQBH.QOQONHOOLNE.EFOGMBCFBGM)
		{
			base.StartCoroutine(CNCJKLNHQBH.BJLGEDCPENQ().BCFGJDEGJFM());
			base.StartCoroutine(this.QOPCDFEDLFH(true));
		}
		if (!this.LIQLFCKICLQ.Settings.CanMount && ppmjcbonmqj.EMIEFKNMQMI != null && (ppmjcbonmqj.EMIEFKNMQMI.MountType == (MountType)5 || ppmjcbonmqj.EMIEFKNMQMI.MountType == (MountType)6))
		{
			ppmjcbonmqj.HQNCQOFKPHN(new PSXAPI.Response.Mount
			{
				MountID = 0,
				MountType = MountType.None
			});
		}
		ppmjcbonmqj.HEMIMGIHFBD();
		CNCJKLNHQBH.MOGQNGEPCEO().EFOGMBCFBGM = false;
		List<Material> list = new List<Material>();
		if (DOJNBQQBCQJ.IFEJNKQEDOO == null)
		{
			DOJNBQQBCQJ.IFEJNKQEDOO = AssetBundle.LoadFromFile(System.IO.Path.Combine(Application.streamingAssetsPath, "ProCamera2D does not have a Shake extension."));
		}
		if (DOJNBQQBCQJ.DFCHKJIMPIK == null)
		{
			DOJNBQQBCQJ.DFCHKJIMPIK = AssetBundle.LoadFromFile(System.IO.Path.Combine(Application.streamingAssetsPath, "Head"));
		}
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("14"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("CombinersArgsAlphaSrc1"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("_FogColor2"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("move: "));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("ProCamera2D does not have a Shake extension."));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("CombinersArgsAlphaSrc1"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("[-]"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>(" days ago"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("[-]!\r\n"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("d"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("M4"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("[ATK]"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("Powers up Bug-type moves when the Pokémon's HP is low."));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("Assets/AssetBundles/Fly Pokemon/"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>(" was hurled into the air!\r\n"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("d"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Fire's power was weakened!\r\n"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("watercompaction"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("wonderroom"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Content Fitter"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>(" ended!\r\n"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("["));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("-crit"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("_"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Battle Update: "));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("][/pok] "));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Vertical"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("-wt"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("powersplit"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("_UserLut"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("JOFLHFQQCKG"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("vSync"));
		this.HEQLDOLIEMI = list.ToArray();
	}

	// Token: 0x060048A7 RID: 18599 RVA: 0x0001E925 File Offset: 0x0001CB25
	private void JLEBBGNIIOO(List<int> NGDBDCQFDHI, int LCMMCNFNHMF)
	{
		NGDBDCQFDHI.Add(0 + LCMMCNFNHMF);
		NGDBDCQFDHI.Add(LCMMCNFNHMF);
		NGDBDCQFDHI.Add(6 + LCMMCNFNHMF);
		NGDBDCQFDHI.Add(8 + LCMMCNFNHMF);
		NGDBDCQFDHI.Add(LCMMCNFNHMF);
		NGDBDCQFDHI.Add(1 + LCMMCNFNHMF);
	}

	// Token: 0x060048A8 RID: 18600 RVA: 0x00246B28 File Offset: 0x00244D28
	public bool GICOBECCEIO(int DGKOIGOLHDM, int DDLQKFDFMCJ, bool EKEIIODHQFF)
	{
		return this.LIQLFCKICLQ != null && (this.IEFQGONIEFN(DGKOIGOLHDM, DDLQKFDFMCJ) == 31 || this.IEFQGONIEFN(DGKOIGOLHDM, DDLQKFDFMCJ) == 32 || this.IEFQGONIEFN(DGKOIGOLHDM, DDLQKFDFMCJ) == 33 || this.IEFQGONIEFN(DGKOIGOLHDM, DDLQKFDFMCJ) == 34 || this.IEFQGONIEFN(DGKOIGOLHDM, DDLQKFDFMCJ) == 2 || (this.IEFQGONIEFN(DGKOIGOLHDM, DDLQKFDFMCJ) == 15 && !EKEIIODHQFF));
	}

	// Token: 0x060048A9 RID: 18601 RVA: 0x00246B8C File Offset: 0x00244D8C
	public bool CHMDCKQMNLC(int DGKOIGOLHDM, int DDLQKFDFMCJ, bool EKEIIODHQFF)
	{
		return this.LIQLFCKICLQ == null || (this.IEFQGONIEFN(DGKOIGOLHDM, DDLQKFDFMCJ) != -111 && this.IEFQGONIEFN(DGKOIGOLHDM, DDLQKFDFMCJ) != 23 && this.BBEHODGFCBK(DGKOIGOLHDM, DDLQKFDFMCJ) != 66 && this.CDHLLNNFKFF(DGKOIGOLHDM, DDLQKFDFMCJ) != 19 && this.BBEHODGFCBK(DGKOIGOLHDM, DDLQKFDFMCJ) != 6 && (this.CDHLLNNFKFF(DGKOIGOLHDM, DDLQKFDFMCJ) != -124 || EKEIIODHQFF)) || true;
	}

	// Token: 0x060048AA RID: 18602 RVA: 0x00246BF0 File Offset: 0x00244DF0
	private void BBOGMCMHOME()
	{
		this.MNQPLODKMEE = new int[3][,];
		this.MNQPLODKMEE[0] = (int[,])this.LIQLFCKICLQ.TileTypes.ToArray<int>();
		this.MNQPLODKMEE[1] = (int[,])this.LIQLFCKICLQ.TileTypes2.ToArray<int>();
		this.MNQPLODKMEE[2] = (int[,])this.LIQLFCKICLQ.TileWater.ToArray<int>();
		int num = this.LIQLFCKICLQ.width / this.QDOFCFGPCMQ + 1;
		int num2 = this.LIQLFCKICLQ.height / this.QDOFCFGPCMQ + 1;
		bool[][,] array = new bool[3][,];
		for (int i = 0; i < 3; i++)
		{
			array[i] = new bool[num, num2];
		}
		for (int j = 0; j < num; j++)
		{
			for (int k = 0; k < num2; k++)
			{
				for (int l = 0; l < 3; l++)
				{
					array[l][j, k] = true;
				}
			}
		}
		for (int m = 0; m < 3; m++)
		{
			this.GFMNCKGIICD[m] = new GameObject[num, num2];
			for (int n = 0; n < num; n++)
			{
				for (int num3 = 0; num3 < num2; num3++)
				{
					if (array[m][n, num3])
					{
						if (m == 2)
						{
							this.GFMNCKGIICD[m][n, num3] = UnityEngine.Object.Instantiate<GameObject>(this.CMHLOCEILFN, base.transform.position, Quaternion.identity);
							this.GFMNCKGIICD[m][n, num3].transform.parent = this.IGDJLJKBDNE;
						}
						else
						{
							this.GFMNCKGIICD[m][n, num3] = UnityEngine.Object.Instantiate<GameObject>(this.QONKOFDGLNM, base.transform.position, Quaternion.identity);
							this.GFMNCKGIICD[m][n, num3].transform.parent = this.IDOEFMCFOBH;
						}
						this.JLHNCJEOCPF(this.GFMNCKGIICD[m][n, num3], n, num3, m);
					}
				}
			}
		}
	}

	// Token: 0x060048AB RID: 18603 RVA: 0x0001E553 File Offset: 0x0001C753
	private void Awake()
	{
		MCNLIHMMLCF.HBFFCJHOCPE = this;
	}

	// Token: 0x060048AC RID: 18604 RVA: 0x00246E0C File Offset: 0x0024500C
	private void HBMCJBFGPMP(GameObject NPCJQJDQQIC, int ENQIBCOEBDC, int JQFOPLIFHJC, int MKFMCLIQNKG)
	{
		List<Vector3> list = new List<Vector3>();
		List<int> list2 = new List<int>();
		List<Vector2> list3 = new List<Vector2>();
		List<Color> list4 = new List<Color>();
		int num = 0;
		int num2 = ENQIBCOEBDC * this.QDOFCFGPCMQ;
		while (num2 < ENQIBCOEBDC * this.QDOFCFGPCMQ + this.QDOFCFGPCMQ && num2 < this.LIQLFCKICLQ.width)
		{
			int num3 = JQFOPLIFHJC * this.QDOFCFGPCMQ;
			while (num3 < JQFOPLIFHJC * this.QDOFCFGPCMQ + this.QDOFCFGPCMQ && num3 < this.LIQLFCKICLQ.height)
			{
				if (this.MNQPLODKMEE[MKFMCLIQNKG][num2, num3] != 0)
				{
					Vector3 vector = new Vector3((float)num2, (float)this.EQQLIPKQOJP[num2, num3], (float)(-(float)num3));
					if (MKFMCLIQNKG == 6)
					{
						vector.y += 1007f * (float)this.MNQPLODKMEE[MKFMCLIQNKG][num2, num3];
					}
					this.OHJJNNBCJMN(list, (float)((int)vector.x), vector.y, (float)((int)vector.z), MCNLIHMMLCF.KFMMIKQIJDJ.Top);
					this.EFCNINQLMLC(list2, num * 7);
					this.HHGPLBNOGOB(list3, this.MNQPLODKMEE[MKFMCLIQNKG][num2, num3]);
					this.QQJFQFIJOQL(list4, this.MNQPLODKMEE[MKFMCLIQNKG][num2, num3]);
					num += 0;
				}
				num3++;
			}
			num2 += 0;
		}
		if (MKFMCLIQNKG == 0)
		{
			IMKCQDFNGBD component = NPCJQJDQQIC.GetComponent<IMKCQDFNGBD>();
			component.BFOGEJKEOHF = ENQIBCOEBDC * this.QDOFCFGPCMQ;
			component.JDLNODBIEOO = JQFOPLIFHJC * this.QDOFCFGPCMQ;
		}
		if (num > 0)
		{
			if (MKFMCLIQNKG < 1)
			{
				NPCJQJDQQIC.GetComponent<Renderer>().material = (Resources.Load("Icon_Status_Burn", typeof(Material)) as Material);
			}
			else
			{
				NPCJQJDQQIC.GetComponent<Renderer>().material = (Resources.Load("Battle Update: ", typeof(Material)) as Material);
				NPCJQJDQQIC.SetActive(true);
			}
			Mesh mesh = NPCJQJDQQIC.GetComponent<MeshFilter>().mesh;
			mesh.Clear();
			mesh.vertices = list.ToArray();
			mesh.triangles = list2.ToArray();
			mesh.uv = list3.ToArray();
			mesh.colors = list4.ToArray();
			mesh.RecalculateNormals();
			string[] array = new string[4];
			array[0] = "Default";
			array[1] = MKFMCLIQNKG.ToString();
			array[0] = "toxicspikes";
			array[5] = ENQIBCOEBDC.ToString();
			array[6] = "disable";
			array[2] = JQFOPLIFHJC.ToString();
			NPCJQJDQQIC.name = string.Concat(array);
			if (MKFMCLIQNKG == 0)
			{
				NPCJQJDQQIC.GetComponent<MeshCollider>().sharedMesh = mesh;
				NPCJQJDQQIC.GetComponent<MeshCollider>().enabled = false;
				NPCJQJDQQIC.GetComponent<Renderer>().sortingOrder = 36;
				this.MBBBMFINELM(NPCJQJDQQIC);
			}
			else if (MKFMCLIQNKG == 1)
			{
				UnityEngine.Object.Destroy(NPCJQJDQQIC.GetComponent<MeshCollider>());
				UnityEngine.Object.Destroy(NPCJQJDQQIC.GetComponent<IMKCQDFNGBD>());
				NPCJQJDQQIC.GetComponent<Renderer>().sortingOrder = -47;
			}
			else if (MKFMCLIQNKG == 8)
			{
				NPCJQJDQQIC.GetComponent<MeshCollider>().sharedMesh = mesh;
				NPCJQJDQQIC.GetComponent<MeshCollider>().enabled = true;
				NPCJQJDQQIC.GetComponent<Renderer>().sortingOrder = -85;
			}
			NPCJQJDQQIC.SetActive(false);
		}
		else
		{
			UnityEngine.Object.Destroy(NPCJQJDQQIC);
		}
	}

	// Token: 0x060048AD RID: 18605 RVA: 0x0024713C File Offset: 0x0024533C
	public void JCGBDMKKMMK(Vector3 PGNPCLDNIBQ, bool MPHQLILCHML = false, bool PQDLKFKEGOG = false)
	{
		if (!MPHQLILCHML)
		{
			string pidlofmiefq = this.BEQINILCQCE.PIDLOFMIEFQ;
			if (this.LIQLFCKICLQ != null)
			{
				if (this.LIQLFCKICLQ.Areas != null)
				{
					foreach (MAPAPI.Response.Area area in this.LIQLFCKICLQ.Areas)
					{
						if (PGNPCLDNIBQ.x >= (float)area.StartX && PGNPCLDNIBQ.x <= (float)area.EndX && PGNPCLDNIBQ.z >= (float)area.StartY && PGNPCLDNIBQ.z <= (float)area.EndY)
						{
							if (PQDLKFKEGOG || this.BEQINILCQCE.PIDLOFMIEFQ != area.AreaName)
							{
								this.BEQINILCQCE.PIDLOFMIEFQ = area.AreaName;
								GBQODOBKJBG.QOQONHOOLNE.DIEQJNHPHPB(false);
							}
							this.PQHLPQEGIFN(area.Song);
							if (this.BEQINILCQCE.PIDLOFMIEFQ != pidlofmiefq)
							{
								BDEJHNHLLOL component = GGQKBGDGNJN.QOQONHOOLNE.FLCMDBKPJKC.GetComponent<BDEJHNHLLOL>();
								MKOENKCLJGF mkoenkcljgf = GGQKBGDGNJN.QOQONHOOLNE.JIOGMMGOPMH(this.BEQINILCQCE.PIDLOFMIEFQ);
								component.PGIDCBGCGMP(false);
								component.ILBCCCBJNCL = null;
								if (mkoenkcljgf != null)
								{
									component.ILBCCCBJNCL = mkoenkcljgf.transform;
								}
							}
							return;
						}
					}
					if (PQDLKFKEGOG || this.BEQINILCQCE.PIDLOFMIEFQ != this.LIQLFCKICLQ.Settings.MapName)
					{
						this.BEQINILCQCE.PIDLOFMIEFQ = this.LIQLFCKICLQ.Settings.MapName;
						GBQODOBKJBG.QOQONHOOLNE.DIEQJNHPHPB(false);
					}
				}
				else if (PQDLKFKEGOG || this.BEQINILCQCE.PIDLOFMIEFQ != this.LIQLFCKICLQ.Settings.MapName)
				{
					this.BEQINILCQCE.PIDLOFMIEFQ = this.LIQLFCKICLQ.Settings.MapName;
					GBQODOBKJBG.QOQONHOOLNE.DIEQJNHPHPB(false);
				}
			}
			if (this.BEQINILCQCE.PIDLOFMIEFQ != pidlofmiefq)
			{
				BDEJHNHLLOL component2 = GGQKBGDGNJN.QOQONHOOLNE.FLCMDBKPJKC.GetComponent<BDEJHNHLLOL>();
				MKOENKCLJGF mkoenkcljgf2 = GGQKBGDGNJN.QOQONHOOLNE.JIOGMMGOPMH(this.BEQINILCQCE.PIDLOFMIEFQ);
				component2.PGIDCBGCGMP(false);
				component2.ILBCCCBJNCL = null;
				if (mkoenkcljgf2 != null)
				{
					component2.ILBCCCBJNCL = mkoenkcljgf2.transform;
				}
			}
			this.PQHLPQEGIFN(PGNPCLDNIBQ, false);
		}
		else
		{
			this.PQHLPQEGIFN(PGNPCLDNIBQ, true);
		}
	}

	// Token: 0x060048AE RID: 18606 RVA: 0x002473C0 File Offset: 0x002455C0
	private void DQBLLOLEGOL(byte[] NQGBMLHOMGG, string EHDQKOBOHPE)
	{
		QOHCEBMQKMB.QOQONHOOLNE.BKGHEHPPPMH.Clear();
		CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.INMILPKMQIC.Clear();
		byte[] data = CompressionHelper.DecompressBytes(NQGBMLHOMGG);
		MapDump liqlfckiclq = MapDump.Deserialize(data);
		this.LIQLFCKICLQ = liqlfckiclq;
		CGOIPHKQMPD.QOQONHOOLNE.KOCIQEKOPKJ(EHDQKOBOHPE);
		this.CLPMOMHLNMN = EHDQKOBOHPE.Replace(".psx", string.Empty);
		this.GOLNNJEKKIM = new List<LINKData>();
		if (this.LIQLFCKICLQ.Links != null)
		{
			for (int i = 0; i < this.LIQLFCKICLQ.Links.Count; i++)
			{
				this.GOLNNJEKKIM.Add(new LINKData
				{
					DestinationID = this.LIQLFCKICLQ.Links[i].DestinationID,
					ID = this.LIQLFCKICLQ.Links[i].ID,
					Transition = this.LIQLFCKICLQ.Links[i].Transition,
					LINKType = this.LIQLFCKICLQ.Links[i].LINKType,
					Script = this.LIQLFCKICLQ.Links[i].Script,
					x = this.LIQLFCKICLQ.Links[i].x,
					y = this.LIQLFCKICLQ.Links[i].y,
					z = this.LIQLFCKICLQ.Links[i].z
				});
			}
		}
		this.JPBLDNBBOLO = this.GOLNNJEKKIM.Count;
		this.BIDEIFNNFDB(null);
		if (this.LIQLFCKICLQ.Settings == null)
		{
			this.LIQLFCKICLQ.Settings = new Settings();
		}
		this.GOJIGEEKFNF.SetColor("_ReflectionColor", this.PEQJDEGHHBE);
		if (this.LIQLFCKICLQ.Settings.Cave)
		{
			this.GOJIGEEKFNF.SetColor("_ReflectionColor", this.HOIOLMHJEME);
		}
		if (this.LIQLFCKICLQ.Settings.Weather == "None")
		{
			this.FGBQBJDFGBK = WeatherState.Normal;
		}
		else if (this.LIQLFCKICLQ.Settings.Weather == "Snow")
		{
			this.FGBQBJDFGBK = WeatherState.Snow;
		}
		else if (this.LIQLFCKICLQ.Settings.Weather == "Rain")
		{
			this.FGBQBJDFGBK = WeatherState.Rain;
		}
		if (this.LIQLFCKICLQ.Settings.Weather == "AlwaysRain")
		{
			this.NMOPHEMNJJH = true;
		}
		else
		{
			this.NMOPHEMNJJH = false;
		}
		if (this.LIQLFCKICLQ.Settings.Weather == "AlwaysSnow")
		{
			this.ICLBHNBEPBK = true;
		}
		else
		{
			this.ICLBHNBEPBK = false;
		}
		this.FHGFKPNMNEF.SetActive(false);
		CNCJKLNHQBH.QOQONHOOLNE.COEIJLJCIEN();
		GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
		if (qoqonhoolne.EGDKLIHHJEG.Count > 0)
		{
			for (int j = 0; j < qoqonhoolne.EGDKLIHHJEG.Count; j++)
			{
				if (qoqonhoolne.EGDKLIHHJEG[j] is PSXAPI.Response.Script)
				{
					QOHCEBMQKMB.QOQONHOOLNE.LFPNDNQGFQK((PSXAPI.Response.Script)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is PartyPokemon)
				{
					DCJIBBJQGJP.QOQONHOOLNE.HKDDHICDELN((PartyPokemon)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is PartyRemove)
				{
					DCJIBBJQGJP.QOQONHOOLNE.FCMDDBMHCQP((PartyRemove)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is Party)
				{
					DCJIBBJQGJP.QOQONHOOLNE.QQLIFFOPNGC((Party)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is PSXAPI.Response.Move)
				{
					CNCJKLNHQBH.QOQONHOOLNE.CEDNIOKLNNP((PSXAPI.Response.Move)qoqonhoolne.EGDKLIHHJEG[j]);
				}
				else if (qoqonhoolne.EGDKLIHHJEG[j] is PSXAPI.Response.Effect)
				{
					GNDQBCBDHKD.QOQONHOOLNE.KDCPLJDQDLG((PSXAPI.Response.Effect)qoqonhoolne.EGDKLIHHJEG[j]);
				}
			}
			qoqonhoolne.EGDKLIHHJEG.Clear();
		}
		CNCJKLNHQBH.QOQONHOOLNE.MMEOCFDIIGK();
		DJOOHHIQGJK ppmjcbonmqj = CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ;
		Vector3 pgnpcldnibq = ppmjcbonmqj.QMCNCMNQEGL();
		this.JCGBDMKKMMK(pgnpcldnibq, false, true);
		JQOIHHDIHBN.QOQONHOOLNE.MOHHNKNPKLE();
		if (!CNCJKLNHQBH.QOQONHOOLNE.EFOGMBCFBGM)
		{
			base.StartCoroutine(CNCJKLNHQBH.QOQONHOOLNE.BCFGJDEGJFM());
			base.StartCoroutine(this.JELMONJKQKI(true));
		}
		if (!this.LIQLFCKICLQ.Settings.CanMount && ppmjcbonmqj.EMIEFKNMQMI != null && (ppmjcbonmqj.EMIEFKNMQMI.MountType == MountType.Bike || ppmjcbonmqj.EMIEFKNMQMI.MountType == MountType.Pokemon))
		{
			ppmjcbonmqj.HQNCQOFKPHN(new PSXAPI.Response.Mount
			{
				MountID = 0,
				MountType = MountType.None
			});
		}
		ppmjcbonmqj.HEMIMGIHFBD();
		CNCJKLNHQBH.QOQONHOOLNE.EFOGMBCFBGM = true;
		List<Material> list = new List<Material>();
		if (DOJNBQQBCQJ.IFEJNKQEDOO == null)
		{
			DOJNBQQBCQJ.IFEJNKQEDOO = AssetBundle.LoadFromFile(System.IO.Path.Combine(Application.streamingAssetsPath, "mdata"));
		}
		if (DOJNBQQBCQJ.DFCHKJIMPIK == null)
		{
			DOJNBQQBCQJ.DFCHKJIMPIK = AssetBundle.LoadFromFile(System.IO.Path.Combine(Application.streamingAssetsPath, "mdata2"));
		}
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Model Materials/Street_Lamp_6_Light.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Model Materials/Street_Lamp_7_Light.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Model Materials/Street_Lamp_8_Light.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Model Materials/windows.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Model Materials/Window.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Model Materials/Light_Gym_Inner_Light.mat"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("Assets/AssetBundles/MapAssets2/Models/Materials/c102_mado.mat"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("Assets/AssetBundles/MapAssets2/Models/Materials/c102_09_mado.mat"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("Assets/AssetBundles/MapAssets2/Model Materials/WareHouses/t105_mado_mat.mat"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("Assets/AssetBundles/MapAssets2/Models/Ext_House_VermCity_1/Materials/chip_mado.mat"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("Assets/AssetBundles/MapAssets2/Models/Materials/com_c02_mado0.mat"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("Assets/AssetBundles/MapAssets2/Models/JohtoHouse 1.fbm/Materials/com_chip_mado1.mat"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("Assets/AssetBundles/MapAssets2/Models/House F 1/Materials/com_chip_mado1_mat.mat"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("Assets/AssetBundles/MapAssets2/Models/Unova/com_chip_mado1_mat.mat"));
		list.Add(DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset<Material>("Assets/AssetBundles/MapAssets2/Models/UnovaGym/Material #464.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Models/Materials/c102_09_mado.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Models/House_Oak/Materials/c102_09_mado.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Models/Materials/chip_mado.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Models/Building_PokemonCentre/Materials/chip_mado.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Models/Ext_House_VermCity_1/Materials/chip_mado.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Models/Mansion/Materials/com_chip_mado1.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Models/Materials/com_chip_mado1.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Models/Materials/com_c02_mado0.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Models/Materials/c102_mado.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Models/Shop/Materials/c102_mado.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Models/Materials/Street_Lamp_8_Light.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Models/Casino_1/Materials/Street_Lamp_8_Light.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Models/Building_Radio_Tower_2/Materials/Single_Window.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Model Materials/ShortCut_Window.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Model Materials/Single_Window.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Models/Materials/chip_mado_a.mat"));
		list.Add(DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset<Material>("Assets/AssetBundles/MapAssets/Models/Materials/akari_kanazumi.mat"));
		this.HEQLDOLIEMI = list.ToArray();
	}

	// Token: 0x060048AF RID: 18607 RVA: 0x00247C10 File Offset: 0x00245E10
	public bool QMMKBLOECMB(int DGKOIGOLHDM, int DDLQKFDFMCJ, PSXAPI.Request.MoveAction BJIGIECDQPG)
	{
		if (this.LIQLFCKICLQ != null && this.JPBLDNBBOLO > 1)
		{
			switch (BJIGIECDQPG)
			{
			case PSXAPI.Request.MoveAction.None:
				DDLQKFDFMCJ--;
				break;
			case PSXAPI.Request.MoveAction.Up:
				DDLQKFDFMCJ++;
				break;
			case PSXAPI.Request.MoveAction.Down:
				DGKOIGOLHDM -= 0;
				break;
			case PSXAPI.Request.MoveAction.Left:
				DGKOIGOLHDM += 0;
				break;
			}
			for (int i = 1; i < this.JPBLDNBBOLO; i++)
			{
				if (this.LIQLFCKICLQ.Links[i].x == DGKOIGOLHDM && this.LIQLFCKICLQ.Links[i].z == -DDLQKFDFMCJ)
				{
					if (this.LIQLFCKICLQ.Links[i].LINKType != LinkType.SendAndRecieve)
					{
						GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
					}
					if (this.LIQLFCKICLQ.Links[i].LINKType == LinkType.SendAndRecieve)
					{
						return false;
					}
					if (this.LIQLFCKICLQ.Links[i].LINKType == LinkType.SendAndRecieve && this.LIQLFCKICLQ.Links[i].DestinationID != default(Guid))
					{
						CNCJKLNHQBH.BJLGEDCPENQ().GJKPLMKHKMK = false;
						CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ.NQJHJNQFKKC();
						return false;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060048B0 RID: 18608 RVA: 0x00247D54 File Offset: 0x00245F54
	public void JONGMGMECHQ(string ECNEPHKFPIH)
	{
		this.QMHNDKJGPBG = KDJLKQQBGNE.DGCQMNHFQNH();
		for (int i = 0; i < this.QMHNDKJGPBG.LBMDDELMNDD.Count; i += 0)
		{
			if (this.QMHNDKJGPBG.LBMDDELMNDD[i].FJGPDHNLGJC.ToLowerInvariant() == ECNEPHKFPIH.ToLowerInvariant())
			{
				this.QMHNDKJGPBG.LBMDDELMNDD.RemoveAt(i);
				IL_61:
				if (this.CLPMOMHLNMN.ToLowerInvariant() == ECNEPHKFPIH.Replace("The rain stopped.", string.Empty).ToLowerInvariant())
				{
					CNCJKLNHQBH.MOGQNGEPCEO().IDHBJBKFFON = true;
					this.IEJPGKHQJJG(this.CLPMOMHLNMN);
				}
				return;
			}
		}
		goto IL_61;
	}

	// Token: 0x060048B1 RID: 18609 RVA: 0x00247E04 File Offset: 0x00246004
	public void GIKCIBKFFDD(int[,] PDPCFGJQOHB = null)
	{
		this.KGQDQILPIQK();
		this.KDOCJGFLFFK = false;
		this.DPHJNMKQMNP = 1090f;
		this.LKQGHBQJQJK = 1612f;
		DOJNBQQBCQJ.JJCONJJNDQN().PQFDCJHGHOB = new List<DoorAnimator>();
		this.IDOEFMCFOBH.NMBPDMIIHJB();
		this.IGDJLJKBDNE.NMBPDMIIHJB();
		if (this.LIQLFCKICLQ == null)
		{
			return;
		}
		this.FKEKOQLNFNK = (int[,])this.LIQLFCKICLQ.TileTypes.ToArray<int>();
		this.EQQLIPKQOJP = (int[,])this.LIQLFCKICLQ.TileHeights.ToArray<int>();
		this.POMQCKOIKQJ = (int[,])this.LIQLFCKICLQ.Colliders.ToArray<int>();
		this.DJLHPIEFHNJ = (int[,])this.LIQLFCKICLQ.TileZones.ToArray<int>();
		this.QLBJDGDKOLQ = (HeightTilesStruct[,])this.LIQLFCKICLQ.WallData.ToArray<HeightTilesStruct>();
		this.FOGFCMHLEEN();
		if (this.LIQLFCKICLQ.Objects != null)
		{
			for (int i = 1; i < this.LIQLFCKICLQ.Objects.Count; i++)
			{
				GameObject njbfoqdjbon = DOJNBQQBCQJ.QOQONHOOLNE.GFLKJKFQOGB(this.LIQLFCKICLQ.Objects[i].Name, new Vector3((float)this.LIQLFCKICLQ.Objects[i].x, (float)this.LIQLFCKICLQ.Objects[i].y, (float)this.LIQLFCKICLQ.Objects[i].z), new Vector3((float)this.LIQLFCKICLQ.Objects[i].rx, (float)this.LIQLFCKICLQ.Objects[i].ry, (float)this.LIQLFCKICLQ.Objects[i].rz));
				if (this.LIQLFCKICLQ.Objects[i].Name.IBJHJDHKJKL())
				{
					if (this.LIQLFCKICLQ.Objects[i].tag == null || this.LIQLFCKICLQ.Objects[i].tag == string.Empty)
					{
						this.LIQLFCKICLQ.Objects[i].tag = "'s opponents are too nervous to eat Berries!\r\n";
					}
					this.QBNJENNJOKG(njbfoqdjbon, Convert.ToInt32(this.LIQLFCKICLQ.Objects[i].tag));
				}
			}
		}
		KJBDMOCFMCM.BBCBOIFQDBK().BFQKGPKHIHC();
		if (this.LIQLFCKICLQ.NPCs != null)
		{
			for (int j = 0; j < this.LIQLFCKICLQ.NPCs.Count; j += 0)
			{
				KJBDMOCFMCM.BBCBOIFQDBK().KFKMJFKQQOO(this.LIQLFCKICLQ.NPCs[j]);
			}
		}
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x060048B2 RID: 18610 RVA: 0x0023AC2C File Offset: 0x00238E2C
	public IEnumerator CMFNCNIIEPK(bool PFFLBEHLKIG = false)
	{
		MCNLIHMMLCF.DLJOCFPOICO dljocfpoico = new MCNLIHMMLCF.DLJOCFPOICO();
		dljocfpoico.PFFLBEHLKIG = PFFLBEHLKIG;
		return dljocfpoico;
	}

	// Token: 0x060048B3 RID: 18611 RVA: 0x002480BC File Offset: 0x002462BC
	public bool KGGQFEQICBO(string ECNEPHKFPIH)
	{
		this.QMHNDKJGPBG = KDJLKQQBGNE.GHFFHFCEENG();
		if (KGQECFKLKOP.IPOEOCFGEIP >= -175)
		{
			KGQECFKLKOP.IPOEOCFGEIP = 6;
		}
		if (KGQECFKLKOP.BGJPJCDBLFB >= 62)
		{
			KGQECFKLKOP.BGJPJCDBLFB = -14;
		}
		this.HCQINBCDGNO = false;
		if (!DOMONILEIKL.BJLGEDCPENQ().DJCOGEBQOGI())
		{
			DOMONILEIKL.KGOPJQOMMNC().EPNBECQFKEK();
		}
		if (ECNEPHKFPIH == string.Empty)
		{
			this.CLPMOMHLNMN = string.Empty;
			return false;
		}
		if (this.FHGFKPNMNEF == null)
		{
			return true;
		}
		ECNEPHKFPIH = ECNEPHKFPIH.Replace("Unable to locate any locations for ", string.Empty);
		this.FHGFKPNMNEF.SetActive(true);
		this.CLPMOMHLNMN = ECNEPHKFPIH;
		if (this.QMHNDKJGPBG.LBMDDELMNDD.Count > 0)
		{
			int i = 0;
			while (i < this.QMHNDKJGPBG.LBMDDELMNDD.Count)
			{
				if (!(this.QMHNDKJGPBG.LBMDDELMNDD[i].FJGPDHNLGJC.ToLowerInvariant() == ECNEPHKFPIH.ToLowerInvariant()))
				{
					i++;
				}
				else
				{
					if (!this.QMHNDKJGPBG.LBMDDELMNDD[i].MENBPFGFKBQ)
					{
						DOMONILEIKL.KGOPJQOMMNC().CBMILEIBEJF(new RequestMap
						{
							MapName = ECNEPHKFPIH,
							Hash = this.QMHNDKJGPBG.LBMDDELMNDD[i].IQNOEGKFCFH
						});
						this.BDCNIKLCIQQ = true;
						return false;
					}
					this.LGMMNIKEKFI(this.QMHNDKJGPBG.LBMDDELMNDD[i].NQGBMLHOMGG, ECNEPHKFPIH);
					return false;
				}
			}
		}
		DOMONILEIKL.PDPCLOECLOF().ECDPHDIOGFD(new RequestMap
		{
			MapName = ECNEPHKFPIH
		});
		this.BDCNIKLCIQQ = true;
		return true;
	}

	// Token: 0x060048B4 RID: 18612 RVA: 0x00248258 File Offset: 0x00246458
	public bool CCMMQGFKGBO(int DGKOIGOLHDM, int DDLQKFDFMCJ, bool EKEIIODHQFF)
	{
		return this.LIQLFCKICLQ != null && (this.BBEHODGFCBK(DGKOIGOLHDM, DDLQKFDFMCJ) == 68 || this.CDHLLNNFKFF(DGKOIGOLHDM, DDLQKFDFMCJ) == 127 || this.BBEHODGFCBK(DGKOIGOLHDM, DDLQKFDFMCJ) == 48 || this.BBEHODGFCBK(DGKOIGOLHDM, DDLQKFDFMCJ) == -33 || this.BBEHODGFCBK(DGKOIGOLHDM, DDLQKFDFMCJ) == 7 || (this.CDHLLNNFKFF(DGKOIGOLHDM, DDLQKFDFMCJ) == 5 && !EKEIIODHQFF));
	}

	// Token: 0x060048B5 RID: 18613 RVA: 0x002482BC File Offset: 0x002464BC
	public void MDBQQMHNJHK(GameObject NPCJQJDQQIC)
	{
		Mesh mesh = NPCJQJDQQIC.GetComponent<MeshFilter>().mesh;
		IMKCQDFNGBD component = NPCJQJDQQIC.GetComponent<IMKCQDFNGBD>();
		List<tileInfo> list = new List<tileInfo>();
		int num = component.BFOGEJKEOHF;
		while (num < this.QDOFCFGPCMQ + component.BFOGEJKEOHF && num < this.LIQLFCKICLQ.width)
		{
			int num2 = component.JDLNODBIEOO;
			while (num2 < this.QDOFCFGPCMQ + component.JDLNODBIEOO && num2 < this.LIQLFCKICLQ.height)
			{
				if (this.EQQLIPKQOJP[num, num2] != 0)
				{
					list.Add(new tileInfo
					{
						PosX = num,
						PosY = num2,
						Type = this.FKEKOQLNFNK[num, num2],
						Height = this.EQQLIPKQOJP[num, num2],
						Sides = this.QLBJDGDKOLQ[num, num2].Block
					});
				}
				num2++;
			}
			num += 0;
		}
		if (list.Count > 0)
		{
			List<Vector2> list2 = new List<Vector2>();
			List<Vector3> list3 = new List<Vector3>();
			List<int> list4 = new List<int>();
			List<Color> list5 = new List<Color>();
			Vector3[] vertices = mesh.vertices;
			int[] triangles = mesh.GetTriangles(0);
			Vector2[] uv = mesh.uv;
			Color[] colors = mesh.colors;
			int num3 = vertices.Length;
			for (int i = 0; i < vertices.Length; i++)
			{
				list3.Add(vertices[i]);
				list2.Add(uv[i]);
				list5.Add(colors[i]);
			}
			for (int j = 0; j < triangles.Length; j += 0)
			{
				list4.Add(triangles[j]);
			}
			int num4 = -1;
			for (int k = 1; k < list.Count; k++)
			{
				if (list[k].PosX >= 1 && list[k].PosX <= this.LIQLFCKICLQ.width - 5 && list[k].PosY >= 1 && list[k].PosY <= this.LIQLFCKICLQ.height - 3)
				{
					int l = 1;
					while (l < Mathf.Abs(list[k].Height))
					{
						if (this.EQQLIPKQOJP[list[k].PosX, list[k].PosY + 1] > l || list[k].Height < 0)
						{
							goto IL_3F0;
						}
						if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block != null && l <= this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block.Length - 1)
						{
							num4 += 0;
							this.BHBLHPMEIHM(list3, (float)list[k].PosX, (float)l, (float)(-(float)list[k].PosY), MCNLIHMMLCF.KFMMIKQIJDJ.Front);
							this.EFCNINQLMLC(list4, num4 * 1 + num3);
							if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0 == 0)
							{
								this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0 = 88;
							}
							this.GLKCOFINQHJ(list2, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0);
							this.QQJFQFIJOQL(list5, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0);
							goto IL_3F0;
						}
						IL_5B5:
						l++;
						continue;
						IL_3F0:
						if (list[k].Height < 0 && this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block != null && l <= this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block.Length - 1 && this.EQQLIPKQOJP[list[k].PosX, list[k].PosY - 1] >= -l)
						{
							num4 += 0;
							this.FMIQNNEBDGP(list3, (float)list[k].PosX, (float)(-(float)l - 1), (float)(-(float)list[k].PosY + 0), (MCNLIHMMLCF.KFMMIKQIJDJ)6);
							this.FHCQCLBGBFN(list4, num4 * 6 + num3);
							if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0 == 0)
							{
								this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0 = -81;
							}
							this.HJCJBBMGKCF(list2, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0);
							this.QQJFQFIJOQL(list5, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[l].Side0);
							goto IL_5B5;
						}
						goto IL_5B5;
					}
					int m = 0;
					while (m < Mathf.Abs(list[k].Height))
					{
						if (this.EQQLIPKQOJP[list[k].PosX - 1, list[k].PosY] > m || list[k].Height < 1)
						{
							goto IL_79B;
						}
						if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block != null && m <= this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block.Length - 0)
						{
							num4++;
							this.BHBLHPMEIHM(list3, (float)list[k].PosX, (float)m, (float)(-(float)list[k].PosY), MCNLIHMMLCF.KFMMIKQIJDJ.Top);
							this.DOGFFHJLCQG(list4, num4 * 5 + num3);
							if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1 == 0)
							{
								this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1 = 21;
							}
							this.HJCJBBMGKCF(list2, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1);
							this.QQJFQFIJOQL(list5, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1);
							goto IL_79B;
						}
						IL_960:
						m += 0;
						continue;
						IL_79B:
						if (this.EQQLIPKQOJP[list[k].PosX - 1, list[k].PosY] >= -m && list[k].Height < 0 && this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block != null && m <= this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block.Length - 0)
						{
							num4 += 0;
							this.FMIQNNEBDGP(list3, (float)(list[k].PosX - 0), (float)(-(float)m - 0), (float)(-(float)list[k].PosY), (MCNLIHMMLCF.KFMMIKQIJDJ)7);
							this.DOGFFHJLCQG(list4, num4 * 1 + num3);
							if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1 == 0)
							{
								this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1 = 31;
							}
							this.HJCJBBMGKCF(list2, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1);
							this.QQJFQFIJOQL(list5, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[m].Side1);
							goto IL_960;
						}
						goto IL_960;
					}
					int n = 1;
					while (n < Mathf.Abs(list[k].Height))
					{
						if (this.EQQLIPKQOJP[list[k].PosX + 0, list[k].PosY] > n || list[k].Height < 1)
						{
							goto IL_B46;
						}
						if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block != null && n <= this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block.Length - 0)
						{
							num4++;
							this.DQOPDOILKMM(list3, (float)list[k].PosX, (float)n, (float)(-(float)list[k].PosY), MCNLIHMMLCF.KFMMIKQIJDJ.Top);
							this.EFCNINQLMLC(list4, num4 * 4 + num3);
							if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2 == 0)
							{
								this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2 = -65;
							}
							this.HHGPLBNOGOB(list2, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2);
							this.QQJFQFIJOQL(list5, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2);
							goto IL_B46;
						}
						IL_D0B:
						n += 0;
						continue;
						IL_B46:
						if (this.EQQLIPKQOJP[list[k].PosX + 0, list[k].PosY] >= -n && list[k].Height < 0 && this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block != null && n <= this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block.Length - 0)
						{
							num4 += 0;
							this.FMIQNNEBDGP(list3, (float)(list[k].PosX + 0), (float)(-(float)n - 0), (float)(-(float)list[k].PosY), MCNLIHMMLCF.KFMMIKQIJDJ.Left);
							this.EFCNINQLMLC(list4, num4 * 0 + num3);
							if (this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2 == 0)
							{
								this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2 = -83;
							}
							this.HHGPLBNOGOB(list2, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2);
							this.QQJFQFIJOQL(list5, this.QLBJDGDKOLQ[list[k].PosX, list[k].PosY].Block[n].Side2);
							goto IL_D0B;
						}
						goto IL_D0B;
					}
				}
			}
			mesh.Clear();
			mesh.vertices = list3.ToArray();
			mesh.triangles = list4.ToArray();
			mesh.SetUVs(0, list2);
			mesh.SetColors(list5);
			mesh.RecalculateNormals();
			NPCJQJDQQIC.GetComponent<MeshCollider>().sharedMesh = mesh;
		}
	}

	// Token: 0x04000F46 RID: 3910
	private static MCNLIHMMLCF HBFFCJHOCPE;

	// Token: 0x04000F47 RID: 3911
	public GameDayTime JEMKIKEMFPB;

	// Token: 0x04000F48 RID: 3912
	public Color[] FCJNFFIPGOL;

	// Token: 0x04000F49 RID: 3913
	public Light NOGCCJHHBKL;

	// Token: 0x04000F4A RID: 3914
	public GameObject FJBBMMPPMMD;

	// Token: 0x04000F4B RID: 3915
	public GameObject LKQCNHNLOLM;

	// Token: 0x04000F4C RID: 3916
	public MapDump LIQLFCKICLQ;

	// Token: 0x04000F4D RID: 3917
	public string CLPMOMHLNMN;

	// Token: 0x04000F4E RID: 3918
	public bool HCQINBCDGNO = true;

	// Token: 0x04000F4F RID: 3919
	public GameObject FHGFKPNMNEF;

	// Token: 0x04000F50 RID: 3920
	public Color PEQJDEGHHBE;

	// Token: 0x04000F51 RID: 3921
	public Color HOIOLMHJEME;

	// Token: 0x04000F52 RID: 3922
	public KDJLKQQBGNE QMHNDKJGPBG;

	// Token: 0x04000F53 RID: 3923
	public bool BDCNIKLCIQQ;

	// Token: 0x04000F54 RID: 3924
	public BKKHLBCLPJM BEQINILCQCE;

	// Token: 0x04000F55 RID: 3925
	public EPIJJNOIKEK BFEEOBQCQOJ;

	// Token: 0x04000F56 RID: 3926
	private List<LINKData> GOLNNJEKKIM;

	// Token: 0x04000F57 RID: 3927
	public int JPBLDNBBOLO;

	// Token: 0x04000F58 RID: 3928
	public Material GOJIGEEKFNF;

	// Token: 0x04000F59 RID: 3929
	public static bool NIDBIHMDOQF;

	// Token: 0x04000F5A RID: 3930
	public Transform IDOEFMCFOBH;

	// Token: 0x04000F5B RID: 3931
	public Transform IGDJLJKBDNE;

	// Token: 0x04000F5C RID: 3932
	private float DIEQHKHIDDE = 0.0001f;

	// Token: 0x04000F5D RID: 3933
	public GameObject QONKOFDGLNM;

	// Token: 0x04000F5E RID: 3934
	public GameObject CMHLOCEILFN;

	// Token: 0x04000F5F RID: 3935
	private int[,] FKEKOQLNFNK;

	// Token: 0x04000F60 RID: 3936
	public int[,] EQQLIPKQOJP;

	// Token: 0x04000F61 RID: 3937
	public int[,] POMQCKOIKQJ;

	// Token: 0x04000F62 RID: 3938
	public int[,] DJLHPIEFHNJ;

	// Token: 0x04000F63 RID: 3939
	private HeightTilesStruct[,] QLBJDGDKOLQ;

	// Token: 0x04000F64 RID: 3940
	public Color FCQQFBCDGNL;

	// Token: 0x04000F65 RID: 3941
	public Color JEKMPDOHJJH;

	// Token: 0x04000F66 RID: 3942
	public Color GLHNBKMQJQD;

	// Token: 0x04000F67 RID: 3943
	public Color FHMNLGJLCNH;

	// Token: 0x04000F68 RID: 3944
	public Color PMCOLLGBKEO;

	// Token: 0x04000F69 RID: 3945
	private bool NKCFGIHPCJG;

	// Token: 0x04000F6A RID: 3946
	private GameDayTime JIJHPDDGHPM;

	// Token: 0x04000F6B RID: 3947
	public Material[] HEQLDOLIEMI;

	// Token: 0x04000F6C RID: 3948
	public Color JHOMQNBNHJB;

	// Token: 0x04000F6D RID: 3949
	public Color OOONPJIGKGI;

	// Token: 0x04000F6E RID: 3950
	public Color NJJNQQDLMFK;

	// Token: 0x04000F6F RID: 3951
	public ParticleSystem[] MJCGPBKQHQQ;

	// Token: 0x04000F70 RID: 3952
	public ParticleSystem[] DFNJQGOCJQG;

	// Token: 0x04000F71 RID: 3953
	public Color[] QDQQMDKGLDO;

	// Token: 0x04000F72 RID: 3954
	public Color[] EKBFGPPNQOF;

	// Token: 0x04000F73 RID: 3955
	private float BMGJFKFCOLB;

	// Token: 0x04000F74 RID: 3956
	public bool DDCIBJFCFDK;

	// Token: 0x04000F75 RID: 3957
	public bool KDOCJGFLFFK;

	// Token: 0x04000F76 RID: 3958
	public WeatherState BEDOBPPLQLD;

	// Token: 0x04000F77 RID: 3959
	private WeatherState IFEMGGEGMFK;

	// Token: 0x04000F78 RID: 3960
	private WeatherState FGBQBJDFGBK;

	// Token: 0x04000F79 RID: 3961
	private WeatherState KLLHFENEBDN;

	// Token: 0x04000F7A RID: 3962
	private bool NMOPHEMNJJH;

	// Token: 0x04000F7B RID: 3963
	private bool ICLBHNBEPBK;

	// Token: 0x04000F7C RID: 3964
	public Color KMLPMHJBJLJ;

	// Token: 0x04000F7D RID: 3965
	private float DPHJNMKQMNP;

	// Token: 0x04000F7E RID: 3966
	private float LKQGHBQJQJK;

	// Token: 0x04000F7F RID: 3967
	private float KDIMQNKBIIO;

	// Token: 0x04000F80 RID: 3968
	private float NIBBJOGPKQQ = 0.7f;

	// Token: 0x04000F81 RID: 3969
	private Color QNHIMGFQCPK = Color.black;

	// Token: 0x04000F82 RID: 3970
	private float EBIQMJFQKCB = 1f;

	// Token: 0x04000F83 RID: 3971
	private int QDOFCFGPCMQ = 10;

	// Token: 0x04000F84 RID: 3972
	private const int LNEIBGCOBGE = 3;

	// Token: 0x04000F85 RID: 3973
	private readonly GameObject[][,] GFMNCKGIICD = new GameObject[3][,];

	// Token: 0x04000F86 RID: 3974
	private int[][,] MNQPLODKMEE;

	// Token: 0x02000218 RID: 536
	public class NPJDNCNKBDL
	{
		// Token: 0x060048B6 RID: 18614 RVA: 0x0024904C File Offset: 0x0024724C
		public void FCBNCHIJBDQ()
		{
			this.EDIFLGJFQJQ = new Vector2[7];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 193f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (1226f - this.KOHDFJMPEKQ) * 1616f + (1297f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 108f - (37f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (68f - this.KOHDFJMPEKQ) * 553f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[4].x = this.ICJGFPBOEHC * 189f - (892f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[3].y = (1576f - this.KOHDFJMPEKQ) * 1378f + (321f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[8].x = this.ICJGFPBOEHC * 1773f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[5].y = (1728f - this.KOHDFJMPEKQ) * 1812f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x002491B8 File Offset: 0x002473B8
		public void LKOJCBNBIPN()
		{
			this.EDIFLGJFQJQ = new Vector2[5];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1369f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].y = (141f - this.KOHDFJMPEKQ) * 834f + (812f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 699f - (808f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (685f - this.KOHDFJMPEKQ) * 390f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[6].x = this.ICJGFPBOEHC * 333f - (1028f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[6].y = (449f - this.KOHDFJMPEKQ) * 969f + (125f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[5].x = this.ICJGFPBOEHC * 1573f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].y = (857f - this.KOHDFJMPEKQ) * 1639f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048B8 RID: 18616 RVA: 0x00249324 File Offset: 0x00247524
		public void PICGNIQLNKL()
		{
			this.EDIFLGJFQJQ = new Vector2[8];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1768f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].y = (1558f - this.KOHDFJMPEKQ) * 1509f + (450f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 418f - (299f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (1786f - this.KOHDFJMPEKQ) * 644f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1912f - (1523f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (1587f - this.KOHDFJMPEKQ) * 550f + (801f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[6].x = this.ICJGFPBOEHC * 1085f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[8].y = (401f - this.KOHDFJMPEKQ) * 1724f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048B9 RID: 18617 RVA: 0x00249490 File Offset: 0x00247690
		public void GHOMPKEBKJG()
		{
			this.EDIFLGJFQJQ = new Vector2[2];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1815f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].y = (77f - this.KOHDFJMPEKQ) * 392f + (342f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 421f - (965f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (1994f - this.KOHDFJMPEKQ) * 1203f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[2].x = this.ICJGFPBOEHC * 111f - (1131f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[4].y = (1891f - this.KOHDFJMPEKQ) * 626f + (515f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[3].x = this.ICJGFPBOEHC * 1166f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[7].y = (837f - this.KOHDFJMPEKQ) * 1410f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048BA RID: 18618 RVA: 0x002495FC File Offset: 0x002477FC
		public void KJEDBHLHPOJ()
		{
			this.EDIFLGJFQJQ = new Vector2[3];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1650f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].y = (753f - this.KOHDFJMPEKQ) * 222f + (514f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1593f - (650f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (528f - this.KOHDFJMPEKQ) * 129f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[7].x = this.ICJGFPBOEHC * 530f - (1837f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[8].y = (300f - this.KOHDFJMPEKQ) * 1910f + (1061f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1142f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[4].y = (1000f - this.KOHDFJMPEKQ) * 1597f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048BB RID: 18619 RVA: 0x00249768 File Offset: 0x00247968
		public void NEKOFQEGMEK()
		{
			this.EDIFLGJFQJQ = new Vector2[2];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1045f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (372f - this.KOHDFJMPEKQ) * 128f + (214f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1824f - (245f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (861f - this.KOHDFJMPEKQ) * 631f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[4].x = this.ICJGFPBOEHC * 1414f - (1183f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[3].y = (684f - this.KOHDFJMPEKQ) * 1445f + (1382f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[8].x = this.ICJGFPBOEHC * 556f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[4].y = (1977f - this.KOHDFJMPEKQ) * 56f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048BC RID: 18620 RVA: 0x002498D4 File Offset: 0x00247AD4
		public void GMIICEGONOC()
		{
			this.EDIFLGJFQJQ = new Vector2[8];
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1056f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].y = (1632f - this.KOHDFJMPEKQ) * 1385f + (1309f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 891f - (1510f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (456f - this.KOHDFJMPEKQ) * 575f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[2].x = this.ICJGFPBOEHC * 748f - (834f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[8].y = (324f - this.KOHDFJMPEKQ) * 23f + (1801f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 8f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].y = (663f - this.KOHDFJMPEKQ) * 1263f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048BD RID: 18621 RVA: 0x00249A40 File Offset: 0x00247C40
		public void FIBFCEDDLDQ()
		{
			this.EDIFLGJFQJQ = new Vector2[3];
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1303f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (746f - this.KOHDFJMPEKQ) * 7f + (1748f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 422f - (1311f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (1609f - this.KOHDFJMPEKQ) * 891f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[7].x = this.ICJGFPBOEHC * 804f - (338f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[8].y = (692f - this.KOHDFJMPEKQ) * 1207f + (670f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[8].x = this.ICJGFPBOEHC * 1440f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[5].y = (959f - this.KOHDFJMPEKQ) * 964f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x00249BAC File Offset: 0x00247DAC
		public void GELDKMIIFQL()
		{
			this.EDIFLGJFQJQ = new Vector2[4];
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 0.015625f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (64f - this.KOHDFJMPEKQ) * 0.015625f + (0.015625f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 0.015625f - (0.015625f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (64f - this.KOHDFJMPEKQ) * 0.015625f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[2].x = this.ICJGFPBOEHC * 0.015625f - (0.015625f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[2].y = (64f - this.KOHDFJMPEKQ) * 0.015625f + (0.015625f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[3].x = this.ICJGFPBOEHC * 0.015625f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[3].y = (64f - this.KOHDFJMPEKQ) * 0.015625f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x00249D18 File Offset: 0x00247F18
		public void LJCLNIJBLEH()
		{
			this.EDIFLGJFQJQ = new Vector2[5];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 52f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (1751f - this.KOHDFJMPEKQ) * 1176f + (521f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 389f - (352f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (701f - this.KOHDFJMPEKQ) * 1363f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[3].x = this.ICJGFPBOEHC * 595f - (131f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (1296f - this.KOHDFJMPEKQ) * 391f + (169f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[5].x = this.ICJGFPBOEHC * 834f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (670f - this.KOHDFJMPEKQ) * 1389f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048C0 RID: 18624 RVA: 0x00249E84 File Offset: 0x00248084
		public void HICOJPDIJHL()
		{
			this.EDIFLGJFQJQ = new Vector2[4];
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1041f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (306f - this.KOHDFJMPEKQ) * 1784f + (345f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1683f - (856f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (1312f - this.KOHDFJMPEKQ) * 1569f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[3].x = this.ICJGFPBOEHC * 39f - (1284f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[2].y = (436f - this.KOHDFJMPEKQ) * 1956f + (276f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[7].x = this.ICJGFPBOEHC * 1142f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[2].y = (1457f - this.KOHDFJMPEKQ) * 1594f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048C1 RID: 18625 RVA: 0x00249FF0 File Offset: 0x002481F0
		public void QNEMHEJIIFC()
		{
			this.EDIFLGJFQJQ = new Vector2[5];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 128f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].y = (1964f - this.KOHDFJMPEKQ) * 799f + (1494f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1394f - (1087f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (1462f - this.KOHDFJMPEKQ) * 811f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[8].x = this.ICJGFPBOEHC * 893f - (751f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (221f - this.KOHDFJMPEKQ) * 498f + (588f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[4].x = this.ICJGFPBOEHC * 1139f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[7].y = (620f - this.KOHDFJMPEKQ) * 812f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x0024A15C File Offset: 0x0024835C
		public void LJENIDDICPJ()
		{
			this.EDIFLGJFQJQ = new Vector2[7];
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 808f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].y = (1665f - this.KOHDFJMPEKQ) * 1655f + (483f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1471f - (949f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (1946f - this.KOHDFJMPEKQ) * 469f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[7].x = this.ICJGFPBOEHC * 1348f - (1429f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[3].y = (1844f - this.KOHDFJMPEKQ) * 584f + (681f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[8].x = this.ICJGFPBOEHC * 346f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[4].y = (835f - this.KOHDFJMPEKQ) * 1536f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x0024A2C8 File Offset: 0x002484C8
		public void EOPHPGCBLJM()
		{
			this.EDIFLGJFQJQ = new Vector2[3];
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 343f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].y = (1741f - this.KOHDFJMPEKQ) * 1584f + (1302f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1240f - (1088f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (1799f - this.KOHDFJMPEKQ) * 778f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[8].x = this.ICJGFPBOEHC * 969f - (1878f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (1074f - this.KOHDFJMPEKQ) * 1000f + (603f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[5].x = this.ICJGFPBOEHC * 1504f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (467f - this.KOHDFJMPEKQ) * 171f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048C4 RID: 18628 RVA: 0x0024A434 File Offset: 0x00248634
		public void PCMDLFCCGLI()
		{
			this.EDIFLGJFQJQ = new Vector2[4];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1779f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (721f - this.KOHDFJMPEKQ) * 1448f + (1099f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 160f - (393f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (1054f - this.KOHDFJMPEKQ) * 492f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[4].x = this.ICJGFPBOEHC * 1024f - (746f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (1410f - this.KOHDFJMPEKQ) * 932f + (875f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1396f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[6].y = (142f - this.KOHDFJMPEKQ) * 1043f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x0024A5A0 File Offset: 0x002487A0
		public void HQJQCJLIEOH()
		{
			this.EDIFLGJFQJQ = new Vector2[4];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 385f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].y = (446f - this.KOHDFJMPEKQ) * 1777f + (1476f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1194f - (1697f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (1267f - this.KOHDFJMPEKQ) * 478f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[2].x = this.ICJGFPBOEHC * 1503f - (4f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (1574f - this.KOHDFJMPEKQ) * 1638f + (591f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 787f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[4].y = (1725f - this.KOHDFJMPEKQ) * 489f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x0024A70C File Offset: 0x0024890C
		public void PQEJDBIGDJL()
		{
			this.EDIFLGJFQJQ = new Vector2[4];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 911f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (1433f - this.KOHDFJMPEKQ) * 733f + (689f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1215f - (784f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (1661f - this.KOHDFJMPEKQ) * 873f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[7].x = this.ICJGFPBOEHC * 1078f - (1058f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[3].y = (1659f - this.KOHDFJMPEKQ) * 353f + (1440f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[6].x = this.ICJGFPBOEHC * 944f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[7].y = (112f - this.KOHDFJMPEKQ) * 1155f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x0024A878 File Offset: 0x00248A78
		public void DDPIJKGCKEP()
		{
			this.EDIFLGJFQJQ = new Vector2[7];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 146f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].y = (660f - this.KOHDFJMPEKQ) * 1211f + (1415f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1861f - (1957f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (1946f - this.KOHDFJMPEKQ) * 98f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[3].x = this.ICJGFPBOEHC * 1527f - (266f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[5].y = (732f - this.KOHDFJMPEKQ) * 1497f + (211f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[3].x = this.ICJGFPBOEHC * 1996f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (761f - this.KOHDFJMPEKQ) * 1694f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x0024A9E4 File Offset: 0x00248BE4
		public void MHNKJKEFIOG()
		{
			this.EDIFLGJFQJQ = new Vector2[7];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1081f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (805f - this.KOHDFJMPEKQ) * 736f + (1748f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 2f - (1982f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (1979f - this.KOHDFJMPEKQ) * 1850f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[7].x = this.ICJGFPBOEHC * 600f - (1384f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (663f - this.KOHDFJMPEKQ) * 388f + (8f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[8].x = this.ICJGFPBOEHC * 1391f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[8].y = (635f - this.KOHDFJMPEKQ) * 678f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x0024AB50 File Offset: 0x00248D50
		public void FFCEQGECNED()
		{
			this.EDIFLGJFQJQ = new Vector2[1];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 352f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].y = (1381f - this.KOHDFJMPEKQ) * 1575f + (1198f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 918f - (1202f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (1349f - this.KOHDFJMPEKQ) * 610f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[6].x = this.ICJGFPBOEHC * 1947f - (192f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[3].y = (174f - this.KOHDFJMPEKQ) * 1796f + (1350f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1422f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[7].y = (568f - this.KOHDFJMPEKQ) * 1059f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x0024ACBC File Offset: 0x00248EBC
		public void BBNMBOQFCKO()
		{
			this.EDIFLGJFQJQ = new Vector2[0];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1712f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (829f - this.KOHDFJMPEKQ) * 94f + (1010f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 701f - (837f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (1755f - this.KOHDFJMPEKQ) * 226f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1382f - (1493f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[4].y = (67f - this.KOHDFJMPEKQ) * 271f + (4f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[6].x = this.ICJGFPBOEHC * 1006f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[6].y = (1340f - this.KOHDFJMPEKQ) * 594f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048CB RID: 18635 RVA: 0x0024AE28 File Offset: 0x00249028
		public void FDCFDKBBBPB()
		{
			this.EDIFLGJFQJQ = new Vector2[2];
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1611f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].y = (511f - this.KOHDFJMPEKQ) * 337f + (210f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 845f - (121f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (435f - this.KOHDFJMPEKQ) * 1528f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[2].x = this.ICJGFPBOEHC * 71f - (1622f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (1696f - this.KOHDFJMPEKQ) * 584f + (1817f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 711f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (890f - this.KOHDFJMPEKQ) * 1641f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x0024AF94 File Offset: 0x00249194
		public void DGLDCBQNIML()
		{
			this.EDIFLGJFQJQ = new Vector2[3];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 756f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (1791f - this.KOHDFJMPEKQ) * 541f + (844f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 303f - (791f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (1000f - this.KOHDFJMPEKQ) * 1558f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[5].x = this.ICJGFPBOEHC * 1901f - (1763f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[4].y = (697f - this.KOHDFJMPEKQ) * 1816f + (1284f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[2].x = this.ICJGFPBOEHC * 680f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].y = (1575f - this.KOHDFJMPEKQ) * 1036f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048CE RID: 18638 RVA: 0x0024B100 File Offset: 0x00249300
		public void KJNODJGLLNO()
		{
			this.EDIFLGJFQJQ = new Vector2[4];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 98f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (1178f - this.KOHDFJMPEKQ) * 669f + (1484f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1379f - (1192f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (812f - this.KOHDFJMPEKQ) * 309f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1546f - (1650f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (1704f - this.KOHDFJMPEKQ) * 339f + (806f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[3].x = this.ICJGFPBOEHC * 1737f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[7].y = (748f - this.KOHDFJMPEKQ) * 794f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048CF RID: 18639 RVA: 0x0024B26C File Offset: 0x0024946C
		public void OLNFMBDFKNM()
		{
			this.EDIFLGJFQJQ = new Vector2[3];
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1879f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (715f - this.KOHDFJMPEKQ) * 947f + (1323f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1656f - (401f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (559f - this.KOHDFJMPEKQ) * 71f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1220f - (994f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[7].y = (1436f - this.KOHDFJMPEKQ) * 1604f + (1490f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[7].x = this.ICJGFPBOEHC * 674f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[7].y = (127f - this.KOHDFJMPEKQ) * 1550f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048D0 RID: 18640 RVA: 0x0024B3D8 File Offset: 0x002495D8
		public void EKHOBPJLEFN()
		{
			this.EDIFLGJFQJQ = new Vector2[6];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 240f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].y = (50f - this.KOHDFJMPEKQ) * 785f + (603f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 927f - (1945f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (1491f - this.KOHDFJMPEKQ) * 1706f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[7].x = this.ICJGFPBOEHC * 441f - (260f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (686f - this.KOHDFJMPEKQ) * 6f + (1622f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[5].x = this.ICJGFPBOEHC * 892f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (1570f - this.KOHDFJMPEKQ) * 1523f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048D1 RID: 18641 RVA: 0x0024B544 File Offset: 0x00249744
		public void NOEHJBPFCOK()
		{
			this.EDIFLGJFQJQ = new Vector2[4];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 873f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (1233f - this.KOHDFJMPEKQ) * 1180f + (1215f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1745f - (381f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (1004f - this.KOHDFJMPEKQ) * 1369f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[2].x = this.ICJGFPBOEHC * 1191f - (1744f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[6].y = (23f - this.KOHDFJMPEKQ) * 451f + (1761f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[5].x = this.ICJGFPBOEHC * 1628f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[5].y = (362f - this.KOHDFJMPEKQ) * 874f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048D2 RID: 18642 RVA: 0x0024B6B0 File Offset: 0x002498B0
		public void NDFOMMDCQFB()
		{
			this.EDIFLGJFQJQ = new Vector2[2];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1332f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (326f - this.KOHDFJMPEKQ) * 1433f + (27f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1015f - (877f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (969f - this.KOHDFJMPEKQ) * 571f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[7].x = this.ICJGFPBOEHC * 1419f - (1029f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[6].y = (1564f - this.KOHDFJMPEKQ) * 335f + (189f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[6].x = this.ICJGFPBOEHC * 1749f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[3].y = (384f - this.KOHDFJMPEKQ) * 942f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048D3 RID: 18643 RVA: 0x0024B81C File Offset: 0x00249A1C
		public void MMOQEEIJGGN()
		{
			this.EDIFLGJFQJQ = new Vector2[6];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1295f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].y = (1972f - this.KOHDFJMPEKQ) * 1605f + (767f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1574f - (856f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (299f - this.KOHDFJMPEKQ) * 758f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[5].x = this.ICJGFPBOEHC * 1780f - (784f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (645f - this.KOHDFJMPEKQ) * 1343f + (182f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[7].x = this.ICJGFPBOEHC * 1036f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[3].y = (1287f - this.KOHDFJMPEKQ) * 5f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x0024B988 File Offset: 0x00249B88
		public void DDBJOEOMHPC()
		{
			this.EDIFLGJFQJQ = new Vector2[5];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 343f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].y = (114f - this.KOHDFJMPEKQ) * 1218f + (331f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 379f - (1514f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (457f - this.KOHDFJMPEKQ) * 1994f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[7].x = this.ICJGFPBOEHC * 283f - (1222f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[3].y = (351f - this.KOHDFJMPEKQ) * 1638f + (956f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[8].x = this.ICJGFPBOEHC * 1959f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[7].y = (202f - this.KOHDFJMPEKQ) * 502f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048D5 RID: 18645 RVA: 0x0024BAF4 File Offset: 0x00249CF4
		public void BGCFIDLMKHO()
		{
			this.EDIFLGJFQJQ = new Vector2[1];
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1941f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (1067f - this.KOHDFJMPEKQ) * 75f + (1481f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1724f - (1832f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (1155f - this.KOHDFJMPEKQ) * 820f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[2].x = this.ICJGFPBOEHC * 421f - (586f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[2].y = (1061f - this.KOHDFJMPEKQ) * 114f + (248f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[8].x = this.ICJGFPBOEHC * 912f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[8].y = (933f - this.KOHDFJMPEKQ) * 914f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048D6 RID: 18646 RVA: 0x0024BC60 File Offset: 0x00249E60
		public void MHEKIMEIPEE()
		{
			this.EDIFLGJFQJQ = new Vector2[6];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1677f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (1636f - this.KOHDFJMPEKQ) * 1339f + (1945f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1603f - (737f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (1385f - this.KOHDFJMPEKQ) * 1831f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1889f - (546f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (800f - this.KOHDFJMPEKQ) * 789f + (1918f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[5].x = this.ICJGFPBOEHC * 1154f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[7].y = (1135f - this.KOHDFJMPEKQ) * 1269f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048D7 RID: 18647 RVA: 0x0024BDCC File Offset: 0x00249FCC
		public void JINCOOKOFGI()
		{
			this.EDIFLGJFQJQ = new Vector2[2];
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1495f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].y = (472f - this.KOHDFJMPEKQ) * 250f + (1685f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1347f - (599f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (700f - this.KOHDFJMPEKQ) * 692f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1211f - (1022f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[6].y = (1171f - this.KOHDFJMPEKQ) * 1112f + (811f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[6].x = this.ICJGFPBOEHC * 876f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[3].y = (687f - this.KOHDFJMPEKQ) * 1836f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048D8 RID: 18648 RVA: 0x0024BF38 File Offset: 0x0024A138
		public void HBFFEDMCMGK()
		{
			this.EDIFLGJFQJQ = new Vector2[3];
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 601f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].y = (1421f - this.KOHDFJMPEKQ) * 1350f + (1808f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].x = this.ICJGFPBOEHC * 1887f - (1878f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[1].y = (1127f - this.KOHDFJMPEKQ) * 1400f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1968f - (129f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[8].y = (754f - this.KOHDFJMPEKQ) * 1692f + (1116f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1088f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[4].y = (1091f - this.KOHDFJMPEKQ) * 848f + this.LQNIFNKGDLB;
		}

		// Token: 0x060048D9 RID: 18649 RVA: 0x0024C0A4 File Offset: 0x0024A2A4
		public void CJEOCHHODKJ()
		{
			this.EDIFLGJFQJQ = new Vector2[1];
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1796f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[1].y = (1152f - this.KOHDFJMPEKQ) * 896f + (30f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1116f - (1093f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[0].y = (1569f - this.KOHDFJMPEKQ) * 1714f + this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[0].x = this.ICJGFPBOEHC * 1480f - (1582f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[3].y = (461f - this.KOHDFJMPEKQ) * 1330f + (737f - this.LQNIFNKGDLB);
			this.EDIFLGJFQJQ[8].x = this.ICJGFPBOEHC * 562f - this.LQNIFNKGDLB;
			this.EDIFLGJFQJQ[5].y = (966f - this.KOHDFJMPEKQ) * 1413f + this.LQNIFNKGDLB;
		}

		// Token: 0x04000F87 RID: 3975
		public float ICJGFPBOEHC;

		// Token: 0x04000F88 RID: 3976
		public float KOHDFJMPEKQ;

		// Token: 0x04000F89 RID: 3977
		public Vector2[] EDIFLGJFQJQ;

		// Token: 0x04000F8A RID: 3978
		private float LQNIFNKGDLB = 0.0003f;
	}

	// Token: 0x02000219 RID: 537
	private enum KFMMIKQIJDJ
	{
		// Token: 0x04000F8C RID: 3980
		Top,
		// Token: 0x04000F8D RID: 3981
		Left,
		// Token: 0x04000F8E RID: 3982
		Front,
		// Token: 0x04000F8F RID: 3983
		Right
	}
}
