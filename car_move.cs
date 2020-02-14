using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

public class car_move : MonoBehaviour
{
    public GameObject gameobject;

    public int i = 0;
    public int t = 1;
    public int x;
    public int y;
    public int z;

    /*
    public RenderTexture screenshotback;
    public RenderTexture screenshotright;
    public RenderTexture screenshotleft;
     */

    public Transform car11;
    public Transform car12;
    public Transform car13;
    public Transform car14;
    public Transform car15;
    public Transform car16;
    public Transform car17;
    public Transform car18;
    public Transform car19;

    public Transform car21;
    public Transform car22;
    public Transform car23;
    public Transform car24;
    public Transform car25;
    public Transform car26;
    public Transform car27;
    public Transform car28;
    public Transform car29;

    public Transform car31;
    public Transform car32;
    public Transform car33;
    public Transform car34;
    public Transform car35;
    public Transform car36;
    public Transform car37;
    public Transform car38;
    public Transform car39;

    public float space1 = 139.0f;
    public float space2 = 142.0f;
    public float space3 = 145.0f;

    public Vector3 ini11;
    public Vector3 ini12;
    public Vector3 ini13;
    public Vector3 ini14;
    public Vector3 ini15;
    public Vector3 ini16;
    public Vector3 ini17;
    public Vector3 ini18;
    public Vector3 ini19;

    public Vector3 ini21;
    public Vector3 ini22;
    public Vector3 ini23;
    public Vector3 ini24;
    public Vector3 ini25;
    public Vector3 ini26;
    public Vector3 ini27;
    public Vector3 ini28;
    public Vector3 ini29;

    public Vector3 ini31;
    public Vector3 ini32;
    public Vector3 ini33;
    public Vector3 ini34;
    public Vector3 ini35;
    public Vector3 ini36;
    public Vector3 ini37;
    public Vector3 ini38;
    public Vector3 ini39;

    public Transform wall;
    public Transform tree1;
    public Transform tree2;

    Vector3 carp;
    Quaternion carr;


    //System.Random r = new System.Random(1000);

    // Use this for initialization
    void Start ()
    {
        ini11 = car11.position;
        ini12 = car12.position;
        ini13 = car13.position;
        ini14 = car14.position;
        ini15 = car15.position;
        ini16 = car16.position;
        ini17 = car17.position;
        ini18 = car18.position;
        ini19 = car19.position;

        ini21 = car21.position;
        ini22 = car22.position;
        ini23 = car23.position;
        ini24 = car24.position;
        ini25 = car25.position;
        ini26 = car26.position;
        ini27 = car27.position;
        ini28 = car28.position;
        ini29 = car29.position;

        ini31 = car31.position;
        ini32 = car32.position;
        ini33 = car33.position;
        ini34 = car34.position;
        ini35 = car35.position;
        ini36 = car36.position;
        ini37 = car37.position;
        ini38 = car38.position;
        ini39 = car39.position;

        carp = this.transform.position;
        carr = this.transform.rotation;

    }

    // Update is called once per frame
    public void Update()
    {
        if (i % 20 == 0)
        {
            //posという3次元ベクトルにドライバーの位置を代入
            Vector3 pos = this.gameobject.transform.position;

            /*
            //x座標だけposが書き換えられる
            this.gameObject.transform.position = new Vector3(pos.x , pos.y , pos.z-0.1f);
            */

            //木、壁、車の配置の決定
            System.Random r = new System.Random();

            //木
            int xt1 = r.Next(12, 21);
            int xt2 = r.Next(12, 21);
            int zt1 = r.Next(130, 156);
            int zt2 = r.Next(130, 156);
            //壁(出現率25%)
            int w = r.Next(0, 4);
            //車の配置の有無
            int s1 = r.Next(0, 2);
            int s2 = r.Next(0, 2);
            int s3 = r.Next(0, 2);
            //driverの位置
            int c = r.Next(0, 3);

            //動作確認
            //Debug.Log(xt1);
            //Debug.Log(xt2);
            //Debug.Log(zt1);
            //Debug.Log(zt2);
            //Debug.Log(c);

            //driverの位置、角度決定
            if(c == 0)
            {
                this.transform.position = new Vector3(-2.299f, 0.2f, 141.8f);
                this.transform.Rotate(new Vector3(0f, 0f, 0f));
            }
            if (c == 1)
            {
                this.transform.position = new Vector3(-2.299f, 0.2f, 144.8f);
                this.transform.Rotate(new Vector3(0f, 30f, 0f));
            }
            if (c == 2)
            {
                this.transform.position = new Vector3(-2.299f, 0.2f, 138.8f);
                this.transform.Rotate(new Vector3(0f, -30f, 0f));
            }

            //木の配置
            tree1.position = new Vector3(0f + xt1, 0f, 0f + zt1);
            tree2.position = new Vector3(0f + xt2, 0f, 0f + zt2);
            
            //壁の有無
            if(w==0||w==1||w==2)
            {
                wall.transform.localScale = new Vector3(2, 0, 150);
            }
            if (w == 3)
            {
                wall.transform.localScale = new Vector3(2, 150, 150);
            }
        
            if(s1 == 1)
            {
                Trans1(space1);
            }

            if (s2 == 1)
            {
                Trans2(space2);
            }
        
            if (s3 == 1)
            {
                Trans3(space3);
            }
        

        /*    
        //スクリーンショット
            if (s1 == 0 && s2 == 0 && s3 == 0)
            {
                ScreenCapture.CaptureScreenshot("C:/Users/ics2015/Desktop/M1/研究室/parking_lot/image_000/screenshot" + t + ".png");
            }
            if (s1 == 1 && s2 == 0 && s3 == 0)
            {
                ScreenCapture.CaptureScreenshot("C:/Users/ics2015/Desktop/M1/研究室/parking_lot/image_001/screenshot" + t + ".png");
            }
            if (s1 == 0 && s2 == 1 && s3 == 0)
            {
                ScreenCapture.CaptureScreenshot("C:/Users/ics2015/Desktop/M1/研究室/parking_lot/image_010/screenshot" + t + ".png");
            }
            if (s1 == 1 && s2 == 1 && s3 == 0)
            {
                ScreenCapture.CaptureScreenshot("C:/Users/ics2015/Desktop/M1/研究室/parking_lot/image_011/screenshot" + t + ".png");
            }
            if (s1 == 0 && s2 == 0 && s3 == 1)
            {
                ScreenCapture.CaptureScreenshot("C:/Users/ics2015/Desktop/M1/研究室/parking_lot/image_100/screenshot" + t + ".png");
            }
            if (s1 == 1 && s2 == 0 && s3 == 1)
            {
                ScreenCapture.CaptureScreenshot("C:/Users/ics2015/Desktop/M1/研究室/parking_lot/image_101/screenshot" + t + ".png");
            }
            if (s1 == 0 && s2 == 1 && s3 == 1)
            {
                ScreenCapture.CaptureScreenshot("C:/Users/ics2015/Desktop/M1/研究室/parking_lot/image_110/screenshot" + t + ".png");
            }
            if (s1 == 1 && s2 == 1 && s3 == 1)
            {
                ScreenCapture.CaptureScreenshot("C:/Users/ics2015/Desktop/M1/研究室/parking_lot/image_111/screenshot" + t + ".png");
            }
            */
        }    
        

        if(i % 20 == 10)
        {
            Reset();
            //Debug.Log(car11.transform.position);
            this.gameObject.transform.position = carp;
            this.gameObject.transform.rotation = carr;
            //Debug.Log(this.transform.position);
            t += 1;
        }

        i += 1;
    }

    //Space1に入る車種の決定
    public void Trans1(float pos)
    {
        System.Random t1 = new System.Random();

        x = t1.Next(0, 9);
        Debug.Log(x);

        if(x == 0)
        {
            Vector3 a = car11.position;
            a.z = pos;
            car11.position = a;
        }
        if (x == 1)
        {
            Vector3 a = car12.position;
            a.z = pos;
            car12.position = a;
        }
        if (x == 2)
        {
            Vector3 a = car13.position;
            a.z = pos;
            car13.position = a;
        }
        if (x == 3)
        {
            Vector3 a = car14.position;
            a.z = pos;
            car14.position = a;
        }
        if (x == 4)
        {
            Vector3 a = car15.position;
            a.z = pos;
            car15.position = a;
        }
        if (x == 5)
        {
            Vector3 a = car16.position;
            a.z = pos;
            car16.position = a;
        }
        if (x == 6)
        {
            Vector3 a = car17.position;
            a.z = pos;
            car17.position = a;
        }
        if (x == 7)
        {
            Vector3 a = car18.position;
            a.z = pos;
            car18.position = a;
        }
        if (x == 8)
        {
            Vector3 a = car19.position;
            a.z = pos;
            car19.position = a;
        }
    }

    //Space2に入る車種の決定
    public void Trans2(float pos)
    {
        System.Random t2 = new System.Random();

        y = t2.Next(10, 19);
        Debug.Log(y);

        if (y == 10)
        {
            Vector3 b = car21.position;
            b.z = pos;
            car21.position = b;
        }
        if (y == 11)
        {
            Vector3 b = car22.position;
            b.z = pos;
            car22.position = b;
        }
        if (y == 12)
        {
            Vector3 b = car23.position;
            b.z = pos;
            car23.position = b;
        }
        if (y == 13)
        {
            Vector3 b = car24.position;
            b.z = pos;
            car24.position = b;
        }
        if (y == 14)
        {
            Vector3 b = car25.position;
            b.z = pos;
            car25.position = b;
        }
        if (y == 15)
        {
            Vector3 b = car26.position;
            b.z = pos;
            car26.position = b;
        }
        if (y == 16)
        {
            Vector3 b = car27.position;
            b.z = pos;
            car27.position = b;
        }
        if (y == 17)
        {
            Vector3 b = car28.position;
            b.z = pos;
            car28.position = b;
        }
        if (y == 18)
        {
            Vector3 b = car29.position;
            b.z = pos;
            car29.position = b;
        }
    }

    //Space3に入る車種の決定
    public void Trans3(float pos)
    {
        System.Random t3 = new System.Random();

        z = t3.Next(25, 34);
        Debug.Log(z);

        if (z == 25)
        {
            Vector3 c = car31.position;
            c.z = pos;
            car31.position = c;
        }
        if (z == 26)
        {
            Vector3 c = car32.position;
            c.z = pos;
            car32.position = c;
        }
        if (z == 27)
        {
            Vector3 c = car33.position;
            c.z = pos;
            car33.position = c;
        }
        if (z == 28)
        {
            Vector3 c = car34.position;
            c.z = pos;
            car34.position = c;
        }
        if (z == 29)
        {
            Vector3 c = car35.position;
            c.z = pos;
            car35.position = c;
        }
        if (z == 30)
        {
            Vector3 c = car36.position;
            c.z = pos;
            car36.position = c;
        }
        if (z == 31)
        {
            Vector3 c = car37.position;
            c.z = pos;
            car37.position = c;
        }
        if (z == 32)
        {
            Vector3 c = car38.position;
            c.z = pos;
            car38.position = c;
        }
        if (z == 33)
        {
            Vector3 c = car39.position;
            c.z = pos;
            car39.position = c;
        }
    }


    //車の位置のリセット
    public void Reset()
    {
        car11.position = ini11;
        car12.position = ini12;
        car13.position = ini13;
        car14.position = ini14;
        car15.position = ini15;
        car16.position = ini16;
        car17.position = ini17;
        car18.position = ini18;
        car19.position = ini19;

        car21.position = ini21;
        car22.position = ini22;
        car23.position = ini23;
        car24.position = ini24;
        car25.position = ini25;
        car26.position = ini26;
        car27.position = ini27;
        car28.position = ini28;
        car29.position = ini29;

        car31.position = ini31;
        car32.position = ini32;
        car33.position = ini33;
        car34.position = ini34;
        car35.position = ini35;
        car36.position = ini36;
        car37.position = ini37;
        car38.position = ini38;
        car39.position = ini39;

    }
}