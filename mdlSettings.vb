Module mdlSettings
    Public ApplicantStatusId As Integer = getApplicantStatusId()
    Public EmployeeStatusId As Integer = getEmployeeStatusId()
    Public RetiredStatusId As Integer = getRetiredStatusId()
    Public TraineeStatusId As Integer = getTraineeStatusId()
    Public traineePositionId As Integer = getTraineePositionId()
    Public UnemploymentStatusId As Integer = getUnemploymentStatusId
    'Public HolidayTypeId As Integer = getHolidayTypeId()
    Public YearlyVacationId As Integer = getYearlyVacationId()
    Public UserId As Integer
    Public MyEmployeeId As Integer


    Function getApplicantStatusId() As Integer
        Using aMainor As New LqHRDataContext(cnx)
            Dim r = aMainOr.TblSettings.ToList()
            If r.Count > 0 Then
                If r.ToList(0).ApplicantStatusId IsNot Nothing Then
                    Return r.ToList(0).ApplicantStatusId
                End If
            End If
        End Using
        Return 0
    End Function



    Function getUnemploymentStatusId() As Integer
        Using aMainor As New LqHRDataContext(cnx)
            Dim r = aMainor.TblSettings.ToList()
            If r.Count > 0 Then
                If r.ToList(0).UnemploymentStatusId IsNot Nothing Then
                    Return r.ToList(0).UnemploymentStatusId
                End If
            End If
        End Using
        Return 0
    End Function


    Function getEmployeeStatusId() As Integer
        Using aMainor As New LqHRDataContext(cnx)
            Dim r = aMainOr.TblSettings.ToList()
            If r.Count > 0 Then
                If r.ToList(0).EmployeeStatusId IsNot Nothing Then
                    Return r.ToList(0).EmployeeStatusId
                End If
            End If
        End Using
        Return 0
    End Function

    Function getRetiredStatusId() As Integer
        Using aMainor As New LqHRDataContext(cnx)
            Dim r = aMainOr.TblSettings.ToList()
            If r.Count > 0 Then
                If r.ToList(0).RetiredStatusId IsNot Nothing Then
                    Return r.ToList(0).RetiredStatusId
                End If
            End If
        End Using
        Return 0
    End Function

    Function getTraineeStatusId() As Integer
        Using aMainor As New LqHRDataContext(cnx)
            Dim r = aMainOr.TblSettings.ToList()
            If r.Count > 0 Then
                If r.ToList(0).TraineeStatutsId IsNot Nothing Then
                    Return r.ToList(0).TraineeStatutsId
                End If
            End If
        End Using
        Return 0
    End Function

    Function getHolidayTypeId() As Integer
        Using aMainor As New LqHRDataContext(cnx)
            Dim r = aMainOr.TblSettings.ToList()
            If r.Count > 0 Then
                If r.ToList(0).HolidayTypeId IsNot Nothing Then
                    Return r.ToList(0).HolidayTypeId
                End If
            End If
        End Using
        Return 0
    End Function

    Function getYearlyVacationId() As Integer
        Using aMainor As New LqHRDataContext(cnx)
            Dim r = aMainor.TblSettings.ToList()
            If r.Count > 0 Then
                If r.ToList(0).YearlyVacationId IsNot Nothing Then
                    Return r.ToList(0).YearlyVacationId
                End If
            End If
        End Using
        Return 0
    End Function

    Function getTraineePositionId() As Integer
        Using aMainor As New LqHRDataContext(cnx)
            Dim r = aMainor.TblSettings.ToList()
            If r.Count > 0 Then
                If r.ToList(0).TraineePositionId IsNot Nothing Then
                    Return r.ToList(0).TraineePositionId
                End If
            End If
        End Using
        Return 0
    End Function
End Module
