async function showMachines(technology) {

    try {
        const technologyValue = encodeURIComponent(technology);
        const url = `/CuttingMachine/GetMachines?technology=${technologyValue}`;
        const response = await fetch(url, { method: 'GET' });

        const data = await response.json();
        const machineTable = document.getElementById('machineTable');
        const machineData = document.getElementById('machineData');
        while (machineData.firstChild) {
            machineData.removeChild(machineData.firstChild);
        }
        
        data.forEach(machine => {
            const row = document.createElement('tr');
            const nameCell = document.createElement('td');
            const manufacturerCell = document.createElement('td');
            const technologyCell = document.createElement('td');
            nameCell.textContent = machine.name;
            manufacturerCell.textContent = machine.manufacturer;
            technologyCell.textContent = technology;
            row.appendChild(nameCell);
            row.appendChild(manufacturerCell);
            row.appendChild(technologyCell);
            machineData.appendChild(row);
        });
        machineTable.style.display = 'block';
    } catch (error) {
        console.error('Error en la solicitud:', error);
    }
}