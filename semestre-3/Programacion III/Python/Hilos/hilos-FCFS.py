import time
import threading

class FCFS(threading.Thread):
    def __init__(self, burstTime):
        threading.Thread.__init__(self)
        self.burstTime=burstTime
        n=len(burstTime)
        self.waintingTime=[0]*n
        self.turnaroundTime=[0]*n
    def run(self):
        n=len(self.burstTime)
        totalWaitingTime=0
        totalTurnaroundTime=0
        print("Process\tBurst Time\tWaiting Time\tTurnaround Time")
        arrivalTime=0
        for i in range(n):
            time.sleep(arrivalTime)
            temp=self.burstTime[i]
            print(f"P{i+1} \t{temp}\t\t{totalWaitingTime}\t\t{totalTurnaroundTime+temp}")
            self.waintingTime[i] = totalWaitingTime
            totalWaitingTime+=temp
            self.turnaroundTime[i]=totalTurnaroundTime+temp
            totalTurnaroundTime+=temp
        print(f"Tiempo total:{totalTurnaroundTime}")

burst=[6,8,4,2,3]
fcfs=FCFS(burst)
fcfs.start()