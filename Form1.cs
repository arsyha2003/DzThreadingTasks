namespace DzThreadingTasks
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource numbersCancellationTokenSource;
        private CancellationTokenSource fibonacciCancellationTokenSource;

        private CancellationToken numbersCancelerationToken;
        private CancellationToken fibonacciCancelerationToken;

        private ManualResetEventSlim numbersPauseEvent;
        private ManualResetEventSlim fibonacciPauseEvent;

        private int range1 = 2;
        private int range2 = int.MaxValue;
        public Form1()
        {
            InitializeComponent();
            numbersPauseEvent = new ManualResetEventSlim(true);
            fibonacciPauseEvent = new ManualResetEventSlim(true);
        }
        private void Form1_Load(object sender, EventArgs e) { }
        private void StartGeneratingNumbersButton(object sender, EventArgs e)
        {
            numbersCancellationTokenSource = new CancellationTokenSource();          
            numbersCancelerationToken = numbersCancellationTokenSource.Token;

            try
            {
                range1 = int.Parse(textBox1.Text);
                range2 = int.Parse(textBox2.Text);
            }
            catch
            {
                range1 = 2;
                range2 = int.MaxValue;
            }
            if(range1>range2) (range1, range2) = (range2, range1);
            Task t1 = new Task(() => GeneratingNumbers());
            t1.Start();
        }
        private void StopGeneratingNumbersButton(object sender, EventArgs e)
        {
            numbersCancellationTokenSource?.Cancel();
            numbersCancelerationToken = numbersCancellationTokenSource.Token;
        }
        private void PauseGeneratingButtons(object sender, EventArgs e)
        {
            numbersPauseEvent.Reset();
        }
        private void UnpauseGeneratingButtons(object sender, EventArgs e)
        {
            numbersPauseEvent.Set();
        }
        private void StartGeneratingFibonacciButton(object sender, EventArgs e)
        {
            fibonacciCancellationTokenSource = new CancellationTokenSource();
            fibonacciCancelerationToken = fibonacciCancellationTokenSource.Token;
            Task t1 = new Task(() => GeneratingFibbonacci());
            t1.Start();
        }
        private void StopGeneratingFibonacciButton(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                fibonacciCancellationTokenSource?.Cancel();
                fibonacciCancelerationToken = fibonacciCancellationTokenSource.Token;
            }
            catch { }
        }
        private void PauseGeneratingFibonacciButtons(object sender, EventArgs e)
        {
            fibonacciPauseEvent.Reset();
        }
        private void UnpauseGeneratingFibonacciButtons(object sender, EventArgs e)
        {
            fibonacciPauseEvent.Set();
        }
        private void GeneratingFibbonacci()
        {
            int fibonnaciNumber = 0;
            for(int i=0;i<int.MaxValue;i++)
            {
                Thread.Sleep(100);
                fibonacciPauseEvent.Wait();
                if (fibonacciCancelerationToken.IsCancellationRequested)
                {
                    break;
                }
                if (i<=1)
                {
                    listBox1.Items.Add(i);
                }
                else if(i>1)
                {
                    fibonnaciNumber = (i-2)+(i-1);
                    listBox1.Items.Add(fibonnaciNumber);
                }
            }
        }
        private void GeneratingNumbers()
        {
            while(true)
            {
                numbersPauseEvent.Wait();
                if (numbersCancelerationToken.IsCancellationRequested)
                {
                    break;
                }
                Thread.Sleep(100);
                textBox3.Text = new Random().Next(range1,range2).ToString();
            }
        }
    }
}
